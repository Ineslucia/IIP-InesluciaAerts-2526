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

namespace WpfChat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnVerzenden_Click(object sender, RoutedEventArgs e)
        {
            string naam = txtNaam.Text.Trim();
            string bericht = txtBericht.Text.Trim();


            if (!string.IsNullOrEmpty(naam) && !string.IsNullOrEmpty(bericht))
            { // Censureer ongepaste woorden
              string gefilterd = bericht.Replace("shit", "****", StringComparison.OrdinalIgnoreCase);

                // Voeg toe aan chatvenster
               tblChat.Text += $"{naam} zegt:{Environment.NewLine}{gefilterd}{Environment.NewLine}{Environment.NewLine}"; 
                // Velden leegmaken
                txtNaam.Text = ""; txtBericht.Text = "";
            }
        }
    }
}