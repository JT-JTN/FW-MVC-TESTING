namespace UseCase.Client.Interface
{
    public interface IViewAllClientsUseCase
    {
        Task<IEnumerable<FW.CoreBusiness.Client>> Execute();
    }
}