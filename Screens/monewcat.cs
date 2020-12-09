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
    public partial class monewcat : Form
    {
        private String Action;
        public Categories CateUpd;
        private Color color = Color.White;
        public monewcat(String action, int ID)
        {
            
            this.Action = action;

            InitializeComponent();
            if (Action == "Update")
            {
                CateUpd = Backend.findCate(ID);
                tbCateName.Text = CateUpd.getCategoryName().ToString();
                color = CateUpd.getColor();
                tbColorPrev.BackColor = color;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tbCateName.Text == "")
            {
                MessageBox.Show("Please Enter a Category Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(Action == "New")
            {
                Categories cAdd = new Categories(Backend.getCateID(), tbCateName.Text, color);
                Backend.lsCategories.Add(cAdd);
            }
            if(Action == "Update")
            {
                CateUpd.setCategoryName(tbCateName.Text);
                CateUpd.setColor(color);
            }
            this.Dispose();
        }
        private void btnColour_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.SolidColorOnly = true;
            cd.ShowDialog();
            color = cd.Color;
            Console.WriteLine(cd.Color.ToArgb());
            Console.WriteLine(Color.FromArgb(cd.Color.ToArgb()));
            tbColorPrev.BackColor = color;
        }
    }
}
