namespace Project_SewaKamera
{
    partial class FormDaftarSewa
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
            dataGridView1 = new DataGridView();
            ColNama = new DataGridViewTextBoxColumn();
            ColBarang = new DataGridViewTextBoxColumn();
            ColDurasi = new DataGridViewTextBoxColumn();
            ColTanggal = new DataGridViewTextBoxColumn();
            btnkembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColNama, ColBarang, ColDurasi, ColTanggal });
            dataGridView1.Location = new Point(151, 71);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(553, 252);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColNama
            // 
            ColNama.HeaderText = "Nama Penyewa";
            ColNama.MinimumWidth = 6;
            ColNama.Name = "ColNama";
            ColNama.ReadOnly = true;
            // 
            // ColBarang
            // 
            ColBarang.HeaderText = "Barang";
            ColBarang.MinimumWidth = 6;
            ColBarang.Name = "ColBarang";
            ColBarang.ReadOnly = true;
            // 
            // ColDurasi
            // 
            ColDurasi.HeaderText = "Durasi";
            ColDurasi.MinimumWidth = 6;
            ColDurasi.Name = "ColDurasi";
            ColDurasi.ReadOnly = true;
            // 
            // ColTanggal
            // 
            ColTanggal.HeaderText = "Tanggal Sewa";
            ColTanggal.MinimumWidth = 6;
            ColTanggal.Name = "ColTanggal";
            ColTanggal.ReadOnly = true;
            // 
            // btnkembali
            // 
            btnkembali.Location = new Point(151, 345);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(94, 29);
            btnkembali.TabIndex = 1;
            btnkembali.Text = "Kembali";
            btnkembali.UseVisualStyleBackColor = true;
            btnkembali.Click += btnkembali_Click;
            // 
            // FormDaftarSewa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Tanpa_judul__1080_x_1080_piksel___Wallpaper_Desktop___1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnkembali);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "FormDaftarSewa";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColNama;
        private DataGridViewTextBoxColumn ColBarang;
        private DataGridViewTextBoxColumn ColDurasi;
        private DataGridViewTextBoxColumn ColTanggal;
        private Button btnkembali;
    }
}