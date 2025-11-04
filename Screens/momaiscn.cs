using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Organiser
{
    public partial class momaiscn : Form
    {
        public List<DataGridView> Grids = new List<DataGridView>();
        String currentID = "";
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
                DGVContain.Size = new Size(Width, this.Size.Height);
                DGVContain.Location = new Point(XLoc, YLoc);
                DGVContain.MaximumSize = DGVContain.Size;
                DGVContain.AutoScroll = true;
                DGVContain.AutoSize = true;
                DGVContain.VerticalScroll.Visible = true;
                DGVContain.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);

                DGVContain.Name = "ContainerforDGV";
                foreach (Categories c in Backend.lsCategories)
                {
                    DataTable table = new DataTable("Jobs");
                    table.Columns.Add("Job ID");
                    table.Columns.Add("Job Name");
                    table.Columns.Add("Job Type");
                    table.Columns.Add("Deadline");
                    table.Columns.Add("Until Deadline");

                    Label tableHead = new Label();
                    tableHead.Text = c.getCategoryName();
                    tableHead.Location = new Point(XLoc, YLoc);
                    tableHead.Size = new Size(DGVContain.Size.Width - 20, 20);
                    tableHead.TextAlign = ContentAlignment.MiddleCenter;

                    YLoc = YLoc + 30;
                    DataGridView Cate = new DataGridView();
                    Backend.SetDGV(Cate, c.getCategoryName() + c.getCategoryID().ToString(), c.getColor(), new Point(XLoc, YLoc), new Size(DGVContain.Size.Width - 20, Height));

                    Cate.CellDoubleClick += new DataGridViewCellEventHandler(this.Grid_MouseDoubleClick);
                    Cate.CellClick += new DataGridViewCellEventHandler(this.Grid_MouseClick);

                    foreach (JobType JT in Backend.lsJobTypes)
                    {
                        if (JT.getJobTypeCate() == c)
                        {
                            foreach (Job J in Backend.lsJobs)
                            {
                                if (J.getJobType() == JT)
                                {
                                    table.Rows.Add(J.getJobID(), J.getJobName(),
                                                   J.getJobType().getJobTypeName(), J.getDeadline().ToShortDateString(), (J.getDeadline() - DateTime.Now).Days + " Days");
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
        private void DropProject()
        {
            foreach (Categories c in Backend.lsCategories)
            {
                DataGridView d = this.Controls.Find(c.getCategoryName() + c.getCategoryID().ToString(), true).FirstOrDefault() as DataGridView;
                d.Dispose();
            }
            Backend.ClearLists();
            Backend.lsPros.Clear();
            Backend.bFileLoaded = false;
            currentID = "";
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
            btnViewJob.Visible = Backend.bFileLoaded;
            btnUpdateJob.Visible = Backend.bFileLoaded;
            btnDeleteJob.Visible = Backend.bFileLoaded;
            if(currentID.Length == 0)
            {
                btnDeleteJob.Enabled = false;
                btnUpdateJob.Enabled = false;
                btnViewJob.Enabled = false;
            }
            saveToolStripMenuItem.Enabled = Backend.bFileLoaded;
            closeProjectToolStripMenuItem.Enabled = Backend.bFileLoaded;
            tsmEdit.Enabled = Backend.bFileLoaded;
            TsmOps.Enabled = Backend.bFileLoaded;
        }
        private void jobMod(string Action, int ID = 0)
        {
            Screens.monewjob open = new Screens.monewjob(Action, null, ID);
            open.ShowDialog();
            Backend.Save();
            startComponents();
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

        protected void Grid_MouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String ID = (sender as DataGridView).Rows[e.RowIndex].Cells[0].Value.ToString();
            try
            {
                jobMod("Update",Int32.Parse(ID));
            }
            catch (FormatException)
            {

            }
        }
        protected void Grid_MouseClick(object sender, DataGridViewCellEventArgs e)
        {
            currentID = (sender as DataGridView).Rows[e.RowIndex].Cells[0].Value.ToString();
            Console.WriteLine((sender as DataGridView).Rows[e.RowIndex].Cells[0].Value.ToString());
            if (currentID.Length > 0)
            {
                btnDeleteJob.Enabled = true;
                btnViewJob.Enabled = true;
                btnUpdateJob.Enabled = true;
            }


        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            jobMod("New");
        }
        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Do you want to delete this Job? This cannot be undone",
                                      "Delete?", MessageBoxButtons.YesNo);

            if (choice == DialogResult.Yes)
            {
                Job toRemove = Backend.findJob(Int32.Parse(currentID));
                Backend.lsJobs.Remove(toRemove);
                currentID = "";
                startComponents(); //This needs improvement, we shouldn't need to recreate all dgv on deletion
            }
        }
        private void btnUpdateJob_Click(object sender, EventArgs e)
        {
            Screens.monewjob open = new Screens.monewjob("Update", null, Int32.Parse(currentID));
            open.ShowDialog();
            startComponents();
        }
        private void btnViewJob_Click(object sender, EventArgs e)
        {
            jobMod("View", Int32.Parse(currentID));
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
            if(Backend.bFileLoaded)
            {
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

            Screens.mobropro open = new Screens.mobropro();
            open.ShowDialog();
            startComponents();
        }
        private void closeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Backend.bFileLoaded)
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
        private void createBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Backend.bFileLoaded)
            {

            }
            else
            {
                Backend.createDialog("No Project Loaded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
