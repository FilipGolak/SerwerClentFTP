namespace SerwerClentFTP
{
    partial class Logowanie
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
            this.label1 = new System.Windows.Forms.Label();
            this.tblogin = new System.Windows.Forms.TextBox();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btPolacz = new System.Windows.Forms.Button();
            this.tbIpSerwera = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btZamknij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // tblogin
            // 
            this.tblogin.Location = new System.Drawing.Point(104, 42);
            this.tblogin.Name = "tblogin";
            this.tblogin.Size = new System.Drawing.Size(100, 22);
            this.tblogin.TabIndex = 1;
            // 
            // tbHaslo
            // 
            this.tbHaslo.Location = new System.Drawing.Point(104, 70);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.PasswordChar = '*';
            this.tbHaslo.Size = new System.Drawing.Size(100, 22);
            this.tbHaslo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasło";
            // 
            // btPolacz
            // 
            this.btPolacz.Location = new System.Drawing.Point(25, 109);
            this.btPolacz.Name = "btPolacz";
            this.btPolacz.Size = new System.Drawing.Size(179, 28);
            this.btPolacz.TabIndex = 4;
            this.btPolacz.Text = "Połącz";
            this.btPolacz.UseVisualStyleBackColor = true;
            this.btPolacz.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbIpSerwera
            // 
            this.tbIpSerwera.Location = new System.Drawing.Point(104, 14);
            this.tbIpSerwera.Name = "tbIpSerwera";
            this.tbIpSerwera.Size = new System.Drawing.Size(100, 22);
            this.tbIpSerwera.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP Serwera";
            // 
            // btZamknij
            // 
            this.btZamknij.Location = new System.Drawing.Point(25, 143);
            this.btZamknij.Name = "btZamknij";
            this.btZamknij.Size = new System.Drawing.Size(179, 28);
            this.btZamknij.TabIndex = 7;
            this.btZamknij.Text = "Zamknij";
            this.btZamknij.UseVisualStyleBackColor = true;
            this.btZamknij.Click += new System.EventHandler(this.btZamknij_Click);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 179);
            this.Controls.Add(this.btZamknij);
            this.Controls.Add(this.tbIpSerwera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btPolacz);
            this.Controls.Add(this.tbHaslo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tblogin);
            this.Controls.Add(this.label1);
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Logowanie_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tblogin;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPolacz;
        private System.Windows.Forms.TextBox tbIpSerwera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btZamknij;
    }
}