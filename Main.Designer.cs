namespace Student
{
    partial class Main
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
            this.pnl = new System.Windows.Forms.Panel();
            this.gv = new System.Windows.Forms.DataGridView();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtClassNo = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.gv);
            this.pnl.Location = new System.Drawing.Point(2, 119);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(472, 312);
            this.pnl.TabIndex = 1;
            // 
            // gv
            // 
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv.Location = new System.Drawing.Point(0, 0);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(472, 312);
            this.gv.TabIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(315, 91);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 23);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "ثبت";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(315, 6);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(100, 20);
            this.txtFullname.TabIndex = 3;
            // 
            // txtClassNo
            // 
            this.txtClassNo.Location = new System.Drawing.Point(315, 65);
            this.txtClassNo.Name = "txtClassNo";
            this.txtClassNo.Size = new System.Drawing.Size(100, 20);
            this.txtClassNo.TabIndex = 4;
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(315, 36);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(100, 20);
            this.txtGrade.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "نام کامل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "نمره";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "کلاس";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 65);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(12, 29);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(100, 20);
            this.txtDelete.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "شناسه";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 443);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtClassNo);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtClassNo;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Label label4;
    }
}