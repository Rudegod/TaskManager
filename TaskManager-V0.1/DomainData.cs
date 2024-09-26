using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_V0._1
{
    public static class DomainData
    {
        public static ObservableCollection<Domain> domains = new ObservableCollection<Domain>();
        public static string name;
        public static int parentID;
        public static List<Group> groups;
    }
}
