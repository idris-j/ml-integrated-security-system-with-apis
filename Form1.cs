using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    fileAttr = File.GetAttributes(tempFilePath);
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
                    listView1.Items.Clear();
                    for (int i = 0; i < files.Length; i++)
                    {
                        listView1.Items.Add(files[i].Name, 8);

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

        public void loadButonAction() 
        {
            filePath = filePathTextBox.Text;
            loadFileAndDirectories();
            isFile = false;

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
    }
}
