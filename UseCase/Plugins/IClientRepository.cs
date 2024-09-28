


using UseCase.ViewModels.Client;

namespace UseCase.Plugins
{
    public interface IClientRepository
    {
        Task<IEnumerable<FW.CoreBusiness.Client>> GetClientsByNameAsync(string search);
        Task<IEnumerable<FW.CoreBusiness.Client>> GetAllClientsAsync();
        Task<FW.CoreBusiness.Client> GetClientByIdAsync(int id);
        Task<DetailsViewModel> GetClientByIdWithDetailsAsync(int id);
    }
}
