namespace YurtOtomasyonu2.Odemeler
{
    partial class MuhasebeGiris
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnMuhGuncelle = new System.Windows.Forms.Button();
            this.cbMuhMaas = new System.Windows.Forms.CheckBox();
            this.tbxMuhTopTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwMuh = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGorGuncelle = new System.Windows.Forms.Button();
            this.cbGorOdendiMi = new System.Windows.Forms.CheckBox();
            this.tbxGorTopTutar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgwGor = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbMudurMaasOdendiMi = new System.Windows.Forms.CheckBox();
            this.tbxMudToptutar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgwMudur = new System.Windows.Forms.DataGridView();
            this.btnMudGuncelle = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMuh)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGor)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMudur)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 432);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnMuhGuncelle);
            this.tabPage1.Controls.Add(this.cbMuhMaas);
            this.tabPage1.Controls.Add(this.tbxMuhTopTutar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgwMuh);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Muhasebeci";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnMuhGuncelle
            // 
            this.btnMuhGuncelle.Location = new System.Drawing.Point(578, 318);
            this.btnMuhGuncelle.Name = "btnMuhGuncelle";
            this.btnMuhGuncelle.Size = new System.Drawing.Size(131, 54);
            this.btnMuhGuncelle.TabIndex = 4;
            this.btnMuhGuncelle.Text = "Ödemeleri Tamamla";
            this.btnMuhGuncelle.UseVisualStyleBackColor = true;
            this.btnMuhGuncelle.Click += new System.EventHandler(this.btnMuhGuncelle_Click);
            // 
            // cbMuhMaas
            // 
            this.cbMuhMaas.AutoSize = true;
            this.cbMuhMaas.Location = new System.Drawing.Point(356, 239);
            this.cbMuhMaas.Name = "cbMuhMaas";
            this.cbMuhMaas.Size = new System.Drawing.Size(132, 21);
            this.cbMuhMaas.TabIndex = 3;
            this.cbMuhMaas.Text = "Maaş Ödendi Mi";
            this.cbMuhMaas.UseVisualStyleBackColor = true;
            // 
            // tbxMuhTopTutar
            // 
            this.tbxMuhTopTutar.Location = new System.Drawing.Point(165, 243);
            this.tbxMuhTopTutar.Name = "tbxMuhTopTutar";
            this.tbxMuhTopTutar.Size = new System.Drawing.Size(124, 22);
            this.tbxMuhTopTutar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ödenecek Tutar :";
            // 
            // dgwMuh
            // 
            this.dgwMuh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMuh.Location = new System.Drawing.Point(6, 6);
            this.dgwMuh.Name = "dgwMuh";
            this.dgwMuh.RowTemplate.Height = 24;
            this.dgwMuh.Size = new System.Drawing.Size(765, 192);
            this.dgwMuh.TabIndex = 0;
            this.dgwMuh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMuh_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGorGuncelle);
            this.tabPage2.Controls.Add(this.cbGorOdendiMi);
            this.tabPage2.Controls.Add(this.tbxGorTopTutar);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dgwGor);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gorevli";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGorGuncelle
            // 
            this.btnGorGuncelle.Location = new System.Drawing.Point(578, 330);
            this.btnGorGuncelle.Name = "btnGorGuncelle";
            this.btnGorGuncelle.Size = new System.Drawing.Size(131, 54);
            this.btnGorGuncelle.TabIndex = 9;
            this.btnGorGuncelle.Text = "Ödemeleri Tamamla";
            this.btnGorGuncelle.UseVisualStyleBackColor = true;
            this.btnGorGuncelle.Click += new System.EventHandler(this.btnGorGuncelle_Click);
            // 
            // cbGorOdendiMi
            // 
            this.cbGorOdendiMi.AutoSize = true;
            this.cbGorOdendiMi.Location = new System.Drawing.Point(356, 251);
            this.cbGorOdendiMi.Name = "cbGorOdendiMi";
            this.cbGorOdendiMi.Size = new System.Drawing.Size(132, 21);
            this.cbGorOdendiMi.TabIndex = 8;
            this.cbGorOdendiMi.Text = "Maaş Ödendi Mi";
            this.cbGorOdendiMi.UseVisualStyleBackColor = true;
            // 
            // tbxGorTopTutar
            // 
            this.tbxGorTopTutar.Location = new System.Drawing.Point(165, 255);
            this.tbxGorTopTutar.Name = "tbxGorTopTutar";
            this.tbxGorTopTutar.Size = new System.Drawing.Size(124, 22);
            this.tbxGorTopTutar.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ödenecek Tutar :";
            // 
            // dgwGor
            // 
            this.dgwGor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGor.Location = new System.Drawing.Point(6, 18);
            this.dgwGor.Name = "dgwGor";
            this.dgwGor.RowTemplate.Height = 24;
            this.dgwGor.Size = new System.Drawing.Size(765, 192);
            this.dgwGor.TabIndex = 5;
            this.dgwGor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwGor_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnMudGuncelle);
            this.tabPage3.Controls.Add(this.cbMudurMaasOdendiMi);
            this.tabPage3.Controls.Add(this.tbxMudToptutar);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.dgwMudur);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(777, 403);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mudur";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbMudurMaasOdendiMi
            // 
            this.cbMudurMaasOdendiMi.AutoSize = true;
            this.cbMudurMaasOdendiMi.Location = new System.Drawing.Point(356, 251);
            this.cbMudurMaasOdendiMi.Name = "cbMudurMaasOdendiMi";
            this.cbMudurMaasOdendiMi.Size = new System.Drawing.Size(132, 21);
            this.cbMudurMaasOdendiMi.TabIndex = 8;
            this.cbMudurMaasOdendiMi.Text = "Maaş Ödendi Mi";
            this.cbMudurMaasOdendiMi.UseVisualStyleBackColor = true;
            // 
            // tbxMudToptutar
            // 
            this.tbxMudToptutar.Location = new System.Drawing.Point(165, 255);
            this.tbxMudToptutar.Name = "tbxMudToptutar";
            this.tbxMudToptutar.Size = new System.Drawing.Size(124, 22);
            this.tbxMudToptutar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ödenecek Tutar :";
            // 
            // dgwMudur
            // 
            this.dgwMudur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMudur.Location = new System.Drawing.Point(6, 18);
            this.dgwMudur.Name = "dgwMudur";
            this.dgwMudur.RowTemplate.Height = 24;
            this.dgwMudur.Size = new System.Drawing.Size(765, 192);
            this.dgwMudur.TabIndex = 5;
            this.dgwMudur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMudur_CellClick);
            // 
            // btnMudGuncelle
            // 
            this.btnMudGuncelle.Location = new System.Drawing.Point(610, 328);
            this.btnMudGuncelle.Name = "btnMudGuncelle";
            this.btnMudGuncelle.Size = new System.Drawing.Size(131, 54);
            this.btnMudGuncelle.TabIndex = 10;
            this.btnMudGuncelle.Text = "Ödemeleri Tamamla";
            this.btnMudGuncelle.UseVisualStyleBackColor = true;
            this.btnMudGuncelle.Click += new System.EventHandler(this.btnMudGuncelle_Click);
            // 
            // MuhasebeGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MuhasebeGiris";
            this.Text = "MuhasebeGiris";
            this.Load += new System.EventHandler(this.MuhasebeGiris_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMuh)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGor)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMudur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgwMuh;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnMuhGuncelle;
        private System.Windows.Forms.CheckBox cbMuhMaas;
        private System.Windows.Forms.TextBox tbxMuhTopTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGorGuncelle;
        private System.Windows.Forms.CheckBox cbGorOdendiMi;
        private System.Windows.Forms.TextBox tbxGorTopTutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgwGor;
        private System.Windows.Forms.CheckBox cbMudurMaasOdendiMi;
        private System.Windows.Forms.TextBox tbxMudToptutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgwMudur;
        private System.Windows.Forms.Button btnMudGuncelle;
    }
}