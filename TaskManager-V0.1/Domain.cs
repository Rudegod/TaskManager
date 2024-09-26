using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_V0._1
{
    public class Domain
    {
        private static int counter = 1;
        public int id;
        public string name;
        public int parentID;
        public List<Group> groups;
        public Domain() {

            this.id = ++counter;
            this.name = "forExample";
            this.parentID = 0;
            this.groups = new List<Group>();
        }
    }
}
