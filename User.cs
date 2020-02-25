using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organiser
{
    public class User
    {
        private String UserName;
        private String UsrFirstName;
        private String UsrSurname;
        private String UsrPhone;
        private String UsrEmail;
        private String UsrCreatedBy;
        private DateTime UsrCreatedDate;
        private string UsrPassword;
        private Boolean Active;
        private Boolean ResetPass;
        private SecurityLevels SecLevel;

        public User(String userName, String usrFirstName, String usrSurname, String usrCreatedBy, DateTime usrCreatedDate, 
                    String usrPassword, Boolean active, Boolean resetPass, SecurityLevels secLevel, String usrPhone = null, String usrEmail = null)
        {
            this.UserName = userName;
            this.UsrFirstName = usrFirstName;
            this.UsrSurname = usrSurname;
            this.UsrCreatedBy = usrCreatedBy;
            this.UsrCreatedDate = usrCreatedDate;
            this.UsrPassword = usrPassword;
            this.Active = active;
            this.ResetPass = resetPass;
            this.SecLevel = secLevel;
            this.UsrPhone = usrPhone;
            this.UsrEmail = usrEmail;
        }
        public String getUserName()
        {
            return UserName;
        }
        public String getUsrFirstName()
        {
            return UsrFirstName;
        }
        public String getUsrSurname()
        {
            return UsrSurname;
        }
        public String getUsrCreatedBy()
        {
            return UsrCreatedBy;
        }
        public DateTime getUsrCreatedDate()
        {
            return UsrCreatedDate;
        }
        public Boolean getUsrActive()
        {
            return Active;
        }
        public Boolean getResetPass()
        {
            return ResetPass;
        }
        public SecurityLevels getSecLevel()
        {
            return SecLevel;
        }
        public String getUsrPhone()
        {
            return UsrPhone;
        }
        public String getUsrEmail()
        {
            return UsrEmail;
        }

        public String getUsrPass()
        {
            return UsrPassword;
        }
        public void setUserName(String userName)
        {
            this.UserName = userName;
        }
        public void setUsrFirstName(String usrFirstName)
        {
            this.UsrFirstName = usrFirstName;
        }
        public void setUsrSurname(string usrSurname)
        {
            this.UsrSurname = usrSurname;
        }
        public void setUsrPassword(String usrPassword)
        {
            this.UsrPassword = usrPassword;
        }
        public void setActive(Boolean active)
        {
            this.Active = active;
        }
        public void setResetPass(Boolean resetPass)
        {
            this.ResetPass = resetPass;
        }
        public void setSecLevel(SecurityLevels secLevel)
        {
            this.SecLevel = secLevel;
        }
        public void setUsrPhone(String usrPhone)
        {
            this.UsrPhone = usrPhone;
        }
        public void setUsrEmail(String usrEmail)
        {
            this.UsrEmail = usrEmail;
        }
    }
}
