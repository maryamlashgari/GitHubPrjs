namespace BasetPajooh
{
    partial class frmConnection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Device_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TempPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.etP98UserCtrl1 = new BasetPajooh.UserControls.Devices.ETP98UserCtrl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TempPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Device_ID,
            this.IP,
            this.VID,
            this.PID,
            this.SerialNum,
            this.Address,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Device_ID
            // 
            this.Device_ID.DataPropertyName = "Device_ID";
            this.Device_ID.HeaderText = "نام دستگاه";
            this.Device_ID.Name = "Device_ID";
            this.Device_ID.ReadOnly = true;
            // 
            // IP
            // 
            this.IP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IP.DataPropertyName = "IP";
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            // 
            // VID
            // 
            this.VID.DataPropertyName = "VID";
            this.VID.HeaderText = "VID";
            this.VID.Name = "VID";
            this.VID.ReadOnly = true;
            // 
            // PID
            // 
            this.PID.DataPropertyName = "PID";
            this.PID.HeaderText = "PID";
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            // 
            // SerialNum
            // 
            this.SerialNum.DataPropertyName = "SerialNum";
            this.SerialNum.HeaderText = "SerialNum";
            this.SerialNum.Name = "SerialNum";
            this.SerialNum.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "وضعیت";
            this.Status.Name = "Status";
            // 
            // TempPnl
            // 
            this.TempPnl.Controls.Add(this.etP98UserCtrl1);
            this.TempPnl.Location = new System.Drawing.Point(0, 212);
            this.TempPnl.Name = "TempPnl";
            this.TempPnl.Size = new System.Drawing.Size(200, 100);
            this.TempPnl.TabIndex = 1;
            // 
            // etP98UserCtrl1
            // 
            this.etP98UserCtrl1.Adds = null;
            this.etP98UserCtrl1.Location = new System.Drawing.Point(3, 3);
            this.etP98UserCtrl1.Name = "etP98UserCtrl1";
            this.etP98UserCtrl1.serialPort1 = null;
            this.etP98UserCtrl1.Size = new System.Drawing.Size(248, 165);
            this.etP98UserCtrl1.t = null;
            this.etP98UserCtrl1.TabIndex = 0;
            // 
            // frmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TempPnl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmConnection";
            this.Text = "frmConnection";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TempPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Device_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn VID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.FlowLayoutPanel TempPnl;
        private UserControls.Devices.ETP98UserCtrl etP98UserCtrl1;
    }
}