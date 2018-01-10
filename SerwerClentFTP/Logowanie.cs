using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerwerClentFTP
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
            tbIpSerwera.Text = "127.0.0.1";
            tblogin.Text = "fgolak";
            tbHaslo.Text = "1234";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("ftp://" + tbIpSerwera.Text);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            request.Credentials = new NetworkCredential("", "");
            using (var resp = (FtpWebResponse)request.GetResponse())
            {
                string a = resp.StatusCode.ToString();
            }
            FtpClient.zapislogow("Polaczono " + tblogin.Text);
            ClientFTP.polaczono = true;
            this.Close();
            
        }

        private void btZamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logowanie_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ClientFTP.polaczono == false)
            {
                Application.Exit();
            }
        }
    }
}
