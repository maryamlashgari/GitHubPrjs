using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Timers;
using BasetPajooh.UserControls.Devices;

namespace BasetPajooh
{
    public partial class frmConnection : Form
    {
        public frmConnection()
        {
            InitializeComponent();
            func();
        }

        void func()
        {
            List<string> ports = new List<string>();
            ports = GetAllPorts();
            foreach (var item in ports)
            {
                List<byte> addList = new List<byte>() { 0 };
                ETP98UserCtrl ETP98 = new ETP98UserCtrl(addList, item);
                TempPnl.Controls.Add(ETP98);
            }

        }

        public List<string> GetAllPorts()
        {
            List<String> allPorts = new List<String>();
            foreach (String portName in System.IO.Ports.SerialPort.GetPortNames())
            {
                allPorts.Add(portName);
            }
            return allPorts;
        }

    }
}
