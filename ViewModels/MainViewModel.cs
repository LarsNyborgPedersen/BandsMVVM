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
        public ObservableCollection<string> BandNames => 
            (ObservableCollection<string>) Bands.Select(o => o.Name);
        public ObservableCollection<Person> Persons { get; set; }
        public ObservableCollection<string> PersonNames =>
            (ObservableCollection<string>) Persons.Select(o => o.Name);

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
            return true;
        }

        private void AddPerson(string name)
        {
            var person = _bandService.AddPerson(name);
            Persons.Add(person);
        }

        private bool CanAddPerson()
        {
            return true;
        }
    }
}
