using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_V0._1
{
    public class Member
    {
        public static int counter = 1;

        public int id { get; set; }
        public string fullName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int age { get; set; }
        public bool gender { get; set; }
        public string phone { get; set; }
        public string nationalCode { get; set; }
        public bool active { get; set; }

        public Member(){
            this.id = counter;
            this.fullName = "yazdan";
            this.userName = "Rudegod";
            this.password = "12345678";
            this.age = 22;
            this.gender = true;
            this.phone = "09335343272";
            this.nationalCode = "0926206435";
            this.active = false;
            counter++;
        }
        public Member(string fullname, string username, string password, int age, bool gender, string phone, string nationalcode, bool active)
        {
            this.id=counter;
            this.fullName = fullname;
            this.userName=username;
            this.password = password;
            this.age = age;
            this.gender = gender;
            this.phone = phone;
            this.nationalCode = nationalcode;
            this.active = active;
            counter++;
        }
    }
}
