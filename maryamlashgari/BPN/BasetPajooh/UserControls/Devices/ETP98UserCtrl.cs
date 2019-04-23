using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Timers;
using System.IO.Ports;
using System.ComponentModel.Design;

namespace BasetPajooh.UserControls.Devices
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class ETP98UserCtrl : UserControl
    {
        public List<byte> Adds { get; set; }
        public Thread t { get; set; }
        public SerialPort serialPort1 { get; set; }
        public Boolean Connected { get; set; }
        delegate void SetTemperatureCallback(string text);
        public ETP98UserCtrl()
        {
            InitializeComponent();
        }

        public ETP98UserCtrl(List<byte> adds, string serialPortName)
        {
            InitializeComponent();
            Adds = adds;
            serialPort1 = new SerialPort(serialPortName);
            serialPort1.BaudRate = 19200;
            serialPort1.Open();
            t = new Thread(GetDataContinuous);
            t.Start();
        }

        private void SetText(string text)
        {
            string[] temps = text.Split('*');
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            int i = 1;
            foreach (var item in temps)
            {
                if (i == 1)
                    if (this.tbxT1.InvokeRequired)
                    {
                        SetTemperatureCallback d = new SetTemperatureCallback(SetText);
                        this.Invoke(d, new object[] { text });
                        i++;
                    }
                    else
                    {
                        this.tbxT1.Text = item;
                        i++;
                    }
                else if (i == 2)
                    if (this.tbxT2.InvokeRequired)
                    {
                        SetTemperatureCallback d = new SetTemperatureCallback(SetText);
                        this.Invoke(d, new object[] { text });
                        i++;
                    }
                    else
                    {
                        this.tbxT2.Text = item;
                        i++;
                    }
                else if (i == 3)
                    if (this.tbxT3.InvokeRequired)
                    {
                        SetTemperatureCallback d = new SetTemperatureCallback(SetText);
                        this.Invoke(d, new object[] { text });
                        i++;
                    }
                    else
                    {
                        this.tbxT3.Text = item;
                        i++;
                    }
                else if (i == 4)
                    if (this.tbxT4.InvokeRequired)
                    {
                        SetTemperatureCallback d = new SetTemperatureCallback(SetText);
                        this.Invoke(d, new object[] { text });
                        i++;
                    }
                    else
                    {
                        this.tbxT4.Text = item;
                        i++;
                    }
                else if (i == 5)
                    if (this.tbxT5.InvokeRequired)
                    {
                        SetTemperatureCallback d = new SetTemperatureCallback(SetText);
                        this.Invoke(d, new object[] { text });
                        i++;
                    }
                    else
                    {
                        this.tbxT5.Text = item;
                        i++;
                    }
                else if (i == 6)
                    if (this.tbxT6.InvokeRequired)
                    {
                        SetTemperatureCallback d = new SetTemperatureCallback(SetText);
                        this.Invoke(d, new object[] { text });
                        i++;
                    }
                    else
                    {
                        this.tbxT6.Text = item;
                        i++;
                    }
                else if (i == 7)
                    if (this.tbxT7.InvokeRequired)
                    {
                        SetTemperatureCallback d = new SetTemperatureCallback(SetText);
                        this.Invoke(d, new object[] { text });
                        i++;
                    }
                    else
                    {
                        this.tbxT7.Text = item;
                        i++;
                    }
                else if (i == 8)
                    if (this.tbxT8.InvokeRequired)
                    {
                        SetTemperatureCallback d = new SetTemperatureCallback(SetText);
                        this.Invoke(d, new object[] { text });
                        i++;
                    }
                    else
                    {
                        this.tbxT8.Text = item;
                        i++;
                    }
                else if (i == 9)
                    if (this.tbxT9.InvokeRequired)
                    {
                        SetTemperatureCallback d = new SetTemperatureCallback(SetText);
                        this.Invoke(d, new object[] { text });
                        i++;
                    }
                    else
                    {
                        this.tbxT9.Text = item;
                        i++;
                    }
                else if (i == 10)
                    if (this.tbxT10.InvokeRequired)
                    {
                        SetTemperatureCallback d = new SetTemperatureCallback(SetText);
                        this.Invoke(d, new object[] { text });
                        i++;
                    }
                    else
                    {
                        this.tbxT10.Text = item;
                        i++;
                    }
                else if (i == 11)
                    if (this.tbxT11.InvokeRequired)
                    {
                        SetTemperatureCallback d = new SetTemperatureCallback(SetText);
                        this.Invoke(d, new object[] { text });
                        i++;
                    }
                    else
                    {
                        this.tbxT11.Text = item;
                        i++;
                    }
                else if (i == 12)
                    if (this.tbxT12.InvokeRequired)
                    {
                        SetTemperatureCallback d = new SetTemperatureCallback(SetText);
                        this.Invoke(d, new object[] { text });
                        i++;
                    }
                    else
                    {
                        this.tbxT12.Text = item;
                        i++;
                    }
                else if (i == 13)
                    if (this.tbxT13.InvokeRequired)
                    {
                        SetTemperatureCallback d = new SetTemperatureCallback(SetText);
                        this.Invoke(d, new object[] { text });
                        i++;
                    }
                    else
                    {
                        this.tbxT13.Text = item;
                        i++;
                    }
                else if (i == 14)
                    if (this.tbxT14.InvokeRequired)
                    {
                        SetTemperatureCallback d = new SetTemperatureCallback(SetText);
                        this.Invoke(d, new object[] { text });
                        i++;
                    }
                    else
                    {
                        this.tbxT14.Text = item;
                        i++;
                    }
                else if (i == 15)
                    if (this.tbxT15.InvokeRequired)
                    {
                        SetTemperatureCallback d = new SetTemperatureCallback(SetText);
                        this.Invoke(d, new object[] { text });
                        i++;
                    }
                    else
                    {
                        this.tbxT15.Text = item;
                        i++;
                    }
                else if (i == 16)
                    if (this.tbxT16.InvokeRequired)
                    {
                        SetTemperatureCallback d = new SetTemperatureCallback(SetText);
                        this.Invoke(d, new object[] { text });
                        i++;
                    }
                    else
                    {
                        this.tbxT16.Text = item;
                        i++;
                    }
            }
        }

        private void GetDataContinuous()
        {
            var timer = new System.Timers.Timer() { Interval = 300 };
            timer.Enabled = true;
            timer.Start();
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            getData();
        }

        private void getData()
        {
            foreach (byte add in Adds)
            {
                Request(add);
                Thread.Sleep(60);
                Read(add);
            }
        }

        private void Request(byte address)
        {
            byte[] buf = { 0x00, 0xaa, 0xff };
            buf[0] = address;
            buf[2] = (byte)(~buf[0]);

            if (serialPort1.IsOpen)
            {
                //clear transmit and receive buffer
                serialPort1.DiscardOutBuffer();
                serialPort1.DiscardInBuffer();
                //set mark parity which means the transmitting byte is an address byte 
                //in nine bit serial communication
                serialPort1.Parity = System.IO.Ports.Parity.Mark;
                //set DE/RE pin high in 75176 chip which is transmit mode.
                serialPort1.RtsEnable = false;
                //send address byte
                serialPort1.Write(buf, 0, 1);
                while (serialPort1.BytesToWrite != 0) ;
                udelay(700);

                //set space parity which means the transmitting byte is a data byte 
                //in nine bit serial communication
                serialPort1.Parity = System.IO.Ports.Parity.Space;
                //send second && Third byte
                serialPort1.Write(buf, 1, 1);
                while (serialPort1.BytesToWrite != 0) ;
                udelay(700);

                //send Third byte
                serialPort1.Write(buf, 2, 1);
                while (serialPort1.BytesToWrite != 0) ;
                udelay(700);

                //set DE/RE pin low in 75176 chip which is receive mode.
                serialPort1.RtsEnable = true;

            }
        }
        private void Read(byte address)
        {
            bool ok = false;

            if (serialPort1.IsOpen)
            {
                string textBox1 = serialPort1.BytesToRead.ToString();
                string RecievedBytes = "";
                string RecievedTemps = "";
                if (serialPort1.BytesToRead >= 37)
                {
                    while (serialPort1.BytesToRead >= 36)
                    {
                        int b = serialPort1.ReadByte();
                        RecievedBytes += b.ToString("X") + " ";
                        if (b == 0x55)
                            if (serialPort1.ReadByte() == 0xaa)
                            {
                                RecievedBytes += "aa ";
                                break;
                            }
                    }
                    if (serialPort1.BytesToRead == 34)
                    {
                        byte[] buf = new byte[34];
                        serialPort1.Read(buf, 0, 34);


                        UInt16 cs = buf[33];
                        UInt16 CS = 0;
                        cs <<= 8;
                        cs |= buf[32];
                        for (int i = 0; i < 16; i++)
                        {
                            UInt16 w = buf[i * 2 + 1];
                            w <<= 8;
                            w |= buf[i * 2];
                            CS += w;
                        }
                        if (CS == cs) ok = true;

                        for (int i = 0; i < 34; i++)
                        {
                            if (i % 8 == 0) RecievedBytes += "\r\n";
                            RecievedBytes += buf[i].ToString("X") + " ";
                        }
                        int CorrectCount = 0;
                        if (ok)
                        {
                            CorrectCount++;
                            long x1 = 0;
                            for (int j = 0; j < 16; j++)
                            {
                                x1 = buf[1 + j * 2];
                                x1 <<= 8;
                                x1 |= buf[j * 2];
                                double x = x1;
                                x /= 60.0;
                                x *= 5.0 / 1024;
                                x /= 0.05;
                                x -= 40;

                                RecievedTemps += x.ToString() + "*";
                            }
                            SetText(RecievedTemps);
                        }

                    }
                }
                int FaultCount = 0;
                if (!ok)
                {
                    FaultCount++;
                }
            }
            Connected = ok;
        }
        private void udelay(int u)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            // Do something you want to time
            long microseconds = 0;
            while (microseconds < u)
                microseconds = sw.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
            sw.Stop();
        }
    }
}
