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
        public List<Device> GetAllDevices()
        {
            return this._repository.GetAllDevices();
        }

        public Device GetDeviceby(int id)
        {
            return this._repository.GetDeviceBy(id);
        }
    }
}
