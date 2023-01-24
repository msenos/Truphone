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
            _repository = repository;
        }

        public bool AddDevice(DeviceDto device)
        {
            return _repository.AddDevice(device);
        }

        public DeviceDto GetDeviceById(int id)
        {
            return _repository.GetDeviceById(id);
        }

        public IEnumerable<DeviceDto> GetAllDevices()
        {
            return _repository.GetAllDevices();
        }
        public bool UpdateDevice(int id, DeviceDto device)
        {
            return _repository.UpdateDevice(id, device);
        }
        public bool PatchDevice(int id, DeviceDto device)
        {
            return _repository.PatchDevice(id, device);
        }

        public bool DeleteDevice(int id)
        {
            return _repository.DeleteDevice(id);
        }

        public IEnumerable<DeviceDto> GetDevicesByBrand(string brand)
        {
            return _repository.GetDevicesByBrand(brand);
        }

    }
}
