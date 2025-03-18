namespace SqlToModel
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTableName = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClassName = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.txtConn = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableName.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConn.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(184, 150);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Properties.Appearance.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTableName.Properties.Appearance.Options.UseFont = true;
            this.txtTableName.Size = new System.Drawing.Size(298, 30);
            this.txtTableName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtClassName);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtConn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTableName);
            this.panel1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 762);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(134, 570);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 80);
            this.button2.TabIndex = 11;
            this.button2.Text = "OutFile";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(52, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "ClassName:";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(184, 74);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Properties.Appearance.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtClassName.Properties.Appearance.Options.UseFont = true;
            this.txtClassName.Size = new System.Drawing.Size(298, 30);
            this.txtClassName.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(134, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 76);
            this.button1.TabIndex = 1;
            this.button1.Text = "Begin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtConn
            // 
            this.txtConn.Location = new System.Drawing.Point(57, 368);
            this.txtConn.Name = "txtConn";
            this.txtConn.Properties.Appearance.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtConn.Properties.Appearance.Options.UseFont = true;
            this.txtConn.Size = new System.Drawing.Size(428, 30);
            this.txtConn.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(52, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "StringConnection:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(52, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "TableName:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtResult);
            this.panel2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(558, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1472, 762);
            this.panel2.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(3, 3);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(1466, 756);
            this.txtResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2108, 872);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "SqlToModel";
            ((System.ComponentModel.ISupportInitialize)(this.txtTableName.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConn.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTableName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtResult;
        private DevExpress.XtraEditors.TextEdit txtConn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtClassName;
        private System.Windows.Forms.Button button2;
    }
}

