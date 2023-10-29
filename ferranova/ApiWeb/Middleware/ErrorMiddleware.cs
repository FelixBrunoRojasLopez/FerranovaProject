using AutoMapper;
using Business;
using CommonModel;
using IBusiness;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RequestResponseModel;

namespace ApiWeb.Middleware
{
    public class ErrorMiddleware
    {
        private readonly RequestDelegate next;
        private readonly IHelperHttpContext _helperHttpContext = null;
        private readonly IMapper _mapper;
        private readonly IErrorBusiness _errorBusiness;

        public ErrorMiddleware(RequestDelegate next, IMapper mapper)
        {
            this.next = next;
            _helperHttpContext = new HelperHttpContext();
            _mapper = mapper;
            _errorBusiness = new ErrorBusiness(mapper);

        }

        public async Task Invoke(HttpContext context)
        {
            try
            {

                //string codigoAplicacion = context.Request.Headers["codigoAplicacion"].ToString();
                //if(codigoAplicacion == null || codigoAplicacion != "456789")
                //{
                //    throw new Exception("No se envió el código de aplicación correcto");
                //}

                context.Request.EnableBuffering();
                await next(context);
            }
            catch (SqlException ex)
            {
                CustomException exx = new CustomException("001", "Error en base de datos");
                await HandleExceptionAsync(context, exx);
            }
            catch (DbUpdateException ex)
            {
                CustomException exx = new CustomException("002", "Error al actualizar registros");
                await HandleExceptionAsync(context, exx);
            }
            catch (DivideByZeroException ex)
            {
                CustomException exx = new CustomException("003", "Error de división entre 0");
                await HandleExceptionAsync(context, exx);
            }
            catch (ArithmeticException ex)
            {
                CustomException exx = new CustomException("004", "Error al hacer algun calculo");
                await HandleExceptionAsync(context, exx);
            }
            catch (Exception ex)
            {
                CustomException exx = new CustomException("005", "Error no controlado");
                await HandleExceptionAsync(context, exx);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, CustomException ex)
        {
            var controllerActionDescriptor = context.GetEndpoint().Metadata.GetMetadata<ControllerActionDescriptor>();
            //var controllerName = controllerActionDescriptor.ControllerName;
            //var actionName = controllerActionDescriptor.ActionName;

            InfoRequest info = new InfoRequest();
            info = _helperHttpContext.GetInfoRequest(context);
            GenericResponse error = new GenericResponse();

            //error = _errorBusiness.Register(ex, info);
            ErrorRequest err = new ErrorRequest();
            //_errorBusiness.Create(err);

            err.Url = info.RequestHttp.AbsoluteUri;
            err.Controller = info.RequestHttp.Controller;
            err.Ip = info.RequestHttp.Ip;
            err.Method = info.RequestHttp.Method;
            err.UserAgent = info.RequestHttp.UserAgent;
            err.Host = info.RequestHttp.Host;
            err.ClassComponent = "ClassComponent";
            err.FunctionName = "FuncionName";
            err.LineNumber = 0;
            err.Error1 = ex.Message;
            err.StackTrace = ex.StackTrace == null ? "" : ex.StackTrace.ToString();
            err.Status = 1;
            err.Request = "";
            err.ErrorCode = 0;
            err.IdPersona = info.Claims.IdPersona;
            err.IdUsuarioAcceso = info.Claims.UserId;

            _errorBusiness.Create(err);

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = 500;
            return context.Response.WriteAsJsonAsync(error);
        }
    }
}