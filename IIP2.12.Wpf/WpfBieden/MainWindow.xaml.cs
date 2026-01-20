using System;
using System.Windows;

namespace WpfBieden
{
    public partial class MainWindow : Window
    {
        // 🌍 Globale variabelen
        private string hoogsteBieder = "";
        private double hoogsteBod = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnPlaatsBod_Click(object sender, RoutedEventArgs e)
        {
            string naam = txtNaamInput.Text.Trim();
            string bodText = txtBodInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(naam) || string.IsNullOrWhiteSpace(bodText))
            {
                txtStatus.Text = "Vul zowel je naam als een bod in.";
                return;
            }

            if (!double.TryParse(bodText, out double bod))
            {
                txtStatus.Text = "Voer een geldig numeriek bod in.";
                return;
            }

            if (bod <= hoogsteBod)
            {
                txtStatus.Text = $"Je bod moet hoger zijn dan {hoogsteBod} euro.";
            }
            else
            {
                hoogsteBod = bod;
                hoogsteBieder = naam;
                txtStatus.Text = $"{hoogsteBieder} heeft met {hoogsteBod} euro nu het hoogste bod!";
            }

            // Wis de tekstvakken
            txtNaamInput.Text = "";
            txtBodInput.Text = "";
        }
    }
}
