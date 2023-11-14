using RequestResponseModel;

namespace IService
{
    public interface IApisPeruService : IDisposable
    {
        ApisPeruPersonaResponse PersonaPorDNI(string dni);
        ApisPeruEmpresaResponse EmpresaPorRUC(string dni);

    }
}