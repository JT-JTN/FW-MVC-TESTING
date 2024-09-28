using FW.CoreBusiness;

namespace UseCase.ViewModels.Client
{
    public class DetailsViewModel
    {
        public FW.CoreBusiness.Client Client { get; set; } = null!;
        public string CreatedByEmail { get; set; } = string.Empty;
        public string UpdateByEmail { get; set; } = string.Empty;
        public AppColor Color { get; set; } = null!;
    }
}
