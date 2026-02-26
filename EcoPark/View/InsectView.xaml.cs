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
using EcoPark.Insects;
using EcoPark.Insects.Species;
using EcoPark.Mammals;

namespace EcoPark.View
{
    /// <summary>
    /// Interaction logic for InsectView.xaml
    /// </summary>
    public partial class InsectView : Window
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
        private InsectSpecies species = 0;

        //main constructor
        public InsectView(int species)
        {
            InitializeComponent();
            this.species = (InsectSpecies)species;
            InitializeSpeciesUI();
        }

        //method that initializes the UI based on the chosen species in main window
        private void InitializeSpeciesUI()
        {

            txtSpecificSpecies.Text = $"Specific Data for {species.ToString()}";

            //switch case to show txtBoxes based on what species was chosen in mainwindow
            switch (species)
            {
                case InsectSpecies.Bee:
                    txtblock1.Text = "Type of bee";
                    SetVisibility(txtblock1, true);
                    SetVisibility(txtInputBlock1, true);
                    SetVisibility(txtblock2, false);
                    SetVisibility(chkInput, false);
                    break;

                case InsectSpecies.Ladybug:
                    txtblock1.Text = "Number of dots";
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
            if (string.IsNullOrWhiteSpace(txtColor.Text))
            {
                MessageBox.Show("Fill in the color", "Color missing", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (double.TryParse(txtColor.Text.Trim(), out _))
            {
                MessageBox.Show("Write color in text-form, no numbers", "Invalid color", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (species == InsectSpecies.Bee && string.IsNullOrWhiteSpace(txtInputBlock1.Text))
            {
                MessageBox.Show("Fill in bee type", "Bee type missing", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (species == InsectSpecies.Bee && double.TryParse(txtInputBlock1.Text.Trim(), out _))
            {
                MessageBox.Show("Write bee type in text-form, no numbers", "Invalid bee type", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (species == InsectSpecies.Ladybug && (!int.TryParse(txtInputBlock1.Text, out int dotsVal) || dotsVal < 0))
            {
                MessageBox.Show("Write a valid number of dots", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            CreateInsectSpecies();
            DialogResult = true;
            Close();
        }

        //method to create a species object 
        private void CreateInsectSpecies()
        {
            string color = txtColor.Text;
            bool canFly = radioBtnYes.IsChecked == true;
            animal = InsectFactory.CreateInsect(species, canFly, color);

            switch (species)
            {
                case InsectSpecies.Bee:
                    Bee bee = (Bee)animal;
                    bee.TypeOfBee = txtInputBlock1.Text;
                    break;
                case InsectSpecies.Ladybug:
                    Ladybug ladybug = (Ladybug)animal;
                    ladybug.NumOfDots = int.Parse(txtInputBlock1.Text);
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
