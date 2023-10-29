using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class ErrorResponse
    {
        public int IdError { get; set; }
        [StringLength(100)]
        public string? Url { get; set; }
        [StringLength(200)]
        public string? Controller { get; set; }
        [StringLength(100)]
        public string? Ip { get; set; }
        [StringLength(20)]
        public string? Method { get; set; }
        [StringLength(150)]
        public string? UserAgent { get; set; }
        [StringLength(100)]
        public string? Host { get; set; }
        [StringLength(100)]
        public string? ClassComponent { get; set; }
        [StringLength(100)]
        public string? FunctionName { get; set; }
        public int? LineNumber { get; set; }
        [StringLength(200)]
        public string? Error1 { get; set; }
        [StringLength(200)]
        public string? StackTrace { get; set; }
        public short? Status { get; set; }
        public string? Request { get; set; }
        public int ErrorCode { get; set; }
        public int IdPersona { get; set; }
        public int IdUsuarioAcceso { get; set; }
    }
}
