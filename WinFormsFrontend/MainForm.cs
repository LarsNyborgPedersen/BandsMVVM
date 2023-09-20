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
            _viewModel.BandName = TbBandName.Text;
            if (string.IsNullOrWhiteSpace(_viewModel.BandName))
            {
                MessageBox.Show("Please enter a valid band name.");
                return;
            }
            _viewModel.AddBandCommand.Execute(null);
            bandListBox.DataSource = null;
            bandListBox.DataSource = _viewModel.BandNames;
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            _viewModel.PersonName = personNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(_viewModel.PersonName))
            {
                MessageBox.Show("Please enter a valid person name.");
                return;
            }
            _viewModel.AddPersonCommand.Execute(null);
            personListBox.DataSource = null;
            personListBox.DataSource = _viewModel.PersonNames;
        }
    }
}
