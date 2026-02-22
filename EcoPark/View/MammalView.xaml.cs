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

namespace EcoPark.View
{
    /// <summary>
    /// Interaction logic for MammalView.xaml
    /// </summary>
    public partial class MammalView : Window
    {

        //property to enable smooth data transfer between MainForm and this Form
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
        private MammalSpecies species = 0;


        //main constructor
        public MammalView(int species)
        {
            InitializeComponent();
            this.species = (MammalSpecies)species;
            InitializeSpeciesUI();
        }

        //another constructor for ? do i need this?
        public MammalView(Animal animal)
        {
            InitializeComponent();
            InitializeSpeciesUI();
        }

        //public MammalView()
        //{
        //    InitializeComponent();
        //    InitializeSpeciesUI();
        //}

        //create a help method that loops through the textboxes and hides them as a starter to minimize duplication of code!


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

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            //numoflegs and taillength
            //all specific species data as well!
            int numOfLegs = int.Parse(txtNumOfLegs.Text);
            int tailLength = int.Parse(txtTailLength.Text);

            //call method that reads the specific data for the species that was selected in the MainWindow
            //and saves it in the instance variables in Mammal.cs 
            
        }



        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
