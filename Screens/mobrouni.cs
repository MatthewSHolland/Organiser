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
    public partial class mobrouni : Form
    {
        public String Action;
        public mobrouni(String action = null)
        {
            this.Action = action;
            InitializeComponent();

            if (Action == "Start")
            {
                btnNext.Visible = true;
            }

            Populatedgv();


        }

        private void Populatedgv()
        {
            DataTable table = new DataTable("Categories");
            table.Columns.Add("Job Type ID");
            table.Columns.Add("Job Type Name");
            table.Columns.Add("Linked Category");
            if(Backend.lsJobTypes.Any())
            {
                foreach (JobType j in Backend.lsJobTypes)
                {
                    table.Rows.Add(j.getJobTypeID(), j.getJobTypeName(), j.getJobTypeCate().getCategoryName());

                    dgvUnitView.DataSource = table;
                }
            }
        }
        private int getRowID()
        {
            if (dgvUnitView.SelectedRows.Count > 0)
            {
                return Int16.Parse(dgvUnitView.SelectedRows[0].Cells["Job Type ID"].Value.ToString());
            }
            return 1;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (Action == "Start")
            {
                Backend.lsJobTypes.Clear();
            }
            this.Dispose();     
        }

        private void btnNewUnit_Click(object sender, EventArgs e)
        {
            monewuni NewUnit = new monewuni("New");
            NewUnit.ShowDialog();

            Populatedgv();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUnitView.SelectedRows.Count > 0)
            {
                Screens.monewuni Update = new monewuni("Update", getRowID());
                Update.ShowDialog();
            }
            Populatedgv();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool lFlagCate = false;
            bool lFlagJob = true;
            DialogResult choice = MessageBox.Show("Do you want to delete this Job Type?", "Delete?",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            JobType toRemove = Backend.findJobType(getRowID());
            if (choice == DialogResult.Yes)
            {
                foreach (JobType j in Backend.lsJobTypes)
                {
                    if (j == toRemove) { continue; }
                    else if (j.getJobTypeCate() == toRemove.getJobTypeCate())
                    {
                        lFlagCate = true;
                    }
                }
                foreach (Job job in Backend.lsJobs)
                {
                    if (job.GetJobType() == toRemove)
                    {
                        lFlagJob = false;
                    }
                }
                if (lFlagCate && lFlagJob)
                {
                    Backend.lsJobTypes.Remove(Backend.findJobType(getRowID()));
                    Populatedgv();
                }
                else if (!lFlagCate)
                {
                    MessageBox.Show("Cannot delete! Would leave a category without a unit",
                  "Error on Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!lFlagJob)
                {
                    MessageBox.Show("Cannot delete! Currently being used by a Job",
                    "Error on Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            Backend.SaveSystemFiles();
            Backend.bFileLoaded = true;
            Backend.lsPros.Clear();
            Backend.Save();
            this.Dispose();

        }
    }
}
