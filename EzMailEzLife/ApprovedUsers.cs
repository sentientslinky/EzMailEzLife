using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EzMailEzLife
{
    public class ApprovedUser
    {
        public string UserEmail;
        public string UserName;
    }

    public class UserManager
    {
        public static UserManager Instance
        {
            get
            {
                if (_userManager == null)
                {
                    _userManager = new UserManager();
                    Instance.Initialize();
                }

                return _userManager;
            }
        }

        public List<ApprovedUser> GetAllApprovedUsers()
        {
            return _approvedUsers;
        }

        private void Initialize()
        {
            _approvedUsers = new List<ApprovedUser>();
            foreach(var admin in Properties.Settings.Default.ApprovedAdmins)
            {
                _approvedUsers.Add(new ApprovedUser(){UserEmail =admin.Split(',')[0], UserName = admin.Split(',')[1]});
            }
        }

        private static UserManager _userManager = null;
        private List<ApprovedUser> _approvedUsers;


        internal void SetApprovedUsers(List<KeyValuePair<string, string>> kvpList)
        {
            _approvedUsers = new List<ApprovedUser>();
            Properties.Settings.Default.ApprovedAdmins.Clear();
            foreach(var newUsers in kvpList)
            {
                
                Properties.Settings.Default.ApprovedAdmins.Add(newUsers.Key+","+newUsers.Value);
                _approvedUsers.Add(new ApprovedUser(){ UserName= newUsers.Key, UserEmail= newUsers.Value});
            }

            Properties.Settings.Default.Save();
        }
    }
}
