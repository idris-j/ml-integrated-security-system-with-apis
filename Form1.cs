using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace File_Security_System
{
    public partial class Form1 : Form
    {
        //private string currentUser = Environment.UserName;
        //private string userRootFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), Environment.UserName);
        private string filePath = Path.Combine("C:\\", "Users", Environment.UserName);
        private bool isFile = false; //its false for navigation
        private string currentlySelectedItemName;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filePathTextBox.Text = filePath;
            loadFileAndDirectories();
        }
        public void loadFileDetails()
        { 
            string tempFilePath = "";
            webBrowser1.Navigate("");
            FileAttributes fileAttr;
            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "\\" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    fileNameLabel.Text = fileDetails.Name;
                    fileTypeLabel.Text = fileDetails.Extension;

                    fileTypeLabel.Text = fileDetails.Extension;
                    long fileSizeInBytes = fileDetails.Length;
                    double fileSizeInKB = fileSizeInBytes / 1024.0;
                    double fileSizeInMB = fileSizeInKB / 1024.0;

                    if (fileSizeInMB >= 1)
                    {
                        fileSizeLabel.Text = fileSizeInMB.ToString("0.00") + " MB";
                    }
                    else if (fileSizeInKB >= 1)
                    {
                        fileSizeLabel.Text = fileSizeInKB.ToString("0.00") + " KB";
                    }
                    else
                    {
                        fileSizeLabel.Text = fileSizeInBytes.ToString() + " bytes";
                    }

                    fileAttr = File.GetAttributes(tempFilePath);
                    FileInfo file = new FileInfo(tempFilePath);
                    string fileExtension = file.Extension.ToLower();
                    switch (fileExtension)
                    {
                        case ".mp4":
                        case ".avi":
                        case ".mkv":
                            string videoPath = tempFilePath;
                            string html = "<!DOCTYPE html><html><head></head><body>" +
                                          $"<video width=\"100%\" height=\"100%\" controls><source src=\"{videoPath}\" type=\"video/mp4\"></video>" +
                                          "</body></html>";
                            webBrowser1.Navigate(html);
                            break;
                        case ".png":
                        case ".jpg":
                        case ".txt":
                            webBrowser1.Navigate(tempFilePath);
                            webBrowser1.DocumentCompleted += (sender, e) => {
                                webBrowser1.Document.Body.Style = "zoom: " + (webBrowser1.Width / (double)webBrowser1.Document.Body.ScrollRectangle.Width * 100) + "%";
                            };
                            break;
                        default:
                            webBrowser1.DocumentText = "<html><body><p>Unable to preview file: </p></body></html>";
                            break;
                    }
                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);


                }
            }
            catch (Exception e)
            {

            }

        }
        public void loadVideo()
        {

        }
        public void loadFileAndDirectories() 
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr;
            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "\\" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    fileNameLabel.Text = fileDetails.Name;
                    fileTypeLabel.Text = fileDetails.Extension;

                    fileTypeLabel.Text = fileDetails.Extension;
                    long fileSizeInBytes = fileDetails.Length;
                    double fileSizeInKB = fileSizeInBytes / 1024.0;
                    double fileSizeInMB = fileSizeInKB / 1024.0;

                    if (fileSizeInMB >= 1)
                    {
                        fileSizeLabel.Text = fileSizeInMB.ToString("0.00") + " MB";
                    }
                    else if (fileSizeInKB >= 1)
                    {
                        fileSizeLabel.Text = fileSizeInKB.ToString("0.00") + " KB";
                    }
                    else
                    {
                        fileSizeLabel.Text = fileSizeInBytes.ToString() + " bytes";
                    }

                    fileAttr = File.GetAttributes(tempFilePath);
                    FileInfo file = new FileInfo(tempFilePath);
                    string fileExtension = file.Extension.ToLower();
                    switch (fileExtension)
                    {
                        case ".mp4":
                        case ".avi":
                        case ".mkv":
                        case ".txt":
                        case ".jpg":
                        case ".png":
                            string videoPath = tempFilePath;

                            var fileViewerForm = new fileViewerForm(videoPath);
                            fileViewerForm.Show();
                            break;
                        default:
                            Process.Start(tempFilePath);
                            break;
                    }
                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);
                    

                }
                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles(); //get all files
                    DirectoryInfo[] dirs = fileList.GetDirectories(); //get all directories
                    string fileExtension = "";
                    listView1.Items.Clear();
                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToLower();
                        switch (fileExtension)
                        {
                            case ".mp3":
                            case ".mp2":
                                listView1.Items.Add(files[i].Name, 2);
                                break;
                            case ".exe":
                            case ".com":
                                listView1.Items.Add(files[i].Name, 9);
                                break;
                            case ".mp4":
                            case ".avi":
                            case ".mkv":
                                listView1.Items.Add(files[i].Name, 6);
                                break;
                            case ".pdf":
                                listView1.Items.Add(files[i].Name, 3);
                                break;
                            case ".doc":
                            case ".docx":
                                listView1.Items.Add(files[i].Name, 0);
                                break;
                            case ".png":
                            case ".jpg":
                            case ".jpeg":
                                listView1.Items.Add(files[i].Name, 4);
                                break;
                            case ".txt":
                            case ".xml":
                            case ".ini":
                            case ".json":
                                listView1.Items.Add(files[i].Name, 10);
                                break;

                            default:
                                listView1.Items.Add(files[i].Name, 8);
                                break;
                        }

                    }
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView1.Items.Add(dirs[i].Name, 1);

                    }
                }
                else
                {
                    fileNameLabel.Text = this.currentlySelectedItemName;
                }
            }
            catch (Exception e)
            { 
            }
        }

        public void loadDetailsAction()
        {
            //removeBackSlash();
            //filePath = filePathTextBox.Text;
            loadFileDetails();
            //isFile = false;
        }
        public void loadButonAction() 
        {
            removeBackSlash();
            filePath = filePathTextBox.Text;
            loadFileAndDirectories();
            isFile = false;

        }
        //remove additional and inadvertently added backslash
        public void removeBackSlash()
        {
            string path = filePathTextBox.Text;
            if (path.LastIndexOf ("\\") == path.Length - 1)
            {
                filePathTextBox.Text = path.Substring(0, path.Length - 1);
            }
        }
        public void goBack() 
        {
            try
            {
                removeBackSlash();
                string path = filePathTextBox.Text;
                path = path.Substring(0, path.LastIndexOf("\\"));
                this.isFile = false;
                filePathTextBox.Text = path;
                removeBackSlash();
            }
            catch (Exception e)
            { 
            
            }
        }
        private void goButton_Click(object sender, EventArgs e)
        {
            loadButonAction();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;
            FileAttributes fileAttr = File.GetAttributes(filePath + "\\" + currentlySelectedItemName);
            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                filePathTextBox.Text = filePath + "\\" + currentlySelectedItemName;
            }
            else
            {
                isFile = true;

            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButonAction();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            goBack();
            loadButonAction();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            loadDetailsAction();
        }
    }
}
