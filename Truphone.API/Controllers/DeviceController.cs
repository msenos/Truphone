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

        [HttpPost]
        [Route("AddDevice")]
        public ActionResult<bool> AddDevice(DeviceDto device)
        {
            return Ok(_service.AddDevice(device));
        } 

        [HttpGet]
        [Route("GetDevice/{id}")]
        public IEnumerable<DeviceDto> GetDeviceById(int id)
        {
            return (IEnumerable<DeviceDto>)Ok(_service.GetDeviceById(id));
        }

        [HttpGet]
        [Route("GetAllDevices")]
        public IEnumerable<DeviceDto> GetAllDevices()
        {
            return (IEnumerable<DeviceDto>)Ok(_service.GetAllDevices());
        }

        [HttpPost]
        [Route("UpdateDevice/{id}")]
        public ActionResult<bool> UpdateDevice(int id, DeviceDto device) 
        {
            return Ok(_service.UpdateDevice(id, device));
        
        }

        [HttpPatch]
        [Route("UpdateDevicePartial/{id}")]
        public ActionResult<bool> UpdateDevicePartial(int id, DeviceDto device)
        {
            return Ok(_service.UpdateDevice(id, device));

        }

    }
}