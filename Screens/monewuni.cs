using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organiser.Screens
{
    
    public partial class monewuni : Form
    {
        private String Action;
        private JobType JBT;
        public monewuni(String action, int ID = 0)
        {
            this.Action = action;
            InitializeComponent();

            if (Action == "New")
            {
                this.Text = "New Job Type";
            }
            else if (Action == "Update")
            {
                this.Text = "Update Job Type";
                JBT = Backend.findJobType(ID);
                tbName.Text = JBT.getJobTypeName();
            }

            PopulateCombo();
        }


        public void PopulateCombo()
        {
            foreach (Categories c in Backend.lsCategories)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = c.getCategoryName();
                item.Value = c.getCategoryID();



                cbCate.Items.Add(item);
            }
            

            cbCate.SelectedIndex = 0;
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public Object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int IDpull = Int16.Parse((cbCate.SelectedItem as ComboboxItem).Value.ToString());
            if (Action == "Update")
            {
                JBT.setJobTypeCate(Backend.findCate(IDpull));
                JBT.setJobTypeName(tbName.Text);
            }
            if (Action == "New")
            {
                JBT = new JobType(Backend.getTypeID(), tbName.Text, Backend.findCate(IDpull));
                Backend.lsJobTypes.Add(JBT);
            }
            this.Dispose();
        }

        private void cbCate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
