namespace OopAssesment2HasanFidan.cs
{
    partial class Form2
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
            this.txbx_adSoyad = new System.Windows.Forms.TextBox();
            this.rdb_bay = new System.Windows.Forms.RadioButton();
            this.rdb_kadin = new System.Windows.Forms.RadioButton();
            this.lbl_adSoyad = new System.Windows.Forms.Label();
            this.lbl_tcNo = new System.Windows.Forms.Label();
            this.txbx_tcNo = new System.Windows.Forms.TextBox();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbx_adSoyad
            // 
            this.txbx_adSoyad.Location = new System.Drawing.Point(97, 6);
            this.txbx_adSoyad.Name = "txbx_adSoyad";
            this.txbx_adSoyad.Size = new System.Drawing.Size(170, 22);
            this.txbx_adSoyad.TabIndex = 0;
            // 
            // rdb_bay
            // 
            this.rdb_bay.AutoSize = true;
            this.rdb_bay.Checked = true;
            this.rdb_bay.Location = new System.Drawing.Point(282, 9);
            this.rdb_bay.Name = "rdb_bay";
            this.rdb_bay.Size = new System.Drawing.Size(65, 21);
            this.rdb_bay.TabIndex = 1;
            this.rdb_bay.TabStop = true;
            this.rdb_bay.Text = "Erkek";
            this.rdb_bay.UseVisualStyleBackColor = true;
            // 
            // rdb_kadin
            // 
            this.rdb_kadin.AutoSize = true;
            this.rdb_kadin.Location = new System.Drawing.Point(282, 44);
            this.rdb_kadin.Name = "rdb_kadin";
            this.rdb_kadin.Size = new System.Drawing.Size(65, 21);
            this.rdb_kadin.TabIndex = 2;
            this.rdb_kadin.Text = "Kadın";
            this.rdb_kadin.UseVisualStyleBackColor = true;
            // 
            // lbl_adSoyad
            // 
            this.lbl_adSoyad.AutoSize = true;
            this.lbl_adSoyad.Location = new System.Drawing.Point(12, 9);
            this.lbl_adSoyad.Name = "lbl_adSoyad";
            this.lbl_adSoyad.Size = new System.Drawing.Size(79, 17);
            this.lbl_adSoyad.TabIndex = 3;
            this.lbl_adSoyad.Text = "AD SOYAD";
            // 
            // lbl_tcNo
            // 
            this.lbl_tcNo.AutoSize = true;
            this.lbl_tcNo.Location = new System.Drawing.Point(12, 44);
            this.lbl_tcNo.Name = "lbl_tcNo";
            this.lbl_tcNo.Size = new System.Drawing.Size(59, 17);
            this.lbl_tcNo.TabIndex = 4;
            this.lbl_tcNo.Text = "TC NO :";
            // 
            // txbx_tcNo
            // 
            this.txbx_tcNo.Location = new System.Drawing.Point(96, 44);
            this.txbx_tcNo.Name = "txbx_tcNo";
            this.txbx_tcNo.Size = new System.Drawing.Size(171, 22);
            this.txbx_tcNo.TabIndex = 5;
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(97, 97);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(75, 23);
            this.btn_iptal.TabIndex = 6;
            this.btn_iptal.Text = "Iptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_onayla
            // 
            this.btn_onayla.Location = new System.Drawing.Point(192, 97);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(75, 23);
            this.btn_onayla.TabIndex = 7;
            this.btn_onayla.Text = "Onayla";
            this.btn_onayla.UseVisualStyleBackColor = true;
            this.btn_onayla.Click += new System.EventHandler(this.Btn_onayla_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 197);
            this.Controls.Add(this.btn_onayla);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.txbx_tcNo);
            this.Controls.Add(this.lbl_tcNo);
            this.Controls.Add(this.lbl_adSoyad);
            this.Controls.Add(this.rdb_kadin);
            this.Controls.Add(this.rdb_bay);
            this.Controls.Add(this.txbx_adSoyad);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_adSoyad;
        private System.Windows.Forms.RadioButton rdb_bay;
        private System.Windows.Forms.RadioButton rdb_kadin;
        private System.Windows.Forms.Label lbl_adSoyad;
        private System.Windows.Forms.Label lbl_tcNo;
        private System.Windows.Forms.TextBox txbx_tcNo;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_onayla;
    }
}