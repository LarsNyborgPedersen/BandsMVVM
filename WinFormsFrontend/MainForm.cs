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

            bandListBox.DataSource = _viewModel.BandNames;
            personListBox.DataSource = _viewModel.PersonNames;
        }

        private void addBandButton_Click(object sender, EventArgs e)
        {
            string bandName = bandNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(bandName))
            {
                MessageBox.Show("Please enter a valid band name.");
                return;
            }
            _viewModel.AddBandCommand.Execute(bandName);
            bandListBox.DataSource = null;
            bandListBox.DataSource = _viewModel.BandNames; 
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            var personName = personNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(personName))
            {
                MessageBox.Show("Please enter a valid person name.");
                return;
            }
            _viewModel.AddPersonCommand.Execute(personName);
            personListBox.DataSource = null;
            personListBox.DataSource = _viewModel.PersonNames;
        }
    }
}
