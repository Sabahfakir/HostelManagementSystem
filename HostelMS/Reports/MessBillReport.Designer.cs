namespace HostelMS.Reports
{
    partial class MessBillReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessBillReport));
            this.MessBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MessDataSet = new HostelMS.Reports.MessDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddRoombtn = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.MessBillTableAdapter = new HostelMS.Reports.MessDataSetTableAdapters.MessBillTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MessBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessBillBindingSource
            // 
            this.MessBillBindingSource.DataMember = "MessBill";
            this.MessBillBindingSource.DataSource = this.MessDataSet;
            // 
            // MessDataSet
            // 
            this.MessDataSet.DataSetName = "MessDataSet";
            this.MessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddRoombtn);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(103, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 417);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AddRoombtn
            // 
            this.AddRoombtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRoombtn.Location = new System.Drawing.Point(320, 58);
            this.AddRoombtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddRoombtn.Name = "AddRoombtn";
            this.AddRoombtn.Size = new System.Drawing.Size(112, 34);
            this.AddRoombtn.TabIndex = 29;
            this.AddRoombtn.Text = "Load";
            this.AddRoombtn.UseVisualStyleBackColor = true;
            this.AddRoombtn.Click += new System.EventHandler(this.AddRoombtn_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MessBillBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HostelMS.Reports.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(77, 99);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(618, 305);
            this.reportViewer1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(253, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 33);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mess Bill Report";
            // 
            // MessBillTableAdapter
            // 
            this.MessBillTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(906, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 36);
            this.button6.TabIndex = 21;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MessBillReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 458);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.Name = "MessBillReport";
            this.Text = "MessBillReport";
            this.Load += new System.EventHandler(this.MessBillReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MessBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button AddRoombtn;
        private System.Windows.Forms.BindingSource MessBillBindingSource;
        private MessDataSet MessDataSet;
        private MessDataSetTableAdapters.MessBillTableAdapter MessBillTableAdapter;
        private System.Windows.Forms.Button button6;
    }
}