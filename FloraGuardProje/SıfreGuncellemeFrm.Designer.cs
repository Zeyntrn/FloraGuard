namespace FloraGuardProje
{
    partial class SıfreGuncellemeFrm
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
            BtnSifreGuncelle = new Button();
            txtSifre = new TextBox();
            txtMail = new TextBox();
            label6 = new Label();
            label3 = new Label();
            btnCikis = new Button();
            SuspendLayout();
            // 
            // BtnSifreGuncelle
            // 
            BtnSifreGuncelle.BackColor = Color.Transparent;
            BtnSifreGuncelle.FlatStyle = FlatStyle.Flat;
            BtnSifreGuncelle.Location = new Point(220, 259);
            BtnSifreGuncelle.Name = "BtnSifreGuncelle";
            BtnSifreGuncelle.Size = new Size(153, 42);
            BtnSifreGuncelle.TabIndex = 28;
            BtnSifreGuncelle.Text = "Şifremi Güncelle";
            BtnSifreGuncelle.UseVisualStyleBackColor = false;
            BtnSifreGuncelle.Click += BtnSifreGuncelle_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(285, 177);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(177, 27);
            txtSifre.TabIndex = 27;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(288, 115);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(177, 27);
            txtMail.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(135, 115);
            label6.Name = "label6";
            label6.Size = new Size(139, 28);
            label6.TabIndex = 25;
            label6.Text = "Mail              :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(134, 173);
            label3.Name = "label3";
            label3.Size = new Size(145, 28);
            label3.TabIndex = 24;
            label3.Text = "Kullanıcı Şifre :";
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Transparent;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.Location = new Point(554, 2);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(47, 42);
            btnCikis.TabIndex = 29;
            btnCikis.Text = "X";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // SıfreGuncellemeFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fLORAGUARD__1_;
            ClientSize = new Size(603, 375);
            Controls.Add(btnCikis);
            Controls.Add(BtnSifreGuncelle);
            Controls.Add(txtSifre);
            Controls.Add(txtMail);
            Controls.Add(label6);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "SıfreGuncellemeFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SıfreGuncellemeFrm";
            Load += SıfreGuncellemeFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSifreGuncelle;
        private TextBox txtSifre;
        private TextBox txtMail;
        private Label label6;
        private Label label3;
        private Button btnCikis;
    }
}