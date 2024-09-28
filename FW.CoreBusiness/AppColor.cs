using System.Text.Json.Serialization;

namespace FW.CoreBusiness
{
    public class AppColor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Abbreviation { get; set; } = string.Empty;

        [JsonIgnore]
        public virtual ICollection<Vehicle>? Vehicles { get; set; }
    }
}
