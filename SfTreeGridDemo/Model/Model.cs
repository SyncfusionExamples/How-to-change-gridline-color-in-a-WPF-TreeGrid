using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.ComponentModel;

namespace SfTreeGridDemo
{
    public class EmployeeInfo : INotifyPropertyChanged
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _title;
        private double? _salary;
        private int _reportsTo;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int ID
        {
            get => _id;
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged(nameof(ID));
                }
            }
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged(nameof(FirstName));
                }
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged(nameof(LastName));
                }
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged(nameof(Title));
                }
            }
        }

        public double? Salary
        {
            get => _salary;
            set
            {
                if (_salary != value)
                {
                    _salary = value;
                    OnPropertyChanged(nameof(Salary));
                }
            }
        }

        public int ReportsTo
        {
            get => _reportsTo;
            set
            {
                if (_reportsTo != value)
                {
                    _reportsTo = value;
                    OnPropertyChanged(nameof(ReportsTo));
                }
            }
        }
    }
}
    


