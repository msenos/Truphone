using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truphone.Domain;

namespace Truphone.Application.Interfaces
{
    public interface ITruphoneService
    {
        bool AddDevice(DeviceDto device);
        DeviceDto GetDeviceById(int id);
        IEnumerable<DeviceDto> GetAllDevices();
        bool UpdateDevice(int id, DeviceDto device);
        bool DeleteDevice(int id);
        IEnumerable<DeviceDto> GetDevicesByBrand(string brand);
    }
}
