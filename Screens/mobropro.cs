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
            PopulateDgv();


        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
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
            Backend.bFileLoaded = false;
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
    }
}
