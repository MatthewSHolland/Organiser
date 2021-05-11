using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            int YLoc = btnAddJob.Location.Y + 60;
            int Width = this.Size.Width - 60;
            int Height = 200;
            clearDataGridControls();
            setControlState();

            if (Backend.bFileLoaded)
            {
                FlowLayoutPanel DGVContain = new FlowLayoutPanel();
                DGVContain.Size = new Size(Width,this.Size.Height);
                DGVContain.Location = new Point(XLoc, YLoc);
                DGVContain.MaximumSize = DGVContain.Size;
                DGVContain.AutoScroll = true;
                DGVContain.AutoSize = true;
                DGVContain.VerticalScroll.Visible = true;
                DGVContain.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);

                DGVContain.Name = "ContainerforDGV";
                foreach (Categories c in Backend.lsCategories)
                {
                    DataTable table = new DataTable("Jobs");
                    table.Columns.Add("Job ID");
                    table.Columns.Add("Job Name");
                    table.Columns.Add("Job Desc");
                    table.Columns.Add("Job Type");
                    table.Columns.Add("Attachment");
                    Label tableHead = new Label();
                    tableHead.Text = c.getCategoryName();
                    tableHead.Location = new Point(XLoc, YLoc);
                    tableHead.Size = new Size(DGVContain.Size.Width - 20, 20);
                    tableHead.TextAlign = ContentAlignment.MiddleCenter;
                    YLoc = YLoc + 30;
                    DataGridView Cate = new DataGridView();
                    Backend.SetDGV(Cate, c.getCategoryName() + c.getCategoryID().ToString(), c.getColor(), new Point(XLoc, YLoc), new Size(DGVContain.Size.Width - 20, Height));
                    Cate.CellDoubleClick += new DataGridViewCellEventHandler(this.Grid_MouseDoubleClick);

                    foreach (JobType JT in Backend.lsJobTypes)
                    {
                        if (JT.getJobTypeCate() == c)
                        {
                            foreach (Job J in Backend.lsJobs)
                            {
                                if (J.GetJobType() == JT)
                                {
                                    table.Rows.Add(J.getJobID(), J.getJobName(), J.getJobDesc(),
                                                   J.GetJobType().getJobTypeName(), J.getAttachment());
                                }
                            }
                        }
                    }

                    Cate.DataSource = table;
                    DGVContain.Controls.Add(tableHead);
                    DGVContain.Controls.Add(Cate);

                    YLoc = YLoc + Height + 20;
                }
                this.Controls.Add(DGVContain);
            }
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
            Screens.mobropro open = new Screens.mobropro();
            open.ShowDialog();
            startComponents();
        }
        private void closeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!Backend.bFileLoaded)
            {
                Backend.createDialog("No Project Loaded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = Backend.createDialog("Do you want to save before closing?", "Save before exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        private void momaiscn_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (Backend.bFileLoaded)
            {
                DialogResult res = Backend.createDialog("Do you want to save before closing?", "Save before exit?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
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
            startComponents();
        }
        protected void Grid_MouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String ID = (sender as DataGridView).Rows[e.RowIndex].Cells[0].Value.ToString();
            Screens.monewjob open = new Screens.monewjob("Update",null,Int32.Parse(ID));
            open.ShowDialog();
            startComponents();
        }

        public void clearDataGridControls()
        {
            foreach (var cntrl in Controls)
            {
                if (cntrl is Panel)
                {
                    Panel d = cntrl as Panel;
                    d.Dispose();
                }
            }
        }
        public void setControlState()
        {
            btnAddJob.Visible = Backend.bFileLoaded;
            saveToolStripMenuItem.Enabled = Backend.bFileLoaded;
            closeProjectToolStripMenuItem.Enabled = Backend.bFileLoaded;
            tsmEdit.Enabled = Backend.bFileLoaded;
            TsmOps.Enabled = Backend.bFileLoaded;
        }
        private void createBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Backend.bFileLoaded)
            {

            }
            else
            {
                Backend.createDialog("No Project Loaded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
