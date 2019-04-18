using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasetPajooh.Repositories
{
    public class DeviceRepository
    {
        public DeviceRepository(/*AppDbContext context, IDbConnection connection*/)
        {

        }

        public bool InsertDevice(string name, int parameterCount)
        {
            DataBaseContext oDbContext = null;
            oDbContext = new DataBaseContext();
            Device oDevice = new Device();
            oDevice.Name = name;
            oDevice.ParameterCount = parameterCount;
            oDbContext.devices.Add(oDevice);
            oDbContext.SaveChanges();
            return true;
        }

        public List<Device> SelectAllDevices()
        {
            DataBaseContext oDbContext = null;
            oDbContext = new DataBaseContext();
            Device oDevice = new Device();
            var Devices = oDbContext.devices.ToList();
            return Devices;
        }

        public bool UpdateDevice(int id, string name, int parameterCount)
        {
            DataBaseContext oDbContext = null;
            oDbContext = new DataBaseContext();
            var row = oDbContext.devices.FirstOrDefault(E => E.ID == id);
            row.Name = name;
            row.ParameterCount = parameterCount;
            oDbContext.SaveChanges();
            return true;
        }

        public bool DeleteDevice(int id)
        {
            DataBaseContext oDbContext = null;
            oDbContext = new DataBaseContext();
            var row = oDbContext.devices.FirstOrDefault(E => E.ID == id);
            oDbContext.devices.Remove(row);
            oDbContext.SaveChanges();
            return true;
        }
    }
}
