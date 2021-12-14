namespace TaraftarYonetimSistemi
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTakimAd = new System.Windows.Forms.TextBox();
            this.btnTakimEkle = new System.Windows.Forms.Button();
            this.btnKisiEkle = new System.Windows.Forms.Button();
            this.txtKisiAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTuttuguTakim = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTakim = new System.Windows.Forms.ComboBox();
            this.lstTaraftarlar = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkTakimTutmuyor = new System.Windows.Forms.CheckBox();
            this.btnTakimiSil = new System.Windows.Forms.Button();
            this.btnTakimdanCikar = new System.Windows.Forms.Button();
            this.btnTakimDegistir = new System.Windows.Forms.Button();
            this.cboYeniTakim = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnTakimEkle);
            this.groupBox1.Controls.Add(this.txtTakimAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 431);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Takim Ekle";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.chkTakimTutmuyor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboTuttuguTakim);
            this.groupBox2.Controls.Add(this.btnKisiEkle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtKisiAd);
            this.groupBox2.Location = new System.Drawing.Point(232, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 431);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kişi Ekle";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cboYeniTakim);
            this.groupBox3.Controls.Add(this.btnTakimDegistir);
            this.groupBox3.Controls.Add(this.btnTakimdanCikar);
            this.groupBox3.Controls.Add(this.btnTakimiSil);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lstTaraftarlar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cboTakim);
            this.groupBox3.Location = new System.Drawing.Point(456, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 443);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Taraftarlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // txtTakimAd
            // 
            this.txtTakimAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTakimAd.Location = new System.Drawing.Point(9, 55);
            this.txtTakimAd.Name = "txtTakimAd";
            this.txtTakimAd.Size = new System.Drawing.Size(185, 20);
            this.txtTakimAd.TabIndex = 1;
            // 
            // btnTakimEkle
            // 
            this.btnTakimEkle.Location = new System.Drawing.Point(119, 91);
            this.btnTakimEkle.Name = "btnTakimEkle";
            this.btnTakimEkle.Size = new System.Drawing.Size(75, 23);
            this.btnTakimEkle.TabIndex = 2;
            this.btnTakimEkle.Text = "Ekle";
            this.btnTakimEkle.UseVisualStyleBackColor = true;
            this.btnTakimEkle.Click += new System.EventHandler(this.btnTakimEkle_Click);
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.Location = new System.Drawing.Point(125, 179);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(75, 23);
            this.btnKisiEkle.TabIndex = 5;
            this.btnKisiEkle.Text = "Ekle";
            this.btnKisiEkle.UseVisualStyleBackColor = true;
            this.btnKisiEkle.Click += new System.EventHandler(this.btnKisiEkle_Click);
            // 
            // txtKisiAd
            // 
            this.txtKisiAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKisiAd.Location = new System.Drawing.Point(9, 55);
            this.txtKisiAd.Name = "txtKisiAd";
            this.txtKisiAd.Size = new System.Drawing.Size(185, 20);
            this.txtKisiAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad";
            // 
            // cboTuttuguTakim
            // 
            this.cboTuttuguTakim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTuttuguTakim.DisplayMember = "Ad";
            this.cboTuttuguTakim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTuttuguTakim.FormattingEnabled = true;
            this.cboTuttuguTakim.Location = new System.Drawing.Point(9, 152);
            this.cboTuttuguTakim.Name = "cboTuttuguTakim";
            this.cboTuttuguTakim.Size = new System.Drawing.Size(185, 21);
            this.cboTuttuguTakim.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Takım";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Takım";
            // 
            // cboTakim
            // 
            this.cboTakim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTakim.DisplayMember = "Ad";
            this.cboTakim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTakim.FormattingEnabled = true;
            this.cboTakim.Location = new System.Drawing.Point(6, 54);
            this.cboTakim.Name = "cboTakim";
            this.cboTakim.Size = new System.Drawing.Size(209, 21);
            this.cboTakim.TabIndex = 1;
            this.cboTakim.SelectedIndexChanged += new System.EventHandler(this.cboTakim_SelectedIndexChanged);
            // 
            // lstTaraftarlar
            // 
            this.lstTaraftarlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTaraftarlar.DisplayMember = "Ad";
            this.lstTaraftarlar.FormattingEnabled = true;
            this.lstTaraftarlar.Location = new System.Drawing.Point(6, 120);
            this.lstTaraftarlar.Name = "lstTaraftarlar";
            this.lstTaraftarlar.Size = new System.Drawing.Size(311, 186);
            this.lstTaraftarlar.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Taraftarlar";
            // 
            // chkTakimTutmuyor
            // 
            this.chkTakimTutmuyor.AutoSize = true;
            this.chkTakimTutmuyor.Location = new System.Drawing.Point(9, 101);
            this.chkTakimTutmuyor.Name = "chkTakimTutmuyor";
            this.chkTakimTutmuyor.Size = new System.Drawing.Size(98, 17);
            this.chkTakimTutmuyor.TabIndex = 2;
            this.chkTakimTutmuyor.Text = "Takım tutmuyor";
            this.chkTakimTutmuyor.UseVisualStyleBackColor = true;
            this.chkTakimTutmuyor.CheckedChanged += new System.EventHandler(this.chkTakimTutmuyor_CheckedChanged);
            // 
            // btnTakimiSil
            // 
            this.btnTakimiSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTakimiSil.Location = new System.Drawing.Point(242, 55);
            this.btnTakimiSil.Name = "btnTakimiSil";
            this.btnTakimiSil.Size = new System.Drawing.Size(75, 23);
            this.btnTakimiSil.TabIndex = 6;
            this.btnTakimiSil.Text = "Takımı Sil";
            this.btnTakimiSil.UseVisualStyleBackColor = true;
            this.btnTakimiSil.Click += new System.EventHandler(this.btnTakimiSil_Click);
            // 
            // btnTakimdanCikar
            // 
            this.btnTakimdanCikar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTakimdanCikar.Location = new System.Drawing.Point(6, 312);
            this.btnTakimdanCikar.Name = "btnTakimdanCikar";
            this.btnTakimdanCikar.Size = new System.Drawing.Size(317, 23);
            this.btnTakimdanCikar.TabIndex = 7;
            this.btnTakimdanCikar.Text = "Taraftarı Takımdan Çıkar";
            this.btnTakimdanCikar.UseVisualStyleBackColor = true;
            this.btnTakimdanCikar.Click += new System.EventHandler(this.btnTakimdanCikar_Click);
            // 
            // btnTakimDegistir
            // 
            this.btnTakimDegistir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTakimDegistir.Location = new System.Drawing.Point(6, 408);
            this.btnTakimDegistir.Name = "btnTakimDegistir";
            this.btnTakimDegistir.Size = new System.Drawing.Size(317, 23);
            this.btnTakimDegistir.TabIndex = 8;
            this.btnTakimDegistir.Text = "Takımını Değiştir";
            this.btnTakimDegistir.UseVisualStyleBackColor = true;
            this.btnTakimDegistir.Click += new System.EventHandler(this.btnTakimDegistir_Click);
            // 
            // cboYeniTakim
            // 
            this.cboYeniTakim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboYeniTakim.DisplayMember = "Ad";
            this.cboYeniTakim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYeniTakim.FormattingEnabled = true;
            this.cboYeniTakim.Location = new System.Drawing.Point(6, 380);
            this.cboYeniTakim.Name = "cboYeniTakim";
            this.cboYeniTakim.Size = new System.Drawing.Size(311, 21);
            this.cboYeniTakim.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Yeni Takımı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 481);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Taraftar Yönetim Sistemi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTakimEkle;
        private System.Windows.Forms.TextBox txtTakimAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTuttuguTakim;
        private System.Windows.Forms.Button btnKisiEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKisiAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstTaraftarlar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTakim;
        private System.Windows.Forms.CheckBox chkTakimTutmuyor;
        private System.Windows.Forms.Button btnTakimiSil;
        private System.Windows.Forms.Button btnTakimdanCikar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboYeniTakim;
        private System.Windows.Forms.Button btnTakimDegistir;
    }
}

