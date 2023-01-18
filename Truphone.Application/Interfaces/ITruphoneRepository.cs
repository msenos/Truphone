using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truphone.Domain;

namespace Truphone.Application.Interfaces
{
    public interface ITruphoneRepository
    {
        List<DeviceDto> GetAllDevices();
        DeviceDto GetDeviceBy(int id);
    }
}
