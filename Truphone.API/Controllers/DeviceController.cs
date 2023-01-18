using Microsoft.AspNetCore.Mvc;
using Truphone.Domain;
using Truphone.Application;
using Truphone.Application.Interfaces;

namespace Truphone.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeviceController : ControllerBase
    {
        private readonly ILogger<DeviceController> _logger;
        private readonly ITruphoneService _service;

        public DeviceController(ITruphoneService service, ILogger<DeviceController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        [Route("GetAllDevices")]
        public IEnumerable<Device> GetAllDevices()
        {
            return (IEnumerable<Device>)Ok(_service.GetAllDevices());
        }

        [HttpGet]
        [Route("GetDevice/{id}")]
        public IEnumerable<Device> GetDeviceBy(int id)
        {
            return (IEnumerable<Device>)Ok(_service.GetDeviceby(id));
        }
    }
}