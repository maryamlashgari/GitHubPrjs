using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DeviceParameter
    {
        public DeviceParameter()
        {
        }
        public int ID { get; set; }
        public int Device_ID { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string ParameterDesc { get; set; }

        [ForeignKey("Device_ID")]
        public virtual Device Device { get; set; }
    }
}
