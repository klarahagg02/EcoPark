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
using EcoPark.Arachnids;
using EcoPark.Arachnids.Species;
using EcoPark.Mammals;

namespace EcoPark.View
{
    /// <summary>
    /// Interaction logic for ArachnidView.xaml
    /// </summary>
    public partial class ArachnidView : Window
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
        private ArachnidSpecies species = 0;


        //main constructor
        public ArachnidView(int species)
        {
            InitializeComponent();
            this.species = (ArachnidSpecies)species;
            InitializeSpeciesUI();
        }

        //method that initializes the UI based on the chosen species in main window
        private void InitializeSpeciesUI()
        {

            txtSpecificSpecies.Text = $"Specific Data for {species.ToString()}";

            //switch case to show txtBoxes based on what species was chosen in mainwindow
            switch (species)
            {
                case ArachnidSpecies.Spider:
                    SetVisibility(txtblock1, false);
                    SetVisibility(txtInputBlock1, false);
                    txtblock2.Text = "Produces web";
                    SetVisibility(txtblock2, true);
                    SetVisibility(chkInput, true);
                    break;

                case ArachnidSpecies.Scorpion:
                    txtblock1.Text = "Claw length";
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
            CreateArachnidSpecies();
            DialogResult = true;
            Close();
        }

        //method to create a species object 
        private void CreateArachnidSpecies()
        {
            int numOfEyes = int.Parse(txtNumOfEyes.Text);
            bool isPoisonous = radioBtnYes.IsChecked == true;
            animal = ArachnidFactory.CreateArachnid(species, numOfEyes, isPoisonous);

            switch (species)
            {
                case ArachnidSpecies.Spider:
                    Spider spider = (Spider)animal;
                    spider.ProduceWeb = chkInput.IsChecked ?? false;
                    break;
                case ArachnidSpecies.Scorpion:
                    Scorpion scorpion = (Scorpion)animal;
                    scorpion.ClawLength = int.Parse(txtInputBlock1.Text);
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
