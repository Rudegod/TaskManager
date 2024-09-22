using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_V0._1
{
    public class Task
    {
        public static int counter = 1;

        public int id {  get; set; }
        public string name { get; set; }
        public Member assign { get; set; }
        public DateTime deadline { get; set ; }
        public string cost { get; set; }
        public string time { get; set; }
        public string prerequisites { get; set; }
        public Member manager { get; set; }
        public string couple { get; set; }
        public Task previousTask { get; set; }
        public string description { get; set; }
        public string priority { get; set; }
    }
}
