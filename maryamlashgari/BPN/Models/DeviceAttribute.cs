using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DeviceAttribute
    {
        public int ID { get; set; }
        public int Device_ID { get; set; }
        public string IP { get; set; }
        public string VID { get; set; }
        public string PID { get; set; }
        public string SerialNum { get; set; }
        public string Address { get; set; }

        [ForeignKey("Device_ID")]
        public virtual Device Device { get; set; }
    }
}
