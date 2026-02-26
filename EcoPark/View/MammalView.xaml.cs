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
using EcoPark.Mammals;
using EcoPark.AnimalsGen;
using EcoPark.Mammals.Species;

namespace EcoPark.View
{
    /// <summary>
    /// Interaction logic for MammalView.xaml
    /// </summary>
    public partial class MammalView : Window
    {

        //property to enable smooth data transfer between MainWindow and this Window
        public Animal Animal
        {
            //to get or set the animal that will be a cat, dog or cow
            get { return animal; }
            set 
            { 
                if (value != null)
                    animal = value;
            }
        }

        //set default values
        private Animal? animal = null;
        private MammalSpecies species = 0;

        //main constructor
        public MammalView(int species)
        {
            InitializeComponent();
            this.species = (MammalSpecies)species;
            InitializeSpeciesUI();
        }

        //method that initializes the UI based on the chosen species in main window
        private void InitializeSpeciesUI() { 

            txtSpecificSpecies.Text = $"Specific Data for {species.ToString()}";
            
            //switch case to show txtBoxes based on what species was chosen in mainwindow
            switch (species)
            {
                case MammalSpecies.Cat:
                    SetVisibility(txtblock1, false);
                    SetVisibility(txtInputBlock1, false);
                    txtblock2.Text = "Allergy friendly";
                    SetVisibility(txtblock2, true);
                    SetVisibility(chkInput, true);
                    break;

                case MammalSpecies.Cow:
                    txtblock1.Text = "Milk production/day";
                    SetVisibility(txtblock1, true);
                    SetVisibility(txtInputBlock1, true);
                    SetVisibility(txtblock2, false);
                    SetVisibility(chkInput, false);
                    break;

                case MammalSpecies.Dog:
                    txtblock1.Text = "Breed";
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
            if (!int.TryParse(txtNumOfLegs.Text, out int numOfLegsVal) || numOfLegsVal < 0)
            {
                MessageBox.Show("Write a valid number of legs", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (!int.TryParse(txtTailLength.Text, out int tailLengthVal) || tailLengthVal < 0)
            {
                MessageBox.Show("Write a valid number for tail length", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (species == MammalSpecies.Cow)
            {
                if (!int.TryParse(txtInputBlock1.Text, out int milkVal) || milkVal < 0)
                {
                    MessageBox.Show("Write a valid number for milk production", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }
            if (species == MammalSpecies.Dog && string.IsNullOrWhiteSpace(txtInputBlock1.Text))
            {
                MessageBox.Show("Fill in the breed", "Breed missing", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            CreateMammalSpecies();
            DialogResult = true; // Set the dialog result to true to indicate successful creation
            Close(); // Close the window after creating the animal
        }

        //method to create a species object 
        private void CreateMammalSpecies()
        {
            int numOfLegs = int.Parse(txtNumOfLegs.Text);
            int tailLength = int.Parse(txtTailLength.Text);
            animal = MammalFactory.CreateMammal(species, numOfLegs, tailLength);

            switch (species)
            {
                case MammalSpecies.Cat:
                    Cat cat = (Cat)animal;
                    cat.AllergyFriendly = chkInput.IsChecked ?? false;
                    break;
                case MammalSpecies.Cow:
                    Cow cow = (Cow)animal;
                    cow.MilkProduction = int.Parse(txtInputBlock1.Text);
                    break;

                case MammalSpecies.Dog:
                    Dog dog = (Dog)animal;
                    dog.Breed = txtInputBlock1.Text;
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
