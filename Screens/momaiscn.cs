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
            int YLoc = btnAddJob.Location.Y + 50;
            int Width = this.Size.Width - 60;
            int Height = 200;

            tsmEdit.Enabled = Backend.bFileLoaded;
            tsmSec.Enabled = Backend.bFileLoaded;
            btnAddJob.Visible = Backend.bFileLoaded;


            if (Backend.bFileLoaded)
            {
                foreach (Categories c in Backend.lsCategories)
                {
                    DataTable table = new DataTable("Jobs");
                    table.Columns.Add("Job ID");
                    table.Columns.Add("Job Name");
                    table.Columns.Add("Job Desc");
                    table.Columns.Add("Raised By");
                    table.Columns.Add("Job Type");
                    table.Columns.Add("Client Name");
                    table.Columns.Add("Client Contact");
                    table.Columns.Add("Attachment");

                    DataGridView Cate = new DataGridView();
                    Cate.Location = new Point(XLoc, YLoc);
                    Cate.Size = new Size(Width, Height);
                    Cate.BackgroundColor = c.getColor();
                    Cate.Name = c.getCategoryName() + c.getCategoryID().ToString();
                    Cate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    Cate.CellDoubleClick += new DataGridViewCellEventHandler(this.Grid_MouseDoubleClick);
                    Cate.ReadOnly = true;
                    Cate.Anchor = (AnchorStyles.Left | AnchorStyles.Right);

                    foreach (JobType JT in Backend.lsJobTypes)
                    {
                        if (JT.getJobTypeCate() == c)
                        {
                            foreach (Job J in Backend.lsJobs)
                            {
                                if (J.GetJobType() == JT)
                                {
                                    table.Rows.Add(J.getJobID(), J.getJobName(), J.getJobDesc(), J.getRaisedBy(),
                                                   J.GetJobType().getJobTypeName(), J.getClientName(), J.getClientContact(), J.getAttachment());
                                }
                            }
                        }
                    }

                    Cate.DataSource = table;
                    
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
            Backend.ClearLists();
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
            Backend.Save();
            Refreshdgv();
        }
        protected void Grid_MouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String ID = (sender as DataGridView).Rows[e.RowIndex].Cells[0].Value.ToString();
            Screens.monewjob open = new Screens.monewjob("Update",null,Int32.Parse(ID));
            open.ShowDialog();
            Refreshdgv();
        }
        private DialogResult createDialog(String Message, String Type, MessageBoxButtons buts, MessageBoxIcon icon)
        {
            DialogResult res = MessageBox.Show(Message, Type, buts, icon);
            return res;
        }
    }
}
