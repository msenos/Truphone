using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truphone.Application.Interfaces
{
    public interface ITruphoneRepository
    {
        List<Domain.Device> GetAllDevices();
    }
}
