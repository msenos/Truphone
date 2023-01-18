namespace Truphone.Infrastructure.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; } = string.Empty;

        public List<Device> Devices { get; } = new();
    }
}