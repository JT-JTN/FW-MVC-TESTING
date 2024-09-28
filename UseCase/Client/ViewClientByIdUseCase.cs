using UseCase.Client.Interface;
using UseCase.Plugins;

namespace UseCase.Client
{
    public class ViewClientByIdUseCase : IViewClientByIdUseCase
    {
        private readonly IClientRepository _clientRepository;

        public ViewClientByIdUseCase(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<FW.CoreBusiness.Client> Execute(int id)
        {
            return await _clientRepository.GetClientByIdAsync(id);
        }
    }
}
