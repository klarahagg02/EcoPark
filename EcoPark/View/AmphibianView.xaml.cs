using EcoPark.Amphibians;
using EcoPark.Amphibians.Species;
using EcoPark.AnimalsGen;
using EcoPark.Mammals;
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

namespace EcoPark.View
{
    /// <summary>
    /// Interaction logic for AmphibianView.xaml
    /// </summary>
    public partial class AmphibianView : Window
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
        private AmphibianSpecies species = 0;


        //main constructor
        public AmphibianView(int species)
        {
            InitializeComponent();
            this.species = (AmphibianSpecies)species;
            InitializeSpeciesUI();
        }

        //method that initializes the UI based on the chosen species in main window
        private void InitializeSpeciesUI()
        {
            txtSpecificSpecies.Text = $"Specific Data for {species.ToString()}";

            //switch case to show txtBoxes based on what species was chosen in mainwindow
            switch (species)
            {
                case AmphibianSpecies.Axolotl:
                    SetVisibility(txtblock1, false);
                    SetVisibility(txtInputBlock1, false);
                    txtblock2.Text = "Regrows limbs";
                    SetVisibility(txtblock2, true);
                    SetVisibility(chkInput, true);
                    break;

                case AmphibianSpecies.Frog:
                    SetVisibility(txtblock1, false);
                    SetVisibility(txtInputBlock1, false);
                    txtblock2.Text = "Is poisonous";
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
            CreateAmphibianSpecies();
            DialogResult = true;
            Close();
        }

        //method to create a species object 
        private void CreateAmphibianSpecies()
        {
            string color = txtColor.Text;
            bool livesInWater = radioBtnYes.IsChecked == true;
            animal = AmphibianFactory.CreateAmphibian(species, livesInWater, color);

            switch (species)
            {
                case AmphibianSpecies.Axolotl:
                    Axolotl axolotl = (Axolotl)animal;
                    axolotl.RegrowLimbs = chkInput.IsChecked ?? false;
                    break;
                case AmphibianSpecies.Frog:
                    Frog frog = (Frog)animal;
                    frog.IsPoisonous = chkInput.IsChecked ?? false;
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
