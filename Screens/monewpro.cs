using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if(tbProjectDir.Text == "")
            {
                Backend.createDialog("Please Select a Directory", "Missing Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(tbProjectName.Text == "")
            {
                Backend.createDialog("Please Enter a Project Name", "Missing Project Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
    }
}
