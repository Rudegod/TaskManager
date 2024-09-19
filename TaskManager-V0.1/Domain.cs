using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_V0._1
{
    internal class Domain
    {
        private static int counter = 1;
        private int id;
        private string name;
        private int parentID;
        private List<Member> members;
        private List<Group> groups;
        public Domain() {
            this.id = ++counter;
            this.name = "forExample";
            this.parentID = 0;
        }
    }
}
