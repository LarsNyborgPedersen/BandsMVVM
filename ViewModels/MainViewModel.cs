using System.Collections.ObjectModel;
using System.Windows.Input;
using Core.Interfaces;
using Core.Models;
using Core.Services;

namespace Core.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Band> Bands { get; set; }
        public ObservableCollection<Person> Persons { get; set; }

        private IBandService _bandService;
        public ICommand AddBandCommand { get; private set; }
        public ICommand AddPersonCommand { get; private set; }

        public MainViewModel()
        {
            _bandService = new BandService();
            Bands = new ObservableCollection<Band>();
            Persons = new ObservableCollection<Person>();

            AddBandCommand = new RelayCommand(name => AddBand((string) name), _ => CanAddBand());
            AddPersonCommand = new RelayCommand(name => AddPerson((string) name), _ => CanAddPerson());
        }


        

        private void AddBand(string bandName)
        {
            Band newBand = _bandService.AddBand(bandName);
            Bands.Add(newBand);
        }

        private bool CanAddBand()
        {
            // Logic to decide if a band can be added
            // Example: return !string.IsNullOrEmpty(SomeBandNameProperty);
            return true; // For simplicity, we allow adding bands anytime
        }

        private void AddPerson(string name)
        {
            var person = _bandService.AddPerson(name);
            Persons.Add(person);
        }

        private bool CanAddPerson()
        {
            // Logic to decide if a person can be added
            // Example: return !string.IsNullOrEmpty(SomePersonNameProperty);
            return true; // For simplicity, we allow adding persons anytime
        }
    }
}
