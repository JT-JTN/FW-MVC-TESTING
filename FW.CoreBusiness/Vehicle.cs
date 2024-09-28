using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FW.CoreBusiness
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Vin { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string SubModel { get; set; } = string.Empty;
        public int? Color { get; set; }
        [ForeignKey("Color"), JsonIgnore]
        public AppColor AppColor { get; set; } = null!;
        public int? Owner { get; set; }
        [ForeignKey("Owner"), JsonIgnore]
        public Client Client { get; set; } = null!;

        public Vehicle()
        {
            
        }
    }
}