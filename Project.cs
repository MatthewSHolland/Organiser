using System;

namespace Organiser
{
    public class Project
    {
        private String sProjectName;
        private String sProjectDir;

        public Project(String sprojectName, String sprojectDir)
        {
            this.sProjectName = sprojectName;
            this.sProjectDir = sprojectDir;
        }

        public String getProName()
        {
            return sProjectName;
        }

        public String getProDir()
        {
            return sProjectDir;
        }

        public void setProName(String ProName)
        {
            this.sProjectName = ProName;
        }

        public void setProDir(String ProDir)
        {
            this.sProjectDir = ProDir;
        }
    }
}
