namespace UseCase.Client.Interface
{
    public interface IViewClientsByNameUseCase
    {
        Task<IEnumerable<FW.CoreBusiness.Client>> Execute(string search);
    }
}