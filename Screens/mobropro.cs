using System;
using System.Data;
using System.Windows.Forms;

namespace Organiser.Screens
{
    public partial class mobropro : Form
    {
        public mobropro()
        {
            InitializeComponent();
            Backend.ReadSystemFiles();
            PopulateDgv();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadProject();
        }

        private void PopulateDgv()
        {
            DataTable tb = new DataTable("Projects");
            tb.Columns.Add("Project Name");
            tb.Columns.Add("Project Directory");

            foreach (Project p in Backend.lsPros)
            {
                tb.Rows.Add(p.getProName(), p.getProDir());
            }
            dgvProView.DataSource = tb;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private String getRowID()
        {
            if (dgvProView.SelectedRows.Count > 0)
            {
                return dgvProView.SelectedRows[0].Cells["Project Name"].Value.ToString();
            }

            return null;
        }

        private void mobropro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Backend.lsPros.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Backend.sFileName = Backend.findProject(getRowID()).getProName();
            Backend.sFilePath = Backend.findProject(getRowID()).getProDir();
            Boolean Choi = false;
            if (Backend.createDialog("Are you sure you want to delete?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString() == "Yes")
            {
                if (Backend.createDialog("Remove project files from Disk?", "Remove from Disk?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes") { Choi = true; }
                Backend.Delete(Choi);
            }
            Backend.SaveSystemFiles();
            PopulateDgv();
            this.Refresh();
        }

        private void dgvProView_DoubleClick(object sender, EventArgs e)
        {
            loadProject();
        }

        private void loadProject()
        {
            if (Backend.findProject(getRowID()) != null)
            {
                Backend.ClearLists();
                Backend.sFileName = Backend.findProject(getRowID()).getProName();
                Backend.sFilePath = Backend.findProject(getRowID()).getProDir();
                Backend.Load();
                this.Dispose();
            }
        }
    }
}
