using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace TaskManager_V0._1.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Name_Of_Groups> Titles { get; set; }

        public MainViewModel()
        {
            Titles = new ObservableCollection<Title>
        {
            new Title { Name = "Title 1" },
            new Title { Name = "Title 2" },
            new Title { Name = "Title 3" },
            // عناوین بیشتر...
        };
        }
    }

}
