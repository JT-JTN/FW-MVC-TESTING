using UseCase.ViewModels.Client;

namespace UseCase.Client.Interface
{
    public interface IViewClientByIdWithDetailsUseCase
    {
        Task<DetailsViewModel> Execute(int id);
    }
}