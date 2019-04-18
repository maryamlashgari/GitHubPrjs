namespace BasetPajooh
{
    partial class frmDeviceAttribute
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
            this.components = new System.ComponentModel.Container();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.devicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.tbxVID = new System.Windows.Forms.TextBox();
            this.tbxPID = new System.Windows.Forms.TextBox();
            this.tbxSerialNum = new System.Windows.Forms.TextBox();
            this.tbxAddrdss = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewDeviceAttribute = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeviceAttribute)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDevice
            // 
            this.cmbDevice.DisplayMember = "ID";
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(601, 33);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(199, 21);
            this.cmbDevice.TabIndex = 3;
            this.cmbDevice.ValueMember = "ID";
            this.cmbDevice.SelectedIndexChanged += new System.EventHandler(this.cmbDevice_SelectedIndexChanged);
            // 
            // devicesBindingSource
            // 
            this.devicesBindingSource.DataMember = "Devices";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(815, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "دستگاه";
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(601, 69);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(199, 21);
            this.tbxIP.TabIndex = 5;
            // 
            // tbxVID
            // 
            this.tbxVID.Location = new System.Drawing.Point(601, 105);
            this.tbxVID.Name = "tbxVID";
            this.tbxVID.Size = new System.Drawing.Size(199, 21);
            this.tbxVID.TabIndex = 6;
            // 
            // tbxPID
            // 
            this.tbxPID.Location = new System.Drawing.Point(601, 143);
            this.tbxPID.Name = "tbxPID";
            this.tbxPID.Size = new System.Drawing.Size(199, 21);
            this.tbxPID.TabIndex = 7;
            // 
            // tbxSerialNum
            // 
            this.tbxSerialNum.Location = new System.Drawing.Point(601, 179);
            this.tbxSerialNum.Name = "tbxSerialNum";
            this.tbxSerialNum.Size = new System.Drawing.Size(199, 21);
            this.tbxSerialNum.TabIndex = 8;
            // 
            // tbxAddrdss
            // 
            this.tbxAddrdss.Location = new System.Drawing.Point(601, 217);
            this.tbxAddrdss.Name = "tbxAddrdss";
            this.tbxAddrdss.Size = new System.Drawing.Size(199, 21);
            this.tbxAddrdss.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(815, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(815, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "VID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(815, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "PID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(815, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "SerialNum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(815, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Address";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(763, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "اضافه";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(682, 258);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(601, 258);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridViewDeviceAttribute
            // 
            this.dataGridViewDeviceAttribute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeviceAttribute.Location = new System.Drawing.Point(44, 33);
            this.dataGridViewDeviceAttribute.Name = "dataGridViewDeviceAttribute";
            this.dataGridViewDeviceAttribute.Size = new System.Drawing.Size(500, 248);
            this.dataGridViewDeviceAttribute.TabIndex = 20;
            this.dataGridViewDeviceAttribute.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDeviceAttribute_RowHeaderMouseClick);
            // 
            // frmDeviceAttribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(905, 345);
            this.Controls.Add(this.dataGridViewDeviceAttribute);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxAddrdss);
            this.Controls.Add(this.tbxSerialNum);
            this.Controls.Add(this.tbxPID);
            this.Controls.Add(this.tbxVID);
            this.Controls.Add(this.tbxIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDevice);
            this.Name = "frmDeviceAttribute";
            this.Text = "ویژگی های دستگاه";
            this.Load += new System.EventHandler(this.frmDeviceAttribute_Load);
            this.Controls.SetChildIndex(this.cmbDevice, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbxIP, 0);
            this.Controls.SetChildIndex(this.tbxVID, 0);
            this.Controls.SetChildIndex(this.tbxPID, 0);
            this.Controls.SetChildIndex(this.tbxSerialNum, 0);
            this.Controls.SetChildIndex(this.tbxAddrdss, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.dataGridViewDeviceAttribute, 0);
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeviceAttribute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.TextBox tbxVID;
        private System.Windows.Forms.TextBox tbxPID;
        private System.Windows.Forms.TextBox tbxSerialNum;
        private System.Windows.Forms.TextBox tbxAddrdss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource devicesBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewDeviceAttribute;
    }
}
