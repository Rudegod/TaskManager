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

        public int id { get; set; }
        public string name { get; set; }
        public Member assign { get; set; }
        public DateTime deadline { get; set; }
        public string cost { get; set; }
        public string time { get; set; }
        public string prerequisites { get; set; }
        public Member manager { get; set; }
        public string couple { get; set; }
        public Task previousTask { get; set; }
        public string description { get; set; }
        public string priority { get; set; }
        public static bool f { get; set; }
        public Task()
        {
            this.id = counter;
            this.name = "my_task";
            this.assign = new Member();
            this.deadline = DateTime.Now;
            this.cost = "100000";
            this.time = "two weeks";
            this.prerequisites = "Task N #5";
            this.manager = new Member();
            this.couple = "Task N #9 & #10";
            this.previousTask = new Task();
            this.description = "A importent description";
            this.priority = "80";
            f = false;
            counter++;
        }
        public Task(string name, Member assign, DateTime deadline, string cost, string time, string prerequisites, Member manager, string couple, Task previousTask, string description, string priority)
        {
            this.id = counter;
            this.name = name;
            this.assign = assign;
            this.deadline = deadline;
            this.cost = cost;
            this.time = time;
            this.prerequisites = prerequisites;
            this.manager = manager;
            this.couple = couple;
            this.previousTask = previousTask;
            this.description = description;
            this.priority = priority;
            f = true;
            counter++;
        }
    }
}