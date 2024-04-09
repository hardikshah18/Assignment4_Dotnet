namespace Assignment4_C_
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnclear = new Button();
            btnlogin = new Button();
            lblpass = new Label();
            lbluser = new Label();
            txtpass = new TextBox();
            txtusername = new TextBox();
            SuspendLayout();
            // 
            // btnclear
            // 
            btnclear.Location = new Point(439, 284);
            btnclear.Margin = new Padding(2);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(90, 27);
            btnclear.TabIndex = 11;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(315, 284);
            btnlogin.Margin = new Padding(2);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(90, 27);
            btnlogin.TabIndex = 10;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.Location = new Point(281, 204);
            lblpass.Margin = new Padding(2, 0, 2, 0);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(70, 20);
            lblpass.TabIndex = 9;
            lblpass.Text = "Password";
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Location = new Point(281, 142);
            lbluser.Margin = new Padding(2, 0, 2, 0);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(46, 20);
            lbluser.TabIndex = 8;
            lbluser.Text = "Email";
            // 
            // txtpass
            // 
            txtpass.Location = new Point(355, 199);
            txtpass.Margin = new Padding(2);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(150, 27);
            txtpass.TabIndex = 7;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(355, 139);
            txtusername.Margin = new Padding(2);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(150, 27);
            txtusername.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnclear);
            Controls.Add(btnlogin);
            Controls.Add(lblpass);
            Controls.Add(lbluser);
            Controls.Add(txtpass);
            Controls.Add(txtusername);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnclear;
        private Button btnlogin;
        private Label lblpass;
        private Label lbluser;
        private TextBox txtpass;
        private TextBox txtusername;
    }
}
