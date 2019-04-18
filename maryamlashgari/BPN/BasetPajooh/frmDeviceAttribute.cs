using BasetPajooh.Repositories;
using System;
using System.Windows.Forms;

namespace BasetPajooh
{
    public partial class frmDeviceAttribute : BasetPajooh.frmThem
    {
        public int DeviceAttributeID = 0;
        bool formloading = false;
        public frmDeviceAttribute()
        {
            InitializeComponent();
            BindcmbDevice();
        }

        private void frmDeviceAttribute_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bPNDataSet1.Devices' table. You can move, or remove it, as needed.
            formloading = true;
        }

        public void BindcmbDevice()
        {
            DeviceRepository dr = new DeviceRepository();
            var source = dr.SelectAllDevices();
            cmbDevice.DataSource = source;
            cmbDevice.DisplayMember = "Name";
            cmbDevice.SelectedValue = "ID";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (1 == 1)
                {
                    DeviceAttributeRepository dar = new DeviceAttributeRepository();
                    bool response = dar.InsertDeviceAttribute(Convert.ToInt32(cmbDevice.SelectedValue), tbxIP.Text,
                        tbxVID.Text, tbxPID.Text, tbxSerialNum.Text, tbxAddrdss.Text);
                    if (response)
                    {
                        MessageBox.Show("اطلاعات با موفقیت ثبت شد.");
                        DisplayData();
                        ClearData();
                    }
                }
                else
                {
                    MessageBox.Show("خطادر ثبت اطلاعات!");
                }

            }
            catch
            {
                MessageBox.Show("خطادر ثبت اطلاعات!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (1 == 1)
            {
                DeviceAttributeRepository dar = new DeviceAttributeRepository();
                bool response = dar.UpdateDeviceAttribute(DeviceAttributeID, tbxIP.Text,
                    tbxVID.Text, tbxPID.Text, tbxSerialNum.Text, tbxAddrdss.Text);
                if (response)
                {
                    MessageBox.Show("ویرایش با موفقیت انجام شد.");
                    DisplayData();
                    ClearData();
                }
                else
                    MessageBox.Show("خطا در ویرایش اطلاعات!");
            }
            else
            {
                MessageBox.Show("اطلاعات خالی!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeviceAttributeRepository dar = new DeviceAttributeRepository();
            try
            {
                dar.DeleteDeviceAttribute(DeviceAttributeID);
                MessageBox.Show("حذف با موفقیت انجام شد");
                ClearData();
                DisplayData();
            }
            catch
            {
                MessageBox.Show(" خطا در حذف!");
            }
        }
        private void DisplayData()
        {
            DeviceAttributeRepository pr = new DeviceAttributeRepository();
            dataGridViewDeviceAttribute.DataSource = pr.SelectAllDeviceAttributes(Convert.ToInt32(cmbDevice.SelectedValue.ToString()));
        }
        //Clear Data  
        private void ClearData()
        {
            tbxIP.Text = tbxVID.Text = tbxPID.Text = tbxSerialNum.Text = tbxAddrdss.Text = "";
        }
        private void dataGridViewDeviceAttribute_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridViewDeviceAttribute.Rows[rowIndex];
            DeviceAttributeID = Int32.Parse(row.Cells[0].Value.ToString());
            string IP = dataGridViewDeviceAttribute.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbxIP.Text = IP != null ? IP : "";
            string VID = dataGridViewDeviceAttribute.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbxVID.Text = VID != null ? VID : "";
            string PID = dataGridViewDeviceAttribute.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbxPID.Text = PID != null ? PID : "";
            string serialNum = dataGridViewDeviceAttribute.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbxSerialNum.Text = (serialNum != null) ? serialNum : "";
            string Address = dataGridViewDeviceAttribute.Rows[e.RowIndex].Cells[6].Value.ToString();
            tbxAddrdss.Text = (Address != null) ? Address : "";
        }

        private void cmbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formloading)
                DisplayData();
        }
    }
}
