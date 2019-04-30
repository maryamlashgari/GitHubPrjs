using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasetPajooh.Repositories
{
    public class DeviceAttributeRepository
    {
        public DeviceAttributeRepository(/*AppDbContext context, IDbConnection connection*/)
        {

        }

        public bool InsertDeviceAttribute(int Device_ID, string IP, string VID, string PID, string SerialNum, byte Address)
        {
            DataBaseContext oDbContext = null;
            oDbContext = new DataBaseContext();
            DeviceAttribute oDeviceAttribute = new DeviceAttribute();
            oDeviceAttribute.Device_ID = Device_ID;
            oDeviceAttribute.IP = IP;
            oDeviceAttribute.VID = VID;
            oDeviceAttribute.PID = PID;
            oDeviceAttribute.SerialNum = SerialNum;
            oDeviceAttribute.Address = Address;
            oDbContext.DeviceAttributes.Add(oDeviceAttribute);
            oDbContext.SaveChanges();
            return true;
        }

        public List<DeviceAttribute> SelectAllDeviceAttributes(int device_ID)
        {
            DataBaseContext oDbContext = null;
            oDbContext = new DataBaseContext();
            DeviceAttribute oDeviceAttribute = new DeviceAttribute();
            var DeviceAttributes = oDbContext.DeviceAttributes.Where(E => E.Device_ID == device_ID).ToList();
            return DeviceAttributes;
        }

        public bool UpdateDeviceAttribute(int id, string IP, string VID, string PID, string SerialNum, byte Address)
        {
            DataBaseContext oDbContext = null;
            oDbContext = new DataBaseContext();
            var row = oDbContext.DeviceAttributes.FirstOrDefault(E => E.ID == id);
            row.IP = IP;
            row.VID = VID;
            row.PID = PID;
            row.SerialNum = SerialNum;
            row.Address = Address;

            oDbContext.SaveChanges();
            return true;
        }

        public bool DeleteDeviceAttribute(int id)
        {
            DataBaseContext oDbContext = null;
            oDbContext = new DataBaseContext();
            var row = oDbContext.DeviceAttributes.FirstOrDefault(E => E.ID == id);
            oDbContext.DeviceAttributes.Remove(row);
            oDbContext.SaveChanges();
            return true;
        }
    }
}
