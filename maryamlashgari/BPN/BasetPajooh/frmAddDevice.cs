using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BasetPajooh.Repositories;
using Models;

namespace BasetPajooh
{
    public partial class frmAddDevice : BasetPajooh.frmThem
    {
        public int DeviceID = 0;
        public frmAddDevice()
        {
            InitializeComponent();
            DisplayData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxDevisName.Text != "" && tbxParamCount.Text != "")
                {
                    DeviceRepository dr = new DeviceRepository();
                    bool response = dr.InsertDevice(tbxDevisName.Text, Convert.ToInt32(tbxParamCount.Text));
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

        private void DisplayData()
        {
            DeviceRepository dr = new DeviceRepository();
            dataGridView1.DataSource = dr.SelectAllDevices();
        }
        //Clear Data  
        private void ClearData()
        {
            tbxDevisName.Text = "";
            tbxParamCount.Text = "";
            DeviceID = 0;
        }


        private void frmAddDevice_Load(object sender, EventArgs e)
        {

        }


        //dataGridView1 RowHeaderMouseClick Event  
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            DeviceID = Int32.Parse(row.Cells[0].Value.ToString());
            tbxDevisName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbxParamCount.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbxDevisName.Text != "" && tbxParamCount.Text != "")
            {
                DeviceRepository dr = new DeviceRepository();
                bool responce = dr.UpdateDevice(DeviceID, tbxDevisName.Text, Convert.ToInt32(tbxParamCount.Text));
                if (responce)
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
            DeviceRepository dr = new DeviceRepository();
            try
            {
                dr.DeleteDevice(DeviceID);
                MessageBox.Show("حذف با موفقیت انجام شد");
                ClearData();
                DisplayData();
            }
            catch
            {
                MessageBox.Show(" خطا در حذف!");
            }
        }

        private void btnAddParameter_Click(object sender, EventArgs e)
        {
            frmParameter fp = new frmParameter(DeviceID);
            fp.ShowDialog();
        }
    }
}
