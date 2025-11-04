using System;

namespace Organiser
{
    public class JobType
    {
        private int JobTypeID;
        private String JobTypeName;
        private Categories CategoryID;

        public JobType(int jobTypeID, String jobTypeName, Categories categoryID)
        {
            this.JobTypeID = jobTypeID;
            this.JobTypeName = jobTypeName;
            this.CategoryID = categoryID;
        }

        public int getJobTypeID()
        {
            return JobTypeID;
        }

        public String getJobTypeName()
        {
            return JobTypeName;
        }

        public Categories getJobTypeCate()
        {
            return CategoryID;
        }

        public void setJobTypeName(String jobTypeName)
        {
            this.JobTypeName = jobTypeName;
        }

        public void setJobTypeCate(Categories categoryID)
        {
            this.CategoryID = categoryID;
        }
    }
}
