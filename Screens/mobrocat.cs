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
    public partial class mobrocat : Form
    {
        public String Action;
        public mobrocat(String action = null)
        {
            this.Action = action;
            InitializeComponent();
            if (Action == "Start")
            {
                btnNext.Visible = true;
                Backend.ClearLists();
                Categories OnGoing = new Categories(1, "Ongoing", Color.Red);
                Categories Complete = new Categories(2, "Complete", Color.Green);
                Categories New = new Categories(3, "New", Color.Yellow);

                Backend.lsCategories.Add(OnGoing);
                Backend.lsCategories.Add(Complete);
                Backend.lsCategories.Add(New);
            }
            Populatedgv();
            LoadColours();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadColours()
        {

        }

        private void Populatedgv()
        {
            DataTable table = new DataTable("Categories");
            table.Columns.Add("Category ID");
            table.Columns.Add("Category Name");
            table.Columns.Add("Colour");

            foreach(Categories c in Backend.lsCategories)
            {
                table.Rows.Add(c.getCategoryID(), c.getCategoryName(), c.getColor());
                
            }

            dgvCateView.DataSource = table;
        }

        private void btnNewCate_Click(object sender, EventArgs e)
        {
            Screens.monewcat newCate = new monewcat("New", 0);
            newCate.ShowDialog();
            Populatedgv();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dgvCateView.SelectedRows.Count > 0)
            {
                Screens.monewcat Update = new monewcat("Update", getRowID());
                Update.ShowDialog();
            }
            Populatedgv();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Do you want to delete this Category?","Delete?", MessageBoxButtons.YesNo);

            if (choice == DialogResult.Yes) {
                Backend.lsCategories.Remove(Backend.findCate(getRowID()));
                Populatedgv();
            } 
        }

        private int getRowID()
        {
            if (dgvCateView.SelectedRows.Count > 0)
            {
                return Int16.Parse(dgvCateView.SelectedRows[0].Cells["Category ID"].Value.ToString());
            }

            return 0;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(Action == "Start")
            {
                Backend.ClearLists();
            }
            this.Dispose();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            mobrouni NewUni = new mobrouni("Start");
            NewUni.ShowDialog();

            if (Backend.bFileLoaded)
                this.Dispose();
        }
    }
}
