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
            txtNama.Location = new Point(325, 128);
            txtNama.Margin = new Padding(4);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(350, 31);
            txtNama.TabIndex = 1;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // txtbarang
            // 
            txtbarang.Location = new Point(325, 200);
            txtbarang.Margin = new Padding(4);
            txtbarang.Name = "txtbarang";
            txtbarang.Size = new Size(350, 31);
            txtbarang.TabIndex = 2;
            txtbarang.TextChanged += txtbarang_TextChanged;
            // 
            // dtpTanggalSewa
            // 
            dtpTanggalSewa.Location = new Point(324, 360);
            dtpTanggalSewa.Margin = new Padding(4);
            dtpTanggalSewa.Name = "dtpTanggalSewa";
            dtpTanggalSewa.Size = new Size(352, 31);
            dtpTanggalSewa.TabIndex = 4;
            dtpTanggalSewa.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnlihat
            // 
            btnlihat.Location = new Point(559, 442);
            btnlihat.Margin = new Padding(4);
            btnlihat.Name = "btnlihat";
            btnlihat.Size = new Size(118, 36);
            btnlihat.TabIndex = 5;
            btnlihat.Text = "Lihat List";
            btnlihat.UseVisualStyleBackColor = true;
            btnlihat.Click += btnlihat_Click;
            // 
            // btnsimpan
            // 
            btnsimpan.Location = new Point(324, 442);
            btnsimpan.Margin = new Padding(4);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(118, 36);
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
            label1.Location = new Point(436, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(230, 50);
            label1.TabIndex = 7;
            label1.Text = "LensaPinjam";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(324, 99);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 8;
            label2.Text = "Nama Penyewa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(325, 171);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(186, 25);
            label3.TabIndex = 9;
            label3.Text = "Jenis Kamera / Iphone";
            // 
            // txtdurasi
            // 
            txtdurasi.AutoSize = true;
            txtdurasi.BackColor = Color.Transparent;
            txtdurasi.Location = new Point(325, 251);
            txtdurasi.Margin = new Padding(4, 0, 4, 0);
            txtdurasi.Name = "txtdurasi";
            txtdurasi.Size = new Size(108, 25);
            txtdurasi.TabIndex = 10;
            txtdurasi.Text = "Durasi Sewa";
            // 
            // cbxDurasi
            // 
            cbxDurasi.FormattingEnabled = true;
            cbxDurasi.Items.AddRange(new object[] { "24 Jam", "48 Jam", "72 Jam" });
            cbxDurasi.Location = new Point(325, 280);
            cbxDurasi.Margin = new Padding(4);
            cbxDurasi.Name = "cbxDurasi";
            cbxDurasi.Size = new Size(350, 33);
            cbxDurasi.TabIndex = 11;
            cbxDurasi.SelectedIndexChanged += cbxDurasi_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(324, 331);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 12;
            label4.Text = "Tanggal Sewa";
            // 
            // FormSewa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1000, 562);
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
            Margin = new Padding(4);
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
