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
            Backend.ClearLists();
            Backend.sFileName = Backend.findProject(getRowID()).getProName();
            Backend.sFilePath = Backend.findProject(getRowID()).getProDir();
            Backend.Load();
            this.Dispose();
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
            if (createDialog("Are you sure you want to delete?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString() == "Yes")
            {
                if (createDialog("Remove project files from Disk?", "Remove from Disk?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes") { Choi = true; };
                Backend.Delete(Choi);
            }
            Backend.SaveSystemFiles();
            PopulateDgv();
            this.Refresh(); 
        }

        private DialogResult createDialog(String Message, String Type, MessageBoxButtons buts, MessageBoxIcon icon)
        {
            DialogResult res = MessageBox.Show(Message, Type, buts, icon);
            return res;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void mobropro_Load(object sender, EventArgs e)
        {

        }
    }
}
