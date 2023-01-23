namespace Truphone.Infrastructure.Models
{
    public class Device
    {
        public int DeviceId { get; set; }
        public string DeviceName { get; set; } = string.Empty;
        public DateTime Created { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}