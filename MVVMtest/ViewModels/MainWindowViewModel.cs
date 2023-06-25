using MVVMtest.Models;
using MVVMtest.ViewModels.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMtest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private IList<bool>? _genderTypes = new List<bool>() { true, false };
        public IList<bool>? GenderTypes
        {
            get => _genderTypes;
        }

        private IList<Person>? _people;
        public IList<Person>? People
        {
            get => _people;
            set => SetProperty(ref _people, value);
        }

        private Person? _selectedPerson;
        public Person? SelectedPerson
        {
            get => _selectedPerson;
            set => SetProperty(ref _selectedPerson, value);
        }

        public MainWindowViewModel()
        {
            People = new List<Person>
            {
                new Person{Id = 119302, Name = "톰", Gender = true},
                new Person{Id = 119303, Name = "탐", Gender = false},
                new Person{Id = 119304, Name = "팀", Gender = true},
                new Person{Id = 119305, Name = "뚱", Gender = true},
                new Person{Id = 119306, Name = "캣", Gender = false},
                new Person{Id = 119307, Name = "땅", Gender = true},

            };
        }
    }
}
