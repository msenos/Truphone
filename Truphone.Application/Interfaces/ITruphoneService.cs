using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truphone.Application.Interfaces
{
    public interface ITruphoneService
    {
        List<Domain.Device> GetAllDevices();
        Domain.Device GetDeviceby(int id);
    }
}
