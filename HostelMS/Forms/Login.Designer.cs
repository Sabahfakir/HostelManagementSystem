namespace HostelMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.forgotpass = new System.Windows.Forms.Label();
            this.passtxtbox2 = new System.Windows.Forms.TextBox();
            this.usertxtbox1 = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.loginlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = " HOSTEL MANAGEMENT SYSTEM";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(211, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(0, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(158, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Log in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.forgotpass);
            this.panel1.Controls.Add(this.passtxtbox2);
            this.panel1.Controls.Add(this.usertxtbox1);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.loginlabel);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(331, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 246);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // forgotpass
            // 
            this.forgotpass.AutoSize = true;
            this.forgotpass.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.forgotpass.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotpass.ForeColor = System.Drawing.Color.Ivory;
            this.forgotpass.Location = new System.Drawing.Point(59, 188);
            this.forgotpass.Name = "forgotpass";
            this.forgotpass.Size = new System.Drawing.Size(0, 23);
            this.forgotpass.TabIndex = 5;
            // 
            // passtxtbox2
            // 
            this.passtxtbox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.passtxtbox2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxtbox2.Location = new System.Drawing.Point(211, 129);
            this.passtxtbox2.Name = "passtxtbox2";
            this.passtxtbox2.PasswordChar = '*';
            this.passtxtbox2.Size = new System.Drawing.Size(159, 32);
            this.passtxtbox2.TabIndex = 4;
            // 
            // usertxtbox1
            // 
            this.usertxtbox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.usertxtbox1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxtbox1.Location = new System.Drawing.Point(211, 82);
            this.usertxtbox1.Name = "usertxtbox1";
            this.usertxtbox1.Size = new System.Drawing.Size(159, 32);
            this.usertxtbox1.TabIndex = 3;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.Ivory;
            this.pass.Location = new System.Drawing.Point(59, 138);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(103, 23);
            this.pass.TabIndex = 2;
            this.pass.Text = "Password";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Ivory;
            this.username.Location = new System.Drawing.Point(59, 82);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(108, 23);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.loginlabel.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlabel.ForeColor = System.Drawing.Color.Ivory;
            this.loginlabel.Location = new System.Drawing.Point(162, 25);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(110, 33);
            this.loginlabel.TabIndex = 0;
            this.loginlabel.Text = "LOGIN";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label forgotpass;
        private System.Windows.Forms.TextBox passtxtbox2;
        private System.Windows.Forms.TextBox usertxtbox1;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label loginlabel;
    }
}

