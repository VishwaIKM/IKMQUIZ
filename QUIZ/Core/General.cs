using QUIZ.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ.Core
{
    public class General
    {
        public static StartUpWindow S_StartUpWindow_Instance;
        public static LoginWindow S_LoginWindow_Instance = new LoginWindow();
        public static CandidateDashboardWindow S_CandidateDashboard_Instance = new CandidateDashboardWindow();
    }
}
