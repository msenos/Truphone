using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truphone.Application.Interfaces;
using Truphone.Domain;

namespace Truphone.Infrastructure
{
    public class TruphoneRepository : ITruphoneRepository
    {
        private readonly TruphoneContext _context;
        public TruphoneRepository(TruphoneContext context)
        {
            _context = context;
        }
        public List<DeviceDto> GetAllDevices()
        {
            var list = _context.Devices.ToList();



            return new List<DeviceDto>();
        }

        public DeviceDto GetDeviceBy(int id)
        {
            var device = _context.Devices.FirstOrDefault(x => x.DeviceId.Equals(id));
            return new DeviceDto();
        }
    }
}
