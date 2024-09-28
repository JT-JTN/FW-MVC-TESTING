using UseCase.Client.Interface;
using UseCase.Plugins;

namespace UseCase.Client
{
    public class ViewAllClientsUseCase : IViewAllClientsUseCase
    {
        private readonly IClientRepository _clientRepository;

        public ViewAllClientsUseCase(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<IEnumerable<FW.CoreBusiness.Client>> Execute()
        {
            return await _clientRepository.GetAllClientsAsync();
        }
    }
}
