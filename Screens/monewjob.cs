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
        int ID;
        Categories C;
        Job jobUpd;

        public monewjob(String action = null, Categories c = null, int id = 0) 
        {
            this.Action = action;
            this.C = c;
            this.ID = id;
            InitializeComponent();
            StartCate();
            StartUpdate();
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
        public void StartUpdate()
        {
            if (Action == "Update")
            {
                jobUpd = Backend.findJob(ID);
                if (jobUpd != null)
                {
                    tbJobID.Text = jobUpd.getJobID().ToString();
                    tbJobName.Text = jobUpd.getJobName();
                    rtbDesc.Text = jobUpd.getJobDesc();
                    cbJobType.SelectedIndex = cbJobType.FindString(jobUpd.GetJobType().getJobTypeName());
                    tbAttach.Text = jobUpd.getAttachment();
                    tbJobID.Enabled = false;
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
        private void tbOkay_Click(object sender, EventArgs e)
        {
            int IDpull = Int32.Parse((cbJobType.SelectedItem as ComboboxItem).Value.ToString());
            if (Validation())
            {
                if(Action != "Update")
                {
                    Job newJob = new Job(Int32.Parse(tbJobID.Text), tbJobName.Text, rtbDesc.Text,
                    Backend.findJobType(IDpull), tbAttach.Text);
                    Backend.lsJobs.Add(newJob);
                }
                else
                {
                    jobUpd.setJobName(tbJobName.Text);
                    jobUpd.setJobDesc(rtbDesc.Text);
                    jobUpd.setJobType(Backend.findJobType(IDpull));
                    jobUpd.setAttachment(tbAttach.Text);     
                }
                this.Dispose();
            }
        }
        private Boolean Validation()
        {
            if (tbJobID.Text == "" || tbJobName.Text == "" || rtbDesc.Text == "")
            {
                createDialog("All Fields Except Attachments MUST be filled in", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Backend.findJob(Int32.Parse(tbJobID.Text)) != null && Action != "Update")
            {
                createDialog("Job with ID: " + tbJobID.Text + " Already Exists", "Job ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            return true;
            
        }
        private DialogResult createDialog(String Message, String Type, MessageBoxButtons buts, MessageBoxIcon icon)
        {
            DialogResult res = MessageBox.Show(Message, Type, buts, icon);
            return res;
        }
        private void tbCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
