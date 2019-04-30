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
            LoadUserControls();
        }
        void DataGridViewDataBind()
        {
            dataGridView1.DataSource = GetData();
            this.dataGridView1.Columns["ID"].Visible = false;
            this.dataGridView1.Columns["Device"].Visible = false;
        }

        List<Models.DeviceAttribute> GetData()
        {
            ConnectionRepository Cr = new ConnectionRepository();
            return Cr.SelectAllDevices();
        }

        void LoadUserControls()
        {
            List<Models.DeviceAttribute> Devices = new List<Models.DeviceAttribute>();
            Devices = GetData();
            ConnectionRepository Cr = new ConnectionRepository();
            Dictionary<string, int> dec = Cr.GetComportCategory();
            foreach (var item in dec)
            {
                List<byte> addList = new List<byte>();
                int j = 0;
                foreach (var device in Devices.Select((value, i) => new { i, value }))
                {
                    if (device.value.Comport == item.Key)
                    {
                        addList.Add(device.value.Address);
                        if (j == item.Value - 1)
                        {
                            ETP98 = new ETP98UserCtrl(addList, device.value.Comport);
                            TempPnl.Controls.Add(ETP98);
                        }
                        j++;
                    }
                }
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
            dataGridView1_DataBindingComplete(null, null);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (Counter >= 2)
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    byte add = Convert.ToByte(row.Cells["address"].Value);
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[1];
                    chk.Value = (ETP98.Connected[add] == true ? 1 : 0);
                }
            Counter++;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // =
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            ETP98.DisplayedAdd = Convert.ToByte(row.Cells[10].Value);
            ETP98.DisplayedComport = row.Cells[4].Value.ToString();
        }
    }
}
