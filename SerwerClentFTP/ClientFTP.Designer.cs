namespace SerwerClentFTP
{
    partial class ClientFTP
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListaPlikow = new System.Windows.Forms.ListBox();
            this.btRozlacz = new System.Windows.Forms.Button();
            this.btPobierz = new System.Windows.Forms.Button();
            this.btWczytaj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Lp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ścieżka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaPlikow
            // 
            this.ListaPlikow.FormattingEnabled = true;
            this.ListaPlikow.ItemHeight = 16;
            this.ListaPlikow.Location = new System.Drawing.Point(29, 67);
            this.ListaPlikow.Name = "ListaPlikow";
            this.ListaPlikow.Size = new System.Drawing.Size(275, 372);
            this.ListaPlikow.TabIndex = 0;
            this.ListaPlikow.DoubleClick += new System.EventHandler(this.ListaPlikow_DoubleClick);
            // 
            // btRozlacz
            // 
            this.btRozlacz.Location = new System.Drawing.Point(229, 458);
            this.btRozlacz.Name = "btRozlacz";
            this.btRozlacz.Size = new System.Drawing.Size(75, 29);
            this.btRozlacz.TabIndex = 1;
            this.btRozlacz.Text = "Rozłącz";
            this.btRozlacz.UseVisualStyleBackColor = true;
            this.btRozlacz.Click += new System.EventHandler(this.btRozlacz_Click);
            // 
            // btPobierz
            // 
            this.btPobierz.Location = new System.Drawing.Point(29, 458);
            this.btPobierz.Name = "btPobierz";
            this.btPobierz.Size = new System.Drawing.Size(75, 29);
            this.btPobierz.TabIndex = 2;
            this.btPobierz.Text = "Pobierz";
            this.btPobierz.UseVisualStyleBackColor = true;
            this.btPobierz.Click += new System.EventHandler(this.btPobierz_Click);
            // 
            // btWczytaj
            // 
            this.btWczytaj.Location = new System.Drawing.Point(110, 458);
            this.btWczytaj.Name = "btWczytaj";
            this.btWczytaj.Size = new System.Drawing.Size(75, 29);
            this.btWczytaj.TabIndex = 3;
            this.btWczytaj.Text = "Wczytaj";
            this.btWczytaj.UseVisualStyleBackColor = true;
            this.btWczytaj.Click += new System.EventHandler(this.btWczytaj_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cofnij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Odswież";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 493);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(275, 35);
            this.button3.TabIndex = 6;
            this.button3.Text = "Podgląd Logów";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(349, 616);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.ListaPlikow);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btRozlacz);
            this.tabPage1.Controls.Add(this.btPobierz);
            this.tabPage1.Controls.Add(this.btWczytaj);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(341, 587);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.l1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.tb1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(341, 587);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pobieranie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lp,
            this.Nazwa,
            this.Ścieżka});
            this.dataGridView1.Location = new System.Drawing.Point(7, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(318, 497);
            this.dataGridView1.TabIndex = 11;
            // 
            // Lp
            // 
            this.Lp.HeaderText = "Lp";
            this.Lp.Name = "Lp";
            this.Lp.ReadOnly = true;
            // 
            // Nazwa
            // 
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            // 
            // Ścieżka
            // 
            this.Ścieżka.HeaderText = "Ścieżka";
            this.Ścieżka.Name = "Ścieżka";
            this.Ścieżka.ReadOnly = true;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(18, 46);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(0, 17);
            this.l1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(114, 21);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(177, 22);
            this.progressBar1.TabIndex = 1;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(8, 21);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 22);
            this.tb1.TabIndex = 0;
            // 
            // ClientFTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 616);
            this.Controls.Add(this.tabControl1);
            this.Name = "ClientFTP";
            this.Text = "ClientFTP";
            this.Shown += new System.EventHandler(this.ClientFTP_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListaPlikow;
        private System.Windows.Forms.Button btRozlacz;
        private System.Windows.Forms.Button btPobierz;
        private System.Windows.Forms.Button btWczytaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ścieżka;
    }
}

