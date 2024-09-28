namespace UseCase.Client.Interface
{
    public interface IViewClientByIdUseCase
    {
        Task<FW.CoreBusiness.Client> Execute(int id);
    }
}