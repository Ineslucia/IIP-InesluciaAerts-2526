using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBieden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeAuctionItems();
        }

        private void InitializeAuctionItems()
        {
            // Neem een afbeelding van het internet
            var imageUri = "https://www.antique-tileshop.nl/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/i/m/img_1950/vaas-32.jpg";
        }
        private void BtnPlaatsBod_Click(object sender, RoutedEventArgs e)
        {
            var naam = TxtNaam.Text;
            var bod = TxtBod.Text;

            if (!decimal.TryParse(bodTekst, out decimal bod) || bod <= 0)
            {
                MessageBox.Show("Voer een geldig bod in (positief numeriek).", "Fout", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (bod < _hoogsteBod)
            {
                MessageBox.Show($"Het bod moet ten minste {_hoogsteBod:C} zijn.", "Fout", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            // Nieuw hoogste bod en bieder
            _hoogsteBod = bod;
            _naamHoogste = naam;

            // Wis de twee tekstvakken
            txtNaam.Text = string.Empty;
            txtBod.Text = string.Empty;

            // Update display teksten
            UpdateDisplay();
        }
        private void UpdateDisplay()
        {
            if (string.IsNullOrEmpty(_naamHoogste))
            {
                txtStatus.Text = "Bied nu op deze vaas.";
                txtHoogste.Text = "";
            }
            else
            {
                txtStatus.Text = $" Rogier heeft met {_hoogsteBod:C} euro nu het hoogste bod!"; // Pas aan naar gewenste naam indien nodig
                txtHoogste.Text = $"Hoogste bod: {_hoogsteBod:C} door {_naamHoogste}";
            }
        }
    }
}