using System;

namespace Organiser
{
    public class Job
    {
        private int JobID;
        private String JobName;
        private String JobDesc;
        private JobType JobType;
        private String Attachment;
        private DateTime deadLine;

        public Job(int jobID, String jobName, String JobDesc, JobType jobType, DateTime deadLine,
                   String attachment = null)
        {
            this.JobID = jobID;
            this.JobName = jobName;
            this.JobDesc = JobDesc;
            this.JobType = jobType;
            this.deadLine = deadLine;
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
        public JobType getJobType()
        {
            return JobType;
        }
        public String getAttachment()
        {
            return Attachment;
        }
        public DateTime getDeadline()
        {
            return deadLine;
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

        public void setDeadline(DateTime deadline)
        {
            this.deadLine = deadline;
        }
    }
}
