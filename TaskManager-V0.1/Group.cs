using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_V0._1
{
    public class Group
    {
        private static int counter = 0;
        private int id;
        private string name;
        private string description;
        private List<Member> membersID;
        private int domainID;

        public Group()
        {
            this.id = ++counter;
            this.name = "forExample";
            this.description = "ffffffffffffffffffffffffffffooooooooooorEEEEEEEEEEEEEEExamplllllllllllllllllllle";
            this.membersID = new List<Member>();
            this.domainID = 0;
        }

        public void addMember(Member member)
        {
            membersID.Add(member);
        }

        public void removeMember(Member member)
        { 
            membersID.Remove(member);
        }

    }
}
