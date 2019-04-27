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
using BasetPajooh.Repositories;

namespace BasetPajooh
{
    public partial class frmConnection : Form
    {
        ETP98UserCtrl ETP98 = null;
        int Counter = 0;
        public frmConnection()
        {
            InitializeComponent();
            DataGridViewDataBind();
            func();
        }
        void DataGridViewDataBind()
        {
            ConnectionRepository Cr = new ConnectionRepository();
            dataGridView1.DataSource = Cr.SelectAllDevices();
            this.dataGridView1.Columns["ID"].Visible = false;
            this.dataGridView1.Columns["Device"].Visible = false;
        }

        void func()
        {
            List<string> ports = new List<string>();
            ports = GetAllPorts();
            //foreach (var item in ports)
            {
                List<byte> addList = new List<byte>() { 0, 1 };
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
            Boolean check = ETP98.Connected;
            dataGridView1_DataBindingComplete(null, null);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (Counter >= 2)
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[1];
                    chk.Value = (ETP98.Connected == true ? 1 : 0);
                }
            Counter++;
        }
    }
}
