using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_V0._1
{
    public static class GroupData
    {
        public static ObservableCollection<Group> groups = new ObservableCollection<Group>();
        public static int id;
        public static string name;
        public static string description;
        public static List<Member> membersID;
        public static int domainID;
    }
}
