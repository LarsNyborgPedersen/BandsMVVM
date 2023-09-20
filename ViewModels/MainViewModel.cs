using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Core.Interfaces;
using Core.Models;
using Core.Services;

namespace Core.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Band> _bands;
        public ObservableCollection<Band> Bands {
            get
            {
                return _bands;
            }
            set
            {
                _bands = value;
                OnPropertyChanged(nameof(Bands));
            }
        }
        public ObservableCollection<string> BandNames => 
            new ObservableCollection<string>(Bands.Select(o => o.Name));


        private ObservableCollection<Person> _persons;
        public ObservableCollection<Person> Persons
        {
            get
            {
                return _persons;
            }
            set
            {
                _persons = value;
                OnPropertyChanged(nameof(Persons));
            }
        }
        public ObservableCollection<string> PersonNames =>
            new ObservableCollection<string>(Persons.Select(o => o.Name));

        private string _bandName;
        public string BandName
        {
            get { return _bandName; }
            set
            {
                if (_bandName != value)
                {
                    _bandName = value;
                    OnPropertyChanged(nameof(BandName));
                }
            }
        }

        private string _personName;
        public string PersonName
        {
            get { return _personName; }
            set
            {
                if (_personName != value)
                {
                    _personName = value;
                    OnPropertyChanged(nameof(PersonName));
                }
            }
        }


        private IBandService _bandService;

        public ICommand AddBandCommand { get; private set; }
        public ICommand AddPersonCommand { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public MainViewModel()
        {
            _bandService = new BandService();
            Bands = new ObservableCollection<Band>();
            Persons = new ObservableCollection<Person>();

            AddBandCommand = new RelayCommand(_ => AddBand(), _ => CanAddBand());
            AddPersonCommand = new RelayCommand(_ => AddPerson(), _ => CanAddPerson());
        }

        private void AddBand()
        {
            Band newBand = _bandService.AddBand(BandName);
            Bands.Add(newBand);
        }

        private bool CanAddBand()
        {
            return true;
        }

        private void AddPerson()
        {
            var person = _bandService.AddPerson(PersonName);
            Persons.Add(person);
        }

        private bool CanAddPerson()
        {
            return true;
        }
    }
}
