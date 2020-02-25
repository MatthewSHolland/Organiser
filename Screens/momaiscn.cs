using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organiser
{
    public partial class momaiscn : Form
    {
        public List<DataGridView> Grids = new List<DataGridView>();
        public momaiscn()
        {
            InitializeComponent();
            startComponents();
            
        }


        public void startComponents()
        {
            int XLoc = 20;
            int YLoc = btnAddJob.Location.Y +50;
            int Width = this.Size.Width - 60;
            int Height = 150;

            tsmEdit.Enabled = Backend.bFileLoaded;
            tsmSec.Enabled = Backend.bFileLoaded;
            btnAddJob.Visible = Backend.bFileLoaded;
            if (Backend.bFileLoaded) {
                foreach (Categories c in Backend.lsCategories)
                {
                    DataGridView Cate = new DataGridView();
                    Cate.Location = new Point(XLoc, YLoc);
                    Cate.Size = new Size(Width, Height);
                    Cate.BackgroundColor = c.getColor();
                    Cate.Name = c.getCategoryName() + c.getCategoryID().ToString();
                    
                    this.Controls.Add(Cate);
                    YLoc = YLoc + Height + 20;
                }
            }
        }

        public void Refreshdgv()
        {
            foreach (Categories c in Backend.lsCategories)
            {

                DataGridView d = this.Controls.Find(c.getCategoryName() + c.getCategoryID().ToString(), true).FirstOrDefault() as DataGridView;
                if(d != null)
                {
                    d.Dispose();
                }
            }
            startComponents();
        }
        private void sercurityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backend.ReadSystemFiles();
            Screens.monewpro open = new Screens.monewpro();
            open.ShowDialog();

            startComponents();
        }

        private void catagoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Screens.mobrocat open = new Screens.mobrocat();
            open.ShowDialog();
            Refreshdgv();
        }

        private void tRUEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fALSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backend.bFileLoaded = false;
            startComponents();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backend.Save();
        }

        private void jobTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Screens.mobrouni open = new Screens.mobrouni();
            open.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backend.ReadSystemFiles();
            Screens.mobropro open = new Screens.mobropro();
            open.ShowDialog();
            startComponents();

        }

        private void closeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!Backend.bFileLoaded)
            {
                createDialog("No Project Loaded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = createDialog("Do you want to save before closing?", "Save before exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Backend.Save();
                DropProject();
            }
            if (res == DialogResult.No)
            {
                DropProject();
            }
        }

        private void DropProject()
        {   foreach (Categories c in Backend.lsCategories)
            {
                DataGridView d = this.Controls.Find(c.getCategoryName() + c.getCategoryID().ToString(), true).FirstOrDefault() as DataGridView;
                d.Dispose();
            }
            Backend.ClearLists();
            Backend.lsPros.Clear();
            Backend.bFileLoaded = false;
            startComponents();
        }

        

        private DialogResult createDialog(String Message, String Type, MessageBoxButtons buts, MessageBoxIcon icon)
        {
            DialogResult res = MessageBox.Show(Message, Type, buts, icon);
            return res;
        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Screens.mobrousr open = new Screens.mobrousr();
            open.ShowDialog();
        }

        private void securityLevelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Screens.mobrosec open = new Screens.mobrosec();
            open.ShowDialog();
        }

        private void momaiscn_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (Backend.bFileLoaded)
            {
                DialogResult res = createDialog("Do you want to save before closing?", "Save before exit?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Backend.Save();
                }

                if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            Screens.monewjob open = new Screens.monewjob("new");
            open.ShowDialog(); 
        }
    }
}
