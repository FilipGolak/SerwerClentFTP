using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerwerClentFTP
{
    class FtpClient
    {
        private string host;
        private string userName;
        private string password;
        private string ftpDirectory;
        private bool downloadCompleted;
        private bool uploadCompleted;

        public FtpClient(string host, string userName, string password)
        {
            this.host = host;
            this.userName = userName;
            this.password = password;
            ftpDirectory = "ftp://" + this.host;
        }

        public static void GetDirectoriesList(string host, ListBox ListaPlikow, string sciezka)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri("ftp://" + host + sciezka));
            request.UseBinary = true;
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.Credentials = new NetworkCredential("", "");

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            string line = reader.ReadLine();
            
            while (line != null)
            {
                //... //do something with line
                ListaPlikow.Items.Add(line);
                line = reader.ReadLine();
                
            }
            
            reader.Close();
            response.Close();
            zapislogow("Pobranie listy Plików");
        }

        public static void poberanie(string sciezka, string sciezkazapis)
        {
            WebClient client = new WebClient();
            client.Credentials = new NetworkCredential("", "");
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
            //client.DownloadFileAsync(new Uri(sciezka), sciezkazapis);
            //zapislogow("Pobranie pliku " + "X");
        }

        private static void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Pobieranie ukończone");
        }

        private static void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            
        }

        public static void wczytanie(string sciezkaftp, string sciezkawczyt)
        {
            WebClient client = new WebClient();
            client.Credentials = new NetworkCredential("", "");
            client.UploadFile(sciezkaftp, sciezkawczyt);
            zapislogow("Wzczytanie pliku " + sciezkaftp);
            MessageBox.Show("Wczytano plik");
        }

        public static void zapislogow(string log)
        {
            string katalog = Directory.GetCurrentDirectory();
            File.AppendAllText(@"" + katalog + "\\Log.txt", DateTime.Today.ToString().Substring(0,10) + " "+ log+ Environment.NewLine);
        }
    }
}
