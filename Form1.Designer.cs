namespace TableToModel
{
    partial class Form1
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
            panel2 = new Panel();
            txtResult = new TextBox();
            panel1 = new Panel();
            button2 = new Button();
            txtConn = new TextBox();
            txtTableName = new TextBox();
            txtClassName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txtResult);
            panel2.Location = new Point(571, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(1751, 996);
            panel2.TabIndex = 1;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Microsoft YaHei UI", 14F);
            txtResult.Location = new Point(3, 3);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ScrollBars = ScrollBars.Both;
            txtResult.Size = new Size(1745, 993);
            txtResult.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txtConn);
            panel1.Controls.Add(txtTableName);
            panel1.Controls.Add(txtClassName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(65, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 996);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(30, 533);
            button2.Name = "button2";
            button2.Size = new Size(142, 77);
            button2.TabIndex = 4;
            button2.Text = "OutFile";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtConn
            // 
            txtConn.Location = new Point(30, 323);
            txtConn.Name = "txtConn";
            txtConn.Size = new Size(425, 30);
            txtConn.TabIndex = 5;
            // 
            // txtTableName
            // 
            txtTableName.Location = new Point(145, 185);
            txtTableName.Name = "txtTableName";
            txtTableName.Size = new Size(310, 30);
            txtTableName.TabIndex = 4;
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(145, 105);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(310, 30);
            txtClassName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 274);
            label3.Name = "label3";
            label3.Size = new Size(164, 24);
            label3.TabIndex = 2;
            label3.Text = "StringConnection:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 191);
            label2.Name = "label2";
            label2.Size = new Size(113, 24);
            label2.TabIndex = 1;
            label2.Text = "TableName:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 105);
            label1.Name = "label1";
            label1.Size = new Size(109, 24);
            label1.TabIndex = 0;
            label1.Text = "ClassName:";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 9F);
            button1.Location = new Point(313, 533);
            button1.Name = "button1";
            button1.Size = new Size(142, 77);
            button1.TabIndex = 3;
            button1.Text = "begin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(2374, 1149);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Minimized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private TextBox txtResult;
        private Panel panel1;
        private Button button2;
        private TextBox txtConn;
        private TextBox txtTableName;
        private TextBox txtClassName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}
