using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasetPajooh.Repositories
{
    public class ParameterRepository
    {
        public ParameterRepository(/*AppDbContext context, IDbConnection connection*/)
        {

        }

        public bool InsertParameter(int divice_id, string name, string unit , string parameterDesc)
        {
            DataBaseContext oDbContext = null;
            oDbContext = new DataBaseContext();
            DeviceParameter oParameter = new DeviceParameter();
            oParameter.Device_ID = divice_id;
            oParameter.Name = name;
            oParameter.Unit = unit;
            oParameter.ParameterDesc = parameterDesc;
            oDbContext.deviceParameters.Add(oParameter);
            oDbContext.SaveChanges();
            return true;
        }

        public List<DeviceParameter> SelectAllParameters(int deviceID)
        {
            DataBaseContext oDbContext = null;
            oDbContext = new DataBaseContext();
            DeviceParameter oParameter = new DeviceParameter();
            var Parameters = oDbContext.deviceParameters.Where(E=>E.Device_ID == deviceID).ToList();
            return Parameters;
        }

        public bool UpdateParameter(int id, string name, string unit , string parameterDesc)
        {
            DataBaseContext oDbContext = null;
            oDbContext = new DataBaseContext();
            var row = oDbContext.deviceParameters.FirstOrDefault(E => E.ID == id);
            row.Name = name;
            row.Unit = unit;
            row.ParameterDesc = parameterDesc;
            oDbContext.SaveChanges();
            return true;
        }

        public bool DeleteParameter(int id)
        {
            DataBaseContext oDbContext = null;
            oDbContext = new DataBaseContext();
            var row = oDbContext.deviceParameters.FirstOrDefault(E => E.ID == id);
            oDbContext.deviceParameters.Remove(row);
            oDbContext.SaveChanges();
            return true;
        }
    }
}
