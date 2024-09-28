using UseCase.Client.Interface;
using UseCase.Plugins;

namespace UseCase.Client
{
    public class ViewClientsByNameUseCase : IViewClientsByNameUseCase
    {
        private readonly IClientRepository _clientRepository;

        public ViewClientsByNameUseCase(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<IEnumerable<FW.CoreBusiness.Client>> Execute(string search)
        {
            return await _clientRepository.GetClientsByNameAsync(search);
        }
    }
}
