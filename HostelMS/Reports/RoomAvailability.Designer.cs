namespace HostelMS.Reports
{
    partial class RoomAvailability
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomAvailability));
            this.room1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomDataSet = new HostelMS.Reports.RoomDataSet();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.room1TableAdapter = new HostelMS.Reports.RoomDataSetTableAdapters.Room1TableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.roomTableAdapter = new HostelMS.Reports.RoomDataSetTableAdapters.RoomTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddRoombtn = new System.Windows.Forms.Button();
            this.AdminDataSet = new HostelMS.Reports.AdminDataSet();
            this.AdmissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AdmissionTableAdapter = new HostelMS.Reports.AdminDataSetTableAdapters.AdmissionTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.room1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdmissionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // room1BindingSource
            // 
            this.room1BindingSource.DataMember = "Room1";
            this.room1BindingSource.DataSource = this.roomDataSet;
            // 
            // roomDataSet
            // 
            this.roomDataSet.DataSetName = "RoomDataSet";
            this.roomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.roomDataSet;
            // 
            // room1TableAdapter
            // 
            this.room1TableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.room1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HostelMS.Reports.RoomReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(155, 126);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(438, 224);
            this.reportViewer1.TabIndex = 23;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AddRoombtn);
            this.panel1.Location = new System.Drawing.Point(109, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 375);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(204, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 33);
            this.label2.TabIndex = 26;
            this.label2.Text = "Room Availability Report";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.roomBindingSource;
            this.comboBox1.DisplayMember = "Alloted";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(326, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.ValueMember = "Alloted";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(157, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Room Alloted";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AddRoombtn
            // 
            this.AddRoombtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRoombtn.Location = new System.Drawing.Point(467, 78);
            this.AddRoombtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddRoombtn.Name = "AddRoombtn";
            this.AddRoombtn.Size = new System.Drawing.Size(112, 34);
            this.AddRoombtn.TabIndex = 23;
            this.AddRoombtn.Text = "Preview";
            this.AddRoombtn.UseVisualStyleBackColor = true;
            this.AddRoombtn.Click += new System.EventHandler(this.AddRoombtn_Click_1);
            // 
            // AdminDataSet
            // 
            this.AdminDataSet.DataSetName = "AdminDataSet";
            this.AdminDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AdmissionBindingSource
            // 
            this.AdmissionBindingSource.DataMember = "Admission";
            this.AdmissionBindingSource.DataSource = this.AdminDataSet;
            // 
            // AdmissionTableAdapter
            // 
            this.AdmissionTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(906, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 36);
            this.button6.TabIndex = 25;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // RoomAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 458);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.Name = "RoomAvailability";
            this.Text = "RoomAvailability";
            this.Load += new System.EventHandler(this.RoomAvailability_Load);
            ((System.ComponentModel.ISupportInitialize)(this.room1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdmissionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource room1BindingSource;
        private RoomDataSet roomDataSet;
        private RoomDataSetTableAdapters.Room1TableAdapter room1TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private RoomDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddRoombtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource AdmissionBindingSource;
        private AdminDataSet AdminDataSet;
        private AdminDataSetTableAdapters.AdmissionTableAdapter AdmissionTableAdapter;
        private System.Windows.Forms.Button button6;
    }
}