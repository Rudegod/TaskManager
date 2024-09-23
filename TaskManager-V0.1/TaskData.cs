using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_V0._1
{
    public static class TaskData
    {
        public static ObservableCollection<Task> tasks = new ObservableCollection<Task>();
        public static string name;
        public static Member assign;
        public static DateTime deadline;
        public static string cost;
        public static string time;
        public static string prerequisites;
        public static Member manager;
        public static string couple;
        public static Task previousTask;
        public static string description;
        public static string priority;
    }
}