﻿namespace Truphone.Infrastructure.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }

        public List<Device> Devices { get; } = new();
    }
}