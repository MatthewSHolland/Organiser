using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organiser
{
    public class SecurityLevels
    {
        private int SecurityID;
        private String SecurityName;
        private int SecurityLevel;

        public SecurityLevels(int securityID, String securityName, int securityLevel)
        {
            this.SecurityID = securityID;
            this.SecurityName = securityName;
            this.SecurityLevel = securityLevel;
        }

        public int getSecurityID()
        {
            return SecurityID;
        }

        public String getSecurityName()
        {
            return SecurityName;
        }

        public int getSecurityLevel()
        {
            return SecurityLevel;
        }

        public void setSecurityName(String securityName)
        {
            this.SecurityName = securityName;
        }

        public void setSecurityLevel(int securityLevel)
        {
            this.SecurityLevel = securityLevel;
        }
    }
}
