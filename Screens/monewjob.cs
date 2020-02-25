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
    public partial class monewjob : Form
    {
        String Action;
        Categories C;
        public monewjob(String action = null, Categories c = null) 
        {
            this.Action = action;
            this.C = c;
            InitializeComponent();
            StartCate();
        }

        public void StartCate()
        {
            foreach (Categories cate in Backend.lsCategories)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = cate.getCategoryName();
                item.Value = cate.getCategoryID();



                cbCategory.Items.Add(item);
            }
            cbCategory.SelectedIndex = 0;
            StartType();
        }

        public void StartType()
        {
            cbJobType.Items.Clear();
            int IDpull = Int16.Parse((cbCategory.SelectedItem as ComboboxItem).Value.ToString());
            Categories cates = Backend.findCate(IDpull);

            foreach (JobType j in Backend.lsJobTypes)
            {
                if (j.getJobTypeCate().getCategoryID() == cates.getCategoryID())
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = j.getJobTypeName();
                    item.Value = j.getJobTypeID();
                    cbJobType.Items.Add(item);
                    cbJobType.SelectedIndex = 0;

                }
            }
            
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

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartType();
        }
    }
}
