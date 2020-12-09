using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organiser
{
    public class Job
    {
        private int JobID;
        private String JobName;
        private String JobDesc;
       //private User JobRaisedByNA;
        private String JobRaisedBy;
        private JobType JobType;
        private String ClientName;
        private String ClientContact;
        private String Attachment;

        public Job(int jobID, String jobName, String JobDesc, String jobRaisedBy, JobType jobType, String clientName, 
                   String clientContact, String attachment = null)
        {
            this.JobID = jobID;
            this.JobName = jobName;
            this.JobDesc = JobDesc;
            this.JobRaisedBy = jobRaisedBy;
            this.JobType = jobType;
            this.ClientName = clientName;
            this.ClientContact = clientContact;
            this.Attachment = attachment;
        }

        public int getJobID()
        {
            return JobID;
        }
        public String getJobName()
        {
            return JobName;
        }
        public String getJobDesc()
        {
            return JobDesc;

        }
       // public User getRaisedByNA()
        //{
        //    return JobRaisedByNA;
       // }
        public String getRaisedBy()
        {
            return JobRaisedBy;
        }
        public JobType GetJobType()
        {
            return JobType;
        }
        public String getClientName()
        {
            return ClientName;
        }
        public String getClientContact()
        {
            return ClientContact;
        }
        public String getAttachment()
        {
            return Attachment;
        }
        public void setJobName(String jobName)
        {
            this.JobName = jobName;
        }
        public void setJobDesc(String jobDesc)
        {
            this.JobDesc = jobDesc;
        }
        public void setJobType(JobType jobType)
        {
            this.JobType = jobType;
        }
        public void setClientName(String clientname)
        {
            this.ClientName = clientname;
        }
        public void setClientContact(String clientContact)
        {
            this.ClientContact = clientContact;
        }
        public void setAttachment(String attachment)
        {
            this.Attachment = attachment;
        }
    }
}
