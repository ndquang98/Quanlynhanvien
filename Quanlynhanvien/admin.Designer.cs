
namespace Quanlynhanvien
{
    partial class admin
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
            this.bt_them = new System.Windows.Forms.Button();
            this.Bt_sua = new System.Windows.Forms.Button();
            this.Bt_xoa = new System.Windows.Forms.Button();
            this.dtadmin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tk = new System.Windows.Forms.TextBox();
            this.tb_mk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_tennd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtadmin)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(355, 174);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 23);
            this.bt_them.TabIndex = 0;
            this.bt_them.Text = "Them";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // Bt_sua
            // 
            this.Bt_sua.Location = new System.Drawing.Point(355, 215);
            this.Bt_sua.Name = "Bt_sua";
            this.Bt_sua.Size = new System.Drawing.Size(75, 23);
            this.Bt_sua.TabIndex = 1;
            this.Bt_sua.Text = "Sua";
            this.Bt_sua.UseVisualStyleBackColor = true;
            this.Bt_sua.Click += new System.EventHandler(this.Bt_sua_Click);
            // 
            // Bt_xoa
            // 
            this.Bt_xoa.Location = new System.Drawing.Point(355, 255);
            this.Bt_xoa.Name = "Bt_xoa";
            this.Bt_xoa.Size = new System.Drawing.Size(75, 23);
            this.Bt_xoa.TabIndex = 2;
            this.Bt_xoa.Text = "Xoa";
            this.Bt_xoa.UseVisualStyleBackColor = true;
            this.Bt_xoa.Click += new System.EventHandler(this.Bt_xoa_Click);
            // 
            // dtadmin
            // 
            this.dtadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtadmin.Location = new System.Drawing.Point(40, 24);
            this.dtadmin.Name = "dtadmin";
            this.dtadmin.Size = new System.Drawing.Size(390, 132);
            this.dtadmin.TabIndex = 3;
            this.dtadmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtadmin_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tai khoan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mat khau";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_tk
            // 
            this.tb_tk.Location = new System.Drawing.Point(126, 213);
            this.tb_tk.Name = "tb_tk";
            this.tb_tk.Size = new System.Drawing.Size(151, 20);
            this.tb_tk.TabIndex = 9;
            // 
            // tb_mk
            // 
            this.tb_mk.Location = new System.Drawing.Point(126, 252);
            this.tb_mk.Name = "tb_mk";
            this.tb_mk.Size = new System.Drawing.Size(151, 20);
            this.tb_mk.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ten nguoi dung";
            // 
            // tb_tennd
            // 
            this.tb_tennd.Location = new System.Drawing.Point(126, 177);
            this.tb_tennd.Name = "tb_tennd";
            this.tb_tennd.Size = new System.Drawing.Size(151, 20);
            this.tb_tennd.TabIndex = 12;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 302);
            this.Controls.Add(this.tb_tennd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_mk);
            this.Controls.Add(this.tb_tk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtadmin);
            this.Controls.Add(this.Bt_xoa);
            this.Controls.Add(this.Bt_sua);
            this.Controls.Add(this.bt_them);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtadmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button Bt_sua;
        private System.Windows.Forms.Button Bt_xoa;
        private System.Windows.Forms.DataGridView dtadmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_tk;
        private System.Windows.Forms.TextBox tb_mk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_tennd;
    }
}