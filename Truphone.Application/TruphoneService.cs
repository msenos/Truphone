using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truphone.Application.Interfaces;
using Truphone.Domain;

namespace Truphone.Application
{
    public class TruphoneService : ITruphoneService
    {
        private readonly ITruphoneRepository _repository;
        public TruphoneService(ITruphoneRepository repository)
        {
            this._repository = repository;
        }

        public bool AddDevice(DeviceDto device)
        {
            throw new NotImplementedException();
        }

        public DeviceDto GetDeviceby(int id)
        {
            return this._repository.GetDeviceById(id);
        }

        public DeviceDto GetDeviceById(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<DeviceDto> ITruphoneService.GetAllDevices()
        {
            var list = this._repository.GetAllDevices();
            return null;
        }
        public bool UpdateDevice(DeviceDto device)
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
