namespace Assignment4_C_
{
    partial class AddTransactions
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
            btn_clear = new Button();
            btn_add = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtdescp = new TextBox();
            txtamount = new TextBox();
            txtaccid = new TextBox();
            SuspendLayout();
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(430, 290);
            btn_clear.Margin = new Padding(2);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(90, 35);
            btn_clear.TabIndex = 15;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(292, 290);
            btn_add.Margin = new Padding(2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(90, 35);
            btn_add.TabIndex = 14;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(280, 219);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 13;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 169);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 12;
            label2.Text = "Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(282, 127);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 11;
            label1.Text = "Account ID";
            // 
            // txtdescp
            // 
            txtdescp.Location = new Point(366, 214);
            txtdescp.Margin = new Padding(2);
            txtdescp.Name = "txtdescp";
            txtdescp.Size = new Size(154, 27);
            txtdescp.TabIndex = 10;
            // 
            // txtamount
            // 
            txtamount.Location = new Point(366, 166);
            txtamount.Margin = new Padding(2);
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(154, 27);
            txtamount.TabIndex = 9;
            // 
            // txtaccid
            // 
            txtaccid.Location = new Point(366, 125);
            txtaccid.Margin = new Padding(2);
            txtaccid.Name = "txtaccid";
            txtaccid.Size = new Size(154, 27);
            txtaccid.TabIndex = 8;
            // 
            // AddTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_clear);
            Controls.Add(btn_add);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtdescp);
            Controls.Add(txtamount);
            Controls.Add(txtaccid);
            Name = "AddTransactions";
            Text = "AddTransactions";
            Load += AddTransactions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_clear;
        private Button btn_add;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtdescp;
        private TextBox txtamount;
        private TextBox txtaccid;
    }
}