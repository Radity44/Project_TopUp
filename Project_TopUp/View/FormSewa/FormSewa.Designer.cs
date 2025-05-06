namespace Project_TopUp
{
    partial class FormSewa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSewa));
            txtNama = new TextBox();
            txtbarang = new TextBox();
            dtpTanggalSewa = new DateTimePicker();
            btnlihat = new Button();
            btnsimpan = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtdurasi = new Label();
            cbxDurasi = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtNama
            // 
            txtNama.Location = new Point(260, 102);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(281, 27);
            txtNama.TabIndex = 1;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // txtbarang
            // 
            txtbarang.Location = new Point(260, 160);
            txtbarang.Name = "txtbarang";
            txtbarang.Size = new Size(281, 27);
            txtbarang.TabIndex = 2;
            txtbarang.TextChanged += txtbarang_TextChanged;
            // 
            // dtpTanggalSewa
            // 
            dtpTanggalSewa.Location = new Point(259, 288);
            dtpTanggalSewa.Name = "dtpTanggalSewa";
            dtpTanggalSewa.Size = new Size(282, 27);
            dtpTanggalSewa.TabIndex = 4;
            dtpTanggalSewa.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnlihat
            // 
            btnlihat.Location = new Point(446, 343);
            btnlihat.Name = "btnlihat";
            btnlihat.Size = new Size(94, 29);
            btnlihat.TabIndex = 5;
            btnlihat.Text = "Lihat List";
            btnlihat.UseVisualStyleBackColor = true;
            btnlihat.Click += btnlihat_Click;
            // 
            // btnsimpan
            // 
            btnsimpan.Location = new Point(259, 343);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(94, 29);
            btnsimpan.TabIndex = 6;
            btnsimpan.Text = "Simpan";
            btnsimpan.UseVisualStyleBackColor = true;
            btnsimpan.Click += btnSimpan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(349, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 41);
            label1.TabIndex = 7;
            label1.Text = "LensaPinjam";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(259, 79);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 8;
            label2.Text = "Nama Penyewa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(260, 137);
            label3.Name = "label3";
            label3.Size = new Size(155, 20);
            label3.TabIndex = 9;
            label3.Text = "Jenis Kamera / Iphone";
            // 
            // txtdurasi
            // 
            txtdurasi.AutoSize = true;
            txtdurasi.BackColor = Color.Transparent;
            txtdurasi.Location = new Point(260, 201);
            txtdurasi.Name = "txtdurasi";
            txtdurasi.Size = new Size(130, 20);
            txtdurasi.TabIndex = 10;
            txtdurasi.Text = "Durasi Sewa (Jam)";
            // 
            // cbxDurasi
            // 
            cbxDurasi.FormattingEnabled = true;
            cbxDurasi.Items.AddRange(new object[] { "24", "48", "72" });
            cbxDurasi.Location = new Point(260, 224);
            cbxDurasi.Name = "cbxDurasi";
            cbxDurasi.Size = new Size(281, 28);
            cbxDurasi.TabIndex = 11;
            cbxDurasi.SelectedIndexChanged += cbxDurasi_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(259, 265);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 12;
            label4.Text = "Tanggal Sewa";
            // 
            // FormSewa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(cbxDurasi);
            Controls.Add(txtdurasi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnsimpan);
            Controls.Add(btnlihat);
            Controls.Add(dtpTanggalSewa);
            Controls.Add(txtbarang);
            Controls.Add(txtNama);
            DoubleBuffered = true;
            Name = "FormSewa";
            Text = "FormSewa";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNama;
        private TextBox txtbarang;
        private DateTimePicker dtpTanggalSewa;
        private Button btnlihat;
        private Button btnsimpan;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label txtdurasi;
        private ComboBox cbxDurasi;
        private Label label4;
    }
}
