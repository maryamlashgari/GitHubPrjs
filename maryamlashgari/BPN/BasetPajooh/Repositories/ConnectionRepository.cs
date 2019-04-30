using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasetPajooh.Repositories
{
    public class ConnectionRepository
    {
        public ConnectionRepository(/*AppDbContext context, IDbConnection connection*/)
        {
        }

        public List<DeviceAttribute> SelectAllDevices()
        {
            DataBaseContext oDbContext = null;
            oDbContext = new DataBaseContext();
            DeviceAttribute oDAttribute = new DeviceAttribute();
            var DeviceAttributes = oDbContext.DeviceAttributes.ToList();
            return DeviceAttributes;
            //.Select(p => new { p.ID,p.IP,p.VID,p.PID,p.SerialNum,p.Address })
        }
        public Dictionary<string, int> GetComportCategory()
        {
            DataBaseContext oDbContext = null;
            oDbContext = new DataBaseContext();
            DeviceAttribute oDAttribute = new DeviceAttribute();
            var DeviceAttributes = oDbContext.DeviceAttributes
                                             .GroupBy(p => p.Comport)
                                             .Select(E => new { comport = E.Key, count = E.Count() }).OrderBy(F=>F.comport)
                                             .ToDictionary(k => k.comport, i => i.count); ;
            return DeviceAttributes;
        }
    }
}
