using System;
using System.Windows.Forms;
using Core.Models;
using Core.Services;
using Core.ViewModels;

namespace WinFormsFrontend
{
    public partial class MainForm : Form
    {
        private MainViewModel _viewModel;

        public MainForm()
        {
            InitializeComponent();
            _viewModel = new MainViewModel();

            // Manual data binding
            bandListBox.DataSource = _viewModel.Bands;
            // Assuming you have a personListBox to list persons
            personListBox.DataSource = _viewModel.Persons; // This would require you to add a Persons ObservableCollection in your MainViewModel
        }

        private void addBandButton_Click(object sender, EventArgs e)
        {
            string bandName = bandNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(bandName))
            {
                MessageBox.Show("Please enter a valid band name.");
                return;
            }
            _viewModel.AddBandCommand.Execute(bandName);  // This assumes you have the command set up
            bandListBox.DataSource = null;
            bandListBox.DataSource = _viewModel.Bands.Select(o => o.Name).ToList();  // Refresh the data binding
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            var personName = personNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(personName))
            {
                MessageBox.Show("Please enter a valid person name.");
                return;
            }
            _viewModel.AddPersonCommand.Execute(personName);  // This assumes you have the command set up
            personListBox.DataSource = null;
            personListBox.DataSource = _viewModel.Persons.Select(o => o.Name).ToList();  // Refresh the data binding
        }

        // Any other methods for additional operations can be added similarly
    }
}
