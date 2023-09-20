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

            AddBandCommand = new RelayCommand(_ => AddBand(), _ => CanAddBand());
            AddPersonCommand = new RelayCommand(_ => AddPerson(), _ => CanAddPerson());
        }


        

        private void AddBand()
        {
            // Implement logic to add a band
            var band = new Band { Name = "New Band" }; // Modify as per your requirements
            _bandService.AddBand(band);
            Bands.Add(band);
        }

        private bool CanAddBand()
        {
            // Logic to decide if a band can be added
            // Example: return !string.IsNullOrEmpty(SomeBandNameProperty);
            return true; // For simplicity, we allow adding bands anytime
        }

        private void AddPerson()
        {
            // Implement logic to add a person
            var person = new Person { Name = "New Person" }; // Modify as per your requirements
            _bandService.AddPerson(person);
            // Optionally: Update a Persons collection if you have one in ViewModel
        }

        private bool CanAddPerson()
        {
            // Logic to decide if a person can be added
            // Example: return !string.IsNullOrEmpty(SomePersonNameProperty);
            return true; // For simplicity, we allow adding persons anytime
        }
    }
}
