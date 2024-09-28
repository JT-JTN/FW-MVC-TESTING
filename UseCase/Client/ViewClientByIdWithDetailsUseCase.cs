using UseCase.Client.Interface;
using UseCase.Plugins;
using UseCase.ViewModels.Client;

namespace UseCase.Client
{
    public class ViewClientByIdWithDetailsUseCase : IViewClientByIdWithDetailsUseCase
    {
        private readonly IClientRepository _clientRepository;

        public ViewClientByIdWithDetailsUseCase(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<DetailsViewModel> Execute(int id)
        {
            return await _clientRepository.GetClientByIdWithDetailsAsync(id);
        }
    }
}
