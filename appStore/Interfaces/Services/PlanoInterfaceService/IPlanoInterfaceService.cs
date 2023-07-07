using api.Models.AdesaoPlanoModel;

namespace api.Interfaces.PlanoInterfaceService
{
    public interface IPlanoInterfaceService
    {
        Task<string> AdesaoPlano(CartaoAdesaoPlanoModel data);
    }
}