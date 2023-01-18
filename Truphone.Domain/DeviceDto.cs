using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Truphone.Domain
{
    public class DeviceDto : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public BrandDto Brand { get; set; }

        public DeviceDto()
        {
            Brand = new BrandDto();
        }
    }
}
