using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Device
    {
        public Device()
        {
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public int ParameterCount { get; set; }
        public virtual ICollection<DeviceParameter> DeviceParameters { get; set; }
    }
}
