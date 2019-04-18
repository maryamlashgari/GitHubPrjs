using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasetPajooh.Repositories;
using Models;

namespace BasetPajooh
{
    public partial class frmParameter : BasetPajooh.frmThem
    {
        public int DeviceID = 0;
        public int ParameterID = 0;
        public frmParameter(int id)
        {
            DeviceID = id;
            InitializeComponent();
            DisplayData();
        }
        public frmParameter()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxName.Text != "" && tbxUnit.Text != "")
                {
                    ParameterRepository pr = new ParameterRepository();
                    bool response = pr.InsertParameter(DeviceID, tbxName.Text, tbxUnit.Text, tbxParameterDesc.Text);
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
            if (tbxName.Text != "" && tbxUnit.Text != "")
            {
                ParameterRepository pr = new ParameterRepository();
                bool response = pr.UpdateParameter(ParameterID, tbxName.Text, tbxUnit.Text,tbxParameterDesc.Text);
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
            ParameterRepository dr = new ParameterRepository();
            try
            {
                dr.DeleteParameter(ParameterID);
                MessageBox.Show("حذف با موفقیت انجام شد");
                ClearData();
                DisplayData();
            }
            catch
            {
                MessageBox.Show(" خطا در حذف!");
            }
        }

        private void dataGridViewParameter_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int d = DeviceID;
            DataGridViewRow row = dataGridViewParameter.Rows[rowIndex];
            ParameterID = Int32.Parse(row.Cells[0].Value.ToString());
            tbxName.Text = dataGridViewParameter.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbxUnit.Text = dataGridViewParameter.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbxParameterDesc.Text = dataGridViewParameter.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void DisplayData()
        {
            ParameterRepository pr = new ParameterRepository();
            dataGridViewParameter.DataSource = pr.SelectAllParameters(DeviceID);
        }
        //Clear Data  
        private void ClearData()
        {
            tbxName.Text = 
            tbxUnit.Text =
            tbxParameterDesc.Text = "" ;
            ParameterID = 0;
        }
    }
}
