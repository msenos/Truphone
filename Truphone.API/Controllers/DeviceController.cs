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
        [Route("AddDevice/{name}/{brand}")]
        public ActionResult<bool> AddDevice(string name, string brand)
        {
            return Ok(_service.AddDevice(new DeviceDto(name, brand)));
        } 

        [HttpGet]
        [Route("GetDeviceById/{id}")]
        public ActionResult<IEnumerable<DeviceDto>> GetDeviceById(int id)
        {
            return Ok(_service.GetDeviceById(id));
        }

        [HttpGet]
        [Route("GetAllDevices")]
        public ActionResult<IEnumerable<DeviceDto>> GetAllDevices()
        {
            return Ok(_service.GetAllDevices());
        }

        [HttpPost]
        [Route("UpdateDevice/{id}")]
        public ActionResult<bool> UpdateDevice(int id, DeviceDto device) 
        {
            return Ok(_service.UpdateDevice(id, device));
        
        }

        [HttpPatch]
        [Route("PatchDevice/{id}")]
        public ActionResult<bool> PatchDevice(int id, DeviceDto device)
        {
            return Ok(_service.PatchDevice(id, device));

        }

        [HttpDelete]
        [Route("DeleteDevice/{id}")]
        public ActionResult<bool> DeleteDevice(int id)
        {
            return Ok(_service.DeleteDevice(id));
        }

        [HttpGet]
        [Route("SearchDeviceByBrand/{name}")]
        public ActionResult<IEnumerable<DeviceDto>> SearchDeviceByName(string name)
        {
            return Ok(_service.GetDevicesByBrand(name));
        }
    }
}