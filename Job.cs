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
        private JobType JobType;
        private String Attachment;

        public Job(int jobID, String jobName, String JobDesc, JobType jobType, 
                   String attachment = null)
        {
            this.JobID = jobID;
            this.JobName = jobName;
            this.JobDesc = JobDesc;
            this.JobType = jobType;
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
        public JobType GetJobType()
        {
            return JobType;
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

        public void setAttachment(String attachment)
        {
            this.Attachment = attachment;
        }
    }
}
