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

        public bool AddDevice(DeviceDto device)
        {
            throw new NotImplementedException();
        }
        public DeviceDto GetDeviceById(int id)
        {
            var device = _context.Devices.FirstOrDefault(x => x.DeviceId.Equals(id));
            return new DeviceDto();
        }
        public IEnumerable<DeviceDto> GetAllDevices()
        {
            var list = _context.Devices.ToList();



            return new List<DeviceDto>();
        }
        public bool UpdateDevice(int id, DeviceDto device)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDevice(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DeviceDto> GetDevicesByBrand(string brand)
        {
            throw new NotImplementedException();
        }
    }
}
