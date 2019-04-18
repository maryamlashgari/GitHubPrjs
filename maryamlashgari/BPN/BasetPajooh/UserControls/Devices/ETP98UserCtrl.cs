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
        public ETP98UserCtrl()
        {
            InitializeComponent();
        }

        public List<byte> Adds { get; set; }
        public Thread t { get; set; }
        public SerialPort serialPort1 { get; set; }
        public ETP98UserCtrl(List<byte> adds, string serialPortName)
        {
            Adds = adds;
            serialPort1 = new SerialPort(serialPortName);
            serialPort1.BaudRate = 19200;
            serialPort1.Open();
            t = new Thread(GetDataContinuous);
            t.Start();
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
                Read();
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
        private void Read()
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
                            //ClearTextBoxes();

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

                                RecievedTemps += "T" + (j + 1).ToString() + "= " + x.ToString() + "\r\n";
                                tbxT1.Text = "76";
                                /*
                                comm.rtemp[st][j] = 15600.- 120.* float(x);
                                float ttt = comm.calib.t(st, j, comm.rtemp[st][j]);
                                if (ttt < -50) ttt = -50;
                                if (ttt > 150) ttt = 150;
                                comm.tem[st][j] = ttt;
                                */
                            }
                            //////////////////////////////////
                            string Ts = RecievedTemps;
                            //////////////////////////////////
                        }

                    }
                }
                int FaultCount = 0;
                if (!ok)
                {
                    FaultCount++;
                }
            }
            MessageBox.Show(ok.ToString());
            bool Checked = ok;
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

        private void ClearTextBoxes()
        {
            tbxT1.Text = "";
        }
    }
}
