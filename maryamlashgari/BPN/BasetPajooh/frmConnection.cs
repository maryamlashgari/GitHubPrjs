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
        ETP98UserCtrl ETP98 = null;
        public frmConnection()
        {
            InitializeComponent();
            func();
        }

        void func()
        {
            List<string> ports = new List<string>();
            ports = GetAllPorts();
            //foreach (var item in ports)
            {
                List<byte> addList = new List<byte>() { 0,1 };
                ETP98 = new ETP98UserCtrl(addList, "COM5");
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

        private void timerConnected_Tick(object sender, EventArgs e)
        {
            Boolean check =ETP98.Connected;
            MessageBox.Show(check.ToString());
        }
    }
}
