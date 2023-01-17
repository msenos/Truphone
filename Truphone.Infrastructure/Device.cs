namespace Truphone.Infrastructure
{
    public class Device
    {
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public DateTime Created { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }



    }
}