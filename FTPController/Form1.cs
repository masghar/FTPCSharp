using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace FTPController
{
    public partial class Form1 : Form
    {
        string host, dir, pass, username, filename,file;
        bool selectedfile = false;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            lstboxFiles.Items.Clear();
            getFileList(host.Trim(), username.Trim(),pass,dir.Trim());
            iTalk_ProgressBar1.Value = 100;
            
        }
        private List<string> getFileList(string FTPAddress, string username, string password,string dir)
        {
            List<string> files = new List<string>();

            try
            {
                string h = "ftp://" + FTPAddress + "/" + dir;
                //Create FTP request
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(h);
                        request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential(username, password);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;


                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);

                while (!reader.EndOfStream)
                {
                    Application.DoEvents();
                    files.Add(reader.ReadLine());
                }

                //Clean-up
                reader.Close();
                responseStream.Close(); //redundant
                response.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return files;

            }



            //If the list was successfully received, display it to the user
            //through a dialog

            if (files.Count != 0)
            {
                foreach (string file in files)
                {
                    lstboxFiles.Items.Add(file);
                }

            }
            return files;
        }
        private void getConfigurations() {

            if (File.Exists("config.xml"))
            {

                XmlDocument doc = new XmlDocument();
                doc.Load(("config.xml"));

                XPathNavigator navigator = doc.CreateNavigator();

                username = GetStringValues("", navigator, "//username").Trim();
                host = GetStringValues("", navigator, "//host").Trim();
                pass = GetStringValues("", navigator, "//password").Trim();
                dir = GetStringValues("", navigator, "//folder").Trim();
                txtHost.Text = host;
                txtpass.Text = pass;
                txtpath.Text = dir;
                txtUsername.Text = username;
            }
            else {
                
                 MessageBox.Show("Unable to Find Configuration file.. Please Create Configuration, From Config Menu");

            //     new XDocument(
            //new XElement("kemuftp", new XElement("host", "www.example.com"), new XElement("username", "uname"), new XElement("password", "p"), new XElement("folder", "directory")
            //)
            //  )
            //.Save("config.xml");


                
            }
            }
        private static string GetStringValues(string description, XPathNavigator navigator, string xpath)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(description);
            XPathNodeIterator bookNodesIterator = navigator.Select(xpath);
            while (bookNodesIterator.MoveNext())
                sb.Append(string.Format("{0} ", bookNodesIterator.Current.Value));
            return sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            getConfigurations();

        }
        public static bool DeleteFilesOnServer(NetworkCredential cred, List<string> lst_strFiles)
        {
            bool blnRetVal = true;

            try
            {
                foreach (string strUri in lst_strFiles)
                {

                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(strUri);
                    request.Credentials = cred;
                    request.Method = WebRequestMethods.Ftp.DeleteFile;
                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    response.Close();
                }
            }
            catch (Exception exc)
            {
                blnRetVal = false;
                MessageBox.Show(exc.Message);
            }

            return blnRetVal;
        }  
        

        private void iTalk_Button_23_Click(object sender, EventArgs e)
        {

            host = txtHost.Text;
            username = txtUsername.Text;
            dir = txtpath.Text;
            pass = txtpass.Text;
            
            File.Delete("config.xml");
         
            new XDocument(
           new XElement("kemuftp", new XElement("host", txtHost.Text), new XElement("username", txtUsername.Text), new XElement("password", txtpass.Text), new XElement("folder", txtpath.Text)
           )
             )
           .Save("config.xml");
            MessageBox.Show("Configurations Saved.");
        }

        private void ambiance_Button_21_Click(object sender, EventArgs e)
        {
            if (lstboxFiles.SelectedItems.Count > 0)
            {
                NetworkCredential nc = new NetworkCredential(username, pass);
                file = lstboxFiles.SelectedItem.ToString();
                List<string> lst_strFile = new List<string>();
                string f = "ftp://" + host + "/" + dir + "/" + file;
                lst_strFile.Add(f);
                DeleteFilesOnServer(nc, lst_strFile);
            }
            else
            {
                MessageBox.Show("No file selected");
            }
        }

        private void iTalk_Button_22_Click(object sender, EventArgs e)
        {
            
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                iTalk_Label1.Text = file;
                filename = file;
                selectedfile = true;
            }

        }

        private void ambiance_Button_22_Click(object sender, EventArgs e)
        {
            if (selectedfile)
            {
                Upload();
                iTalk_ProgressBar2.Value = 100;
            }
            else
            {

                MessageBox.Show("Please select file");
            }
        }

        private void Upload()
        {
            FileInfo fileInf = new FileInfo(filename);
            string uri = "ftp://" + host + "/" +dir+"/"+ fileInf.Name;
            FtpWebRequest reqFTP;

            // Create FtpWebRequest object from the Uri provided
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(
                      "ftp://" + host + "/" +dir+"/"+ fileInf.Name));

            // Provide the WebPermission Credintials
            reqFTP.Credentials = new NetworkCredential(username,
                                                       pass);

            // By default KeepAlive is true, where the control connection is 
            // not closed after a command is executed.
            reqFTP.KeepAlive = false;

            // Specify the command to be executed.
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;

            // Specify the data transfer type.
            reqFTP.UseBinary = true;

            // Notify the server about the size of the uploaded file
            reqFTP.ContentLength = fileInf.Length;

            // The buffer size is set to 2kb
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;

            // Opens a file stream (System.IO.FileStream) to read 
            // the file to be uploaded
            FileStream fs = fileInf.OpenRead();

            try
            {
                // Stream to which the file to be upload is written
                Stream strm = reqFTP.GetRequestStream();

                // Read from the file stream 2kb at a time
                contentLen = fs.Read(buff, 0, buffLength);

                // Till Stream content ends
                while (contentLen != 0)
                {
                    // Write Content from the file stream to the 
                    // FTP Upload Stream
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }

                // Close the file stream and the Request Stream
                strm.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Upload Error");
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string path="";
            string filea="";
            if (lstboxFiles.SelectedItems.Count > 0)
            {
                ///
                DialogResult result = folderBrowserDialog1.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK) // Test result.
                {
                    path = folderBrowserDialog1.SelectedPath;
                    //MessageBox.Show(path);

                }

                ///

                file = lstboxFiles.SelectedItem.ToString();
                filea = "ftp://" + host + "/" + dir + "/" + file;
                DownloadFile(username, pass, filea, path);
            }
            else
            {

                MessageBox.Show("No file Selected");
            }

          
        }
        private void DownloadFile(string userName, string password, string ftpSourceFilePath, string localDestinationFilePath)
        {
            int bytesRead = 0;
            byte[] buffer = new byte[2048];

            FtpWebRequest request = CreateFtpWebRequest(ftpSourceFilePath, userName, password, true);
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            Stream reader = request.GetResponse().GetResponseStream();
            FileStream fileStream = new FileStream(localDestinationFilePath, FileMode.Create);

            while (true)
            {
                bytesRead = reader.Read(buffer, 0, buffer.Length);

                if (bytesRead == 0)
                    break;

                fileStream.Write(buffer, 0, bytesRead);
            }
            fileStream.Close();
        }
        private FtpWebRequest CreateFtpWebRequest(string ftpDirectoryPath, string userName, string password, bool keepAlive = false)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(ftpDirectoryPath));

            //Set proxy to null. Under current configuration if this option is not set then the proxy that is used will get an html response from the web content gateway (firewall monitoring system)
            request.Proxy = null;

            request.UsePassive = true;
            request.UseBinary = true;
            request.KeepAlive = keepAlive;

            request.Credentials = new NetworkCredential(userName, password);

            return request;
        }
        
    }
}
