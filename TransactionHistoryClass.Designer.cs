
namespace Assignment4_C_
{
    partial class TransactionHistoryClass
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dgv_display = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_display).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(802, 502);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(90, 33);
            button3.TabIndex = 7;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(447, 502);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(90, 33);
            button2.TabIndex = 6;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(88, 501);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(90, 34);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgv_display
            // 
            dgv_display.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_display.Location = new Point(49, 27);
            dgv_display.Margin = new Padding(2);
            dgv_display.Name = "dgv_display";
            dgv_display.RowHeadersWidth = 62;
            dgv_display.Size = new Size(883, 437);
            dgv_display.TabIndex = 4;
            dgv_display.CellContentClick += dgv_history_CellContentClick;
            // 
            // TransactionHistoryClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 672);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgv_display);
            Name = "TransactionHistoryClass";
            Text = "TransactionHistory";
            Load += TransactionHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_display).EndInit();
            ResumeLayout(false);
        }

        private void dgv_history_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dgv_display;
    }
}