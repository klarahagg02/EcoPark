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
using EcoPark.Mammals;
using EcoPark.Marine;
using EcoPark.Marine.Species;

namespace EcoPark.View
{
    /// <summary>
    /// Interaction logic for MarineView.xaml
    /// </summary>
    public partial class MarineView : Window
    {
        public MarineView()
        {
            InitializeComponent();
        }

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
        private MarineSpecies species = 0;

        //main constructor
        public MarineView(int species)
        {
            InitializeComponent();
            this.species = (MarineSpecies)species;
            InitializeSpeciesUI();
        }

        //method that initializes the UI based on the chosen species in main window
        private void InitializeSpeciesUI()
        {

            txtSpecificSpecies.Text = $"Specific Data for {species.ToString()}";

            //switch case to show txtBoxes based on what species was chosen in mainwindow
            switch (species)
            {
                case MarineSpecies.Octopus:
                    SetVisibility(txtblock1, false);
                    SetVisibility(txtInputBlock1, false);
                    txtblock2.Text = "Squirts ink";
                    SetVisibility(txtblock2, true);
                    SetVisibility(chkInput, true);
                    break;

                case MarineSpecies.Shark:
                    SetVisibility(txtblock1, false);
                    SetVisibility(txtInputBlock1, false);
                    txtblock2.Text = "Is carnivore";
                    SetVisibility(txtblock2, true);
                    SetVisibility(chkInput, true);
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
            if (!int.TryParse(txtLivingDeph.Text, out int depthVal) || depthVal < 0)
            {
                MessageBox.Show("Write a valid living deph", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtColor.Text))
            {
                MessageBox.Show("Fill in the color", "Color missing", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (double.TryParse(txtColor.Text.Trim(), out _))
            {
                MessageBox.Show("Write the color in text-form, no numbers", "Invalid color", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            CreateMarineSpecies();
            DialogResult = true;
            Close();
        }

        //method to create a species object 
        private void CreateMarineSpecies()
        {
            int livingDepth = int.Parse(txtLivingDeph.Text);
            string color = txtColor.Text;
            animal = MarineFactory.CreateMarine(species, livingDepth, color);

            switch (species)
            {
                case MarineSpecies.Octopus:
                    Octopus octopus = (Octopus)animal;
                    octopus.SquirtsInk = chkInput.IsChecked ?? false;
                    break;
                case MarineSpecies.Shark:
                    Shark shark = (Shark)animal;
                    shark.Carnivore = chkInput.IsChecked ?? false;
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
