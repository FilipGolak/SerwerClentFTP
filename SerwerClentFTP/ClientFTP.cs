using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerwerClentFTP
{
    public partial class ClientFTP : Form
    {
        public string sciezka = "";
        public static string hosts = "";
        public int ilosc = 1;
        public Thread newThread;
        public bool dostepne = true;
        public string sciezka_ftp = "";
        public string sciezka_zapis = "";
        public static bool polaczono = true;
        public ClientFTP()
        {
            InitializeComponent();
            hosts = "127.0.0.1";

        }

        private void btPobierz_Click(object sender, EventArgs e)
        {
            tb1.Text = string.Empty;
            l1.Text = string.Empty;
            progressBar1.Value = 0;
            label1.Text = string.Empty;

            saveFileDialog1.FileName = ListaPlikow.SelectedItem.ToString();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                l1.Text = saveFileDialog1.FileName;

                if (dostepne == true)
                {
                    dostepne = false;
                    tb1.Text = ListaPlikow.SelectedItem.ToString();
                    sciezka_ftp = "ftp://" + hosts + sciezka + "/" + tb1.Text;
                    sciezka_zapis = l1.Text;
                    newThread = new Thread(funkcja_pobierz);


                    newThread.Start();
                }
                else
                {
                    MessageBox.Show("Proszę czekać");
                }
            }
        }

        private void funkcja_pobierz()
        {
            poberanie(sciezka_ftp, sciezka_zapis);
            dataGridView1.Rows.Add(ilosc, tb1.Text, l1.Text);
            ilosc++;
        }

        public void poberanie(string sciezka, string sciezkazapis)
        {
            WebClient client = new WebClient();
            client.Credentials = new NetworkCredential("", "");
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(Client_DownloadFileCompleted);
            client.DownloadFileAsync(new Uri(sciezka), sciezkazapis);
            FtpClient.zapislogow("Pobranie pliku " + sciezkazapis);
        }

        void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Pobieranie ukończone");
            newThread.Abort();
            dostepne = true;
        }

        void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                progressBar1.Value = e.ProgressPercentage;
                label1.Text = e.ProgressPercentage.ToString() + "%";
            }
            catch (Exception exception)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaPlikow.Items.Clear();
            FtpClient.GetDirectoriesList(hosts, ListaPlikow, sciezka);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sciezka = sciezka.Substring(0, FindCharacter(sciezka));
                ListaPlikow.Items.Clear();
                FtpClient.GetDirectoriesList(hosts, ListaPlikow, sciezka);
            }
            catch (Exception exception)
            {

            }

        }

        static int FindCharacter(string sciezka1)
        {
            for (int i = sciezka1.Length - 1; i > -1; i--)
            {
                string c = sciezka1[i].ToString();
                if (sciezka1[i] == '/' || sciezka1[i] == '\\')
                {
                    string s = new string('/', 0);
                    return i;
                }
            }
            return -1;
        }

        private void ListaPlikow_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (ListaPlikow.SelectedItem.ToString().Substring(ListaPlikow.SelectedItem.ToString().Length - 4, 1) == "." ||
                    ListaPlikow.SelectedItem.ToString().Substring(ListaPlikow.SelectedItem.ToString().Length - 3, 1) == ".")
                {
                    btPobierz_Click(sender, e);
                }
                else
                {
                    sciezka = sciezka + "/" + ListaPlikow.SelectedItem.ToString();
                    ListaPlikow.Items.Clear();
                    FtpClient.GetDirectoriesList(hosts, ListaPlikow, sciezka);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Wystąpił problem, spróbuj ponownie");
            }


        }

        private void btWczytaj_Click(object sender, EventArgs e)
        {
            string FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
            }
            string nazwaPliku = FileName.Substring(FindCharacter(FileName) + 1);
            FtpClient.wczytanie("ftp://" + hosts + "/" + nazwaPliku, FileName);

            ListaPlikow.Items.Clear();
            FtpClient.GetDirectoriesList(hosts, ListaPlikow, sciezka);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string katalog = Directory.GetCurrentDirectory();
            Process process = new Process();
            process.StartInfo.FileName = @"" + katalog + "\\Log.txt";
            process.Start();
        }

        private void btRozlacz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClientFTP_Shown(object sender, EventArgs e)
        {
            //Logowanie Logowanie = new Logowanie();
            //Logowanie.Show();
            //button2_Click(sender, e);
        }
    }
}
