namespace YurtOtomasyonu2.Odalar
{
    partial class OdaForm
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxKisiler = new System.Windows.Forms.TextBox();
            this.tbxKisiSayi = new System.Windows.Forms.TextBox();
            this.tbxOdaNo = new System.Windows.Forms.TextBox();
            this.dgwOda = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxKalan = new System.Windows.Forms.TextBox();
            this.cbxTemizMi = new System.Windows.Forms.CheckBox();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(82, 374);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(113, 41);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kişiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kisi Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Oda No:";
            // 
            // tbxKisiler
            // 
            this.tbxKisiler.Location = new System.Drawing.Point(139, 290);
            this.tbxKisiler.Name = "tbxKisiler";
            this.tbxKisiler.Size = new System.Drawing.Size(100, 22);
            this.tbxKisiler.TabIndex = 11;
            // 
            // tbxKisiSayi
            // 
            this.tbxKisiSayi.Location = new System.Drawing.Point(139, 246);
            this.tbxKisiSayi.Name = "tbxKisiSayi";
            this.tbxKisiSayi.Size = new System.Drawing.Size(100, 22);
            this.tbxKisiSayi.TabIndex = 10;
            // 
            // tbxOdaNo
            // 
            this.tbxOdaNo.Location = new System.Drawing.Point(139, 206);
            this.tbxOdaNo.Name = "tbxOdaNo";
            this.tbxOdaNo.Size = new System.Drawing.Size(100, 22);
            this.tbxOdaNo.TabIndex = 9;
            // 
            // dgwOda
            // 
            this.dgwOda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOda.Location = new System.Drawing.Point(12, 36);
            this.dgwOda.Name = "dgwOda";
            this.dgwOda.RowTemplate.Height = 24;
            this.dgwOda.Size = new System.Drawing.Size(776, 145);
            this.dgwOda.TabIndex = 8;
            this.dgwOda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOda_CellClick);
            this.dgwOda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOda_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kalan Kişi Sayısı";
            // 
            // tbxKalan
            // 
            this.tbxKalan.Location = new System.Drawing.Point(139, 331);
            this.tbxKalan.Name = "tbxKalan";
            this.tbxKalan.Size = new System.Drawing.Size(100, 22);
            this.tbxKalan.TabIndex = 16;
            // 
            // cbxTemizMi
            // 
            this.cbxTemizMi.AutoSize = true;
            this.cbxTemizMi.Location = new System.Drawing.Point(300, 206);
            this.cbxTemizMi.Name = "cbxTemizMi";
            this.cbxTemizMi.Size = new System.Drawing.Size(147, 21);
            this.cbxTemizMi.TabIndex = 18;
            this.cbxTemizMi.Text = "Oda Temizlendi Mi";
            this.cbxTemizMi.UseVisualStyleBackColor = true;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(372, 295);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(129, 56);
            this.btnGeri.TabIndex = 19;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // OdaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.cbxTemizMi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxKalan);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxKisiler);
            this.Controls.Add(this.tbxKisiSayi);
            this.Controls.Add(this.tbxOdaNo);
            this.Controls.Add(this.dgwOda);
            this.Name = "OdaForm";
            this.Text = "OdaForm";
            this.Load += new System.EventHandler(this.OdaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxKisiler;
        private System.Windows.Forms.TextBox tbxKisiSayi;
        private System.Windows.Forms.TextBox tbxOdaNo;
        private System.Windows.Forms.DataGridView dgwOda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxKalan;
        private System.Windows.Forms.CheckBox cbxTemizMi;
        private System.Windows.Forms.Button btnGeri;
    }
}