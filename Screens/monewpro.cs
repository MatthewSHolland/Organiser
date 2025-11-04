using System;
using System.IO;
using System.Windows.Forms;

namespace Organiser.Screens
{
    public partial class monewpro : Form
    {
        public String sFilePath;
        public String sFileName;
        public monewpro()
        {
            InitializeComponent();
        }

        private void btnSelDir_Click(object sender, EventArgs e)
        {
            findFileLocation();
        }

        public String findFileLocation()
        {

            using (FolderBrowserDialog fbdNew = new FolderBrowserDialog())
            {


                DialogResult drRes = fbdNew.ShowDialog();

                if (drRes == DialogResult.OK && !String.IsNullOrWhiteSpace(fbdNew.SelectedPath))
                {
                    sFilePath = fbdNew.SelectedPath;
                    tbProjectDir.Text = sFilePath;
                }

            }

            return "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Backend.lsPros.Clear();
            this.Dispose();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (fileNameCheck(tbProjectName.Text, tbProjectDir.Text) == false) { return; }
            Screens.mobrocat sOpen = new Screens.mobrocat("Start");
            sFileName = tbProjectName.Text;

            Project New = new Project(sFileName, sFilePath);
            Backend.lsPros.Add(New);
            Backend.sFilePath = sFilePath;
            Backend.sFileName = sFileName;

            sOpen.ShowDialog();


            if (Backend.bFileLoaded)
                this.Dispose();
        }
        private void monewpro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Backend.lsPros.Clear();
            this.Dispose();
        }

        private bool fileNameCheck(string fileName, string directory)
        {
            if (fileName == null || fileName.Length == 0 || fileName == "")
            {
                Backend.createDialog("Project Name cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                Backend.createDialog("Project Name cannot contain any special characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (directory == "" || directory.Length == 0 || directory == null)
            {
                Backend.createDialog("Select a Directory", "Missing Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (File.Exists(directory + "\\" + fileName + ".xml"))
            {
                Backend.createDialog("This file already exists", "File Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
