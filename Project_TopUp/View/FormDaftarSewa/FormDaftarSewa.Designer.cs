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
            daftarSewa = new DataGridView();
            btnkembali = new Button();
            btnedit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)daftarSewa).BeginInit();
            SuspendLayout();
            // 
            // daftarSewa
            // 
            daftarSewa.AllowUserToAddRows = false;
            daftarSewa.AllowUserToDeleteRows = false;
            daftarSewa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            daftarSewa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            daftarSewa.Location = new Point(151, 71);
            daftarSewa.MultiSelect = false;
            daftarSewa.Name = "daftarSewa";
            daftarSewa.ReadOnly = true;
            daftarSewa.RowHeadersWidth = 51;
            daftarSewa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            daftarSewa.Size = new Size(553, 252);
            daftarSewa.TabIndex = 0;
            daftarSewa.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnkembali
            // 
            btnkembali.Location = new Point(151, 350);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(94, 29);
            btnkembali.TabIndex = 1;
            btnkembali.Text = "Kembali";
            btnkembali.UseVisualStyleBackColor = true;
            btnkembali.Click += btnkembali_Click;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(367, 350);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(94, 29);
            btnedit.TabIndex = 2;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(567, 350);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Hapus";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // FormDaftarSewa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Tanpa_judul__1080_x_1080_piksel___Wallpaper_Desktop___1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnedit);
            Controls.Add(btnkembali);
            Controls.Add(daftarSewa);
            DoubleBuffered = true;
            Name = "FormDaftarSewa";
            Text = "Form2";
            Load += FormDaftarSewa_Load_1;
            ((System.ComponentModel.ISupportInitialize)daftarSewa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView daftarSewa;
        private Button btnkembali;
        private Button btnedit;
        private Button btnDelete;
    }
}