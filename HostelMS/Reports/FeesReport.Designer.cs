namespace HostelMS.Reports
{
    partial class FeesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeesReport));
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feeDataSet = new HostelMS.Reports.FeeDataSet();
            this.hostelFeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddRoombtn = new System.Windows.Forms.Button();
            this.hostelFeesTableAdapter = new HostelMS.Reports.FeeDataSetTableAdapters.HostelFeesTableAdapter();
            this.DataTable1TableAdapter = new HostelMS.Reports.FeeDataSetTableAdapters.DataTable1TableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelFeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.feeDataSet;
            // 
            // feeDataSet
            // 
            this.feeDataSet.DataSetName = "FeeDataSet";
            this.feeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hostelFeesBindingSource
            // 
            this.hostelFeesBindingSource.DataMember = "HostelFees";
            this.hostelFeesBindingSource.DataSource = this.feeDataSetBindingSource;
            // 
            // feeDataSetBindingSource
            // 
            this.feeDataSetBindingSource.DataSource = this.feeDataSet;
            this.feeDataSetBindingSource.Position = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AddRoombtn);
            this.panel1.Location = new System.Drawing.Point(103, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 417);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HostelMS.Reports.FeeReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 127);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(730, 277);
            this.reportViewer1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(303, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 33);
            this.label2.TabIndex = 30;
            this.label2.Text = "Fee Report";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.hostelFeesBindingSource;
            this.comboBox1.DisplayMember = "Due";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(309, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.ValueMember = "Due";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(245, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Due";
            // 
            // AddRoombtn
            // 
            this.AddRoombtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRoombtn.Location = new System.Drawing.Point(451, 64);
            this.AddRoombtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddRoombtn.Name = "AddRoombtn";
            this.AddRoombtn.Size = new System.Drawing.Size(112, 34);
            this.AddRoombtn.TabIndex = 27;
            this.AddRoombtn.Text = "Preview";
            this.AddRoombtn.UseVisualStyleBackColor = true;
            this.AddRoombtn.Click += new System.EventHandler(this.AddRoombtn_Click);
            // 
            // hostelFeesTableAdapter
            // 
            this.hostelFeesTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(895, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 36);
            this.button6.TabIndex = 22;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FeesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 458);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FeesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeesReport";
            this.Load += new System.EventHandler(this.FeesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelFeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddRoombtn;
        private System.Windows.Forms.BindingSource feeDataSetBindingSource;
        private FeeDataSet feeDataSet;
        private System.Windows.Forms.BindingSource hostelFeesBindingSource;
        private FeeDataSetTableAdapters.HostelFeesTableAdapter hostelFeesTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private FeeDataSetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.Button button6;
    }
}