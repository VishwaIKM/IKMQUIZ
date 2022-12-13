using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ.Model
{
    public class LoginModel
    {
        #region Member
        private string _username;//moved to Global
        private string _userid;
        private string _password;
        private int _isadmin;//moved to Global

        #endregion

        #region Properties

        public int IsAdmin { get => _isadmin; set => _isadmin = value; }
        public string UserId { get => _userid; set => _userid = value; }
        public string Password { get => _password; set => _password = value; }
        public string UserName { get => _username; set => _username = value; }
        #endregion
    }
}
