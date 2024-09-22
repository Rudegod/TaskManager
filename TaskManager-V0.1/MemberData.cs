using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_V0._1
{

    public static class MemberData
    {
        public static ObservableCollection<Member> members = new ObservableCollection<Member>();
        public static string fullName;
        public static string userName;
        public static string password;
        public static string age;
        public static bool gender;
        public static string phone;
        public static string nationalCode;
        public static bool active;
    }
}
