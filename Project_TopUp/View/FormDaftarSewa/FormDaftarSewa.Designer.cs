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
            ((System.ComponentModel.ISupportInitialize)daftarSewa).BeginInit();
            SuspendLayout();
            // 
            // daftarSewa
            // 
            daftarSewa.AllowUserToAddRows = false;
            daftarSewa.AllowUserToDeleteRows = false;
            daftarSewa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            daftarSewa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            daftarSewa.Location = new Point(189, 89);
            daftarSewa.Margin = new Padding(4);
            daftarSewa.MultiSelect = false;
            daftarSewa.Name = "daftarSewa";
            daftarSewa.ReadOnly = true;
            daftarSewa.RowHeadersWidth = 51;
            daftarSewa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            daftarSewa.Size = new Size(691, 315);
            daftarSewa.TabIndex = 0;
            daftarSewa.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnkembali
            // 
            btnkembali.Location = new Point(189, 438);
            btnkembali.Margin = new Padding(4);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(118, 36);
            btnkembali.TabIndex = 1;
            btnkembali.Text = "Kembali";
            btnkembali.UseVisualStyleBackColor = true;
            btnkembali.Click += btnkembali_Click;
            // 
            // FormDaftarSewa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Tanpa_judul__1080_x_1080_piksel___Wallpaper_Desktop___1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnkembali);
            Controls.Add(daftarSewa);
            DoubleBuffered = true;
            Margin = new Padding(4);
            Name = "FormDaftarSewa";
            Text = "Form2";
            Load += FormDaftarSewa_Load_1;
            ((System.ComponentModel.ISupportInitialize)daftarSewa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView daftarSewa;
        private Button btnkembali;
    }
}