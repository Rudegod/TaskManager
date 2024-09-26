using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_V0._1
{
    public class Domain
    {
        private static int counter = 0;
        public int id;
        public string name;
        public int parentID;
        public ObservableCollection<Group> groups;
        public ObservableCollection<Domain> subDomains;
        public Domain() {
            this.id = ++counter;
            this.name = "forExample";
            this.parentID = 0;
            this.groups = new ObservableCollection<Group>();
            this.subDomains = new ObservableCollection<Domain>();
        }
    }
}
