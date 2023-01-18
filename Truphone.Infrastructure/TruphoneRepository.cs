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
        public List<Domain.Device> GetAllDevices()
        {
            var list = _context.Devices.ToList();

            return new List<Domain.Device>();
        }

        public Device GetDeviceBy(int id)
        {
            var device = _context.Devices.FirstOrDefault(x => x.DeviceId.Equals(id));
            return null;
        }
    }
}
