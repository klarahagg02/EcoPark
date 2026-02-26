using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using EcoPark.AnimalsGen;
using EcoPark.Birds;
using EcoPark.Birds.Speices;
using EcoPark.Mammals;

namespace EcoPark.View
{
    /// <summary>
    /// Interaction logic for BirdView.xaml
    /// </summary>
    public partial class BirdView : Window
    {
        public Animal Animal
        {
            get { return animal; }
            set
            {
                if (value != null)
                    animal = value;
            }
        }

        //set default values
        private Animal? animal = null;
        private BirdSpecies species = 0;

        //main constructor
        public BirdView(int species)
        {
            InitializeComponent();
            this.species = (BirdSpecies)species;
            InitializeSpeciesUI();
        }

        //method that initializes the UI based on the chosen species in main window
        private void InitializeSpeciesUI()
        {
            txtSpecificSpecies.Text = $"Specific Data for {species.ToString()}";

            //switch case to show txtBoxes based on what species was chosen in mainwindow
            switch (species)
            {
                case BirdSpecies.Pelican:
                    txtblock1.Text = "Beak length";
                    SetVisibility(txtblock1, true);
                    SetVisibility(txtInputBlock1, true);
                    SetVisibility(txtblock2, false);
                    SetVisibility(chkInput, false);
                    break;

                case BirdSpecies.Penguin:
                    txtblock1.Text = "Habitat";
                    SetVisibility(txtblock1, true);
                    SetVisibility(txtInputBlock1, true);
                    SetVisibility(txtblock2, false);
                    SetVisibility(chkInput, false);
                    break;
            }
        }

        private static void SetVisibility(UIElement element, bool isVisible)
        {
            //if isVisible is true, set visibility to Visible, otherwise set it to Collapsed (currently "removed")
            element.Visibility = isVisible ? Visibility.Visible : Visibility.Collapsed;
        }

        //when clicked OK, a new species object is created and the window closes
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            //if-statements to check if the input is valid, and if not, show a messagebox to prevent crashing. 
            if (!int.TryParse(txtWingspan.Text, out int wingspanVal) || wingspanVal < 0)
            {
                MessageBox.Show("Write a valid wingspan", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (species == BirdSpecies.Pelican)
            {
                if (!double.TryParse(txtInputBlock1.Text, out double beakVal) || beakVal < 0)
                {
                    MessageBox.Show("Write a valid beak length", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }
            if (species == BirdSpecies.Penguin && string.IsNullOrWhiteSpace(txtInputBlock1.Text))
            {
                MessageBox.Show("Fill ín habitat", "Habitat missing", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            CreateBirdSpecies();
            DialogResult = true;
            Close();
        }

        //method to create a species object 
        private void CreateBirdSpecies()
        {
            int wingspan = int.Parse(txtWingspan.Text);
            bool canFly = radioBtnYes.IsChecked == true;
            animal = BirdFactory.CreateBird(species, wingspan, canFly);

            switch (species)
            {
                case BirdSpecies.Pelican:
                    Pelican pelican = (Pelican)animal;
                    pelican.BeakLength = double.Parse(txtInputBlock1.Text);
                    break;
                case BirdSpecies.Penguin:
                    Penguin penguin = (Penguin)animal;
                    penguin.Habitat = txtInputBlock1.Text;
                    break;
            }
        }

        //when clicked Cancel, the animal is set to null and the window closes
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            animal = null; // Set the animal to null
            this.Close(); // Close the window
        }
    }
}
