using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Truphone.Application.Interfaces;
using Truphone.Domain;
using Truphone.Infrastructure.Models;

namespace Truphone.Infrastructure
{
    public class TruphoneRepository : ITruphoneRepository
    {
        private readonly TruphoneContext _context;
        public TruphoneRepository(TruphoneContext context)
        {
            _context = context;
        }

        public bool AddDevice(DeviceDto device)
        {
            try
            {
                var item = new Device { DeviceName = device.Name, Created = DateTime.Now, BrandId = GetBrandIdByName(device.Brand) };
                _context.Devices.Add(item);
                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DeviceDto GetDeviceById(int id)
        {
            var deviceAux = _context.Devices.FirstOrDefault(x => x.DeviceId.Equals(id));

            if (deviceAux is null) return new DeviceDto();

            var device = new DeviceDto() { Id = deviceAux.DeviceId, Name = deviceAux.DeviceName, Brand = GetBrandName(deviceAux), Created = deviceAux.Created };
            return device;
        }

        public IEnumerable<DeviceDto> GetAllDevices()
        {
            var listAux = _context.Devices.Select(d => d).ToList();
            List<DeviceDto> list = AddDeviceToList(listAux);

            return list;
        }

        public bool UpdateDevice(int id, DeviceDto device)
        {
            var res = false;
            if (_context.Devices.Any(x => x.DeviceId == id))
            {
                var modelDb = _context.Devices.First(x => x.DeviceId == id);

                var brandId = GetBrandIdByName(device.Brand);
                modelDb.DeviceName = device.Name;
                modelDb.BrandId = brandId;
                _context.Update(modelDb);
                _context.SaveChanges();

                res = true;
            }
            return res;
        }
        public bool PatchDevice(int id, DeviceDto device)
        {
            throw new NotImplementedException();
            //var res = false;

            //if (_context.Devices.Any(_x => _x.DeviceId == id))
            //{
            //    var modelDb = _context.Devices.First(y => y.DeviceId == id);
            //    res = true;
            //}

            //return res;
        }

        public bool DeleteDevice(int id)
        {
            var res = false;
            if (_context.Devices.Any(x => x.DeviceId == id))
            {
                _context.Devices.Where(x => x.DeviceId == id)
                                            .ExecuteDelete();
                res = true;
            }
            return res;
        }

        public IEnumerable<DeviceDto> GetDevicesByBrand(string brand)
        {
            var brandId = _context.Brands.FirstOrDefault(x => x.BrandName.Equals(brand))?.BrandId;

            if (brandId == null) return Enumerable.Empty<DeviceDto>();

            var listAux = _context.Devices.Where(x => x.BrandId.Equals(brandId)).ToList();
            List<DeviceDto> list = AddDeviceToList(listAux);

            return list;
        }

        private string GetBrandName(Device deviceAux)
        {
            var str = _context.Brands.FirstOrDefault(x => x.BrandId.Equals(deviceAux.BrandId))?.BrandName;
            if (string.IsNullOrEmpty(str)) return string.Empty;

            return str;
        }

        private List<DeviceDto> AddDeviceToList(List<Device> listAux)
        {
            var list = new List<DeviceDto>();

            foreach (var device in listAux)
            {
                var item = new DeviceDto()
                {
                    Id = device.DeviceId,
                    Name = device.DeviceName,
                    Created = device.Created
                };
                item.Brand = GetBrandName(device);

                list.Add(item);
            }

            return list;
        }

        private int GetBrandIdByName(string brandName)
        {
            var id = _context.Brands.First(x => x.BrandName.Equals(brandName)).BrandId;
            return id;
        }

    }
}
