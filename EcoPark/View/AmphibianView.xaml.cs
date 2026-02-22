using EcoPark.Amphibians;
using EcoPark.AnimalsGen;
using EcoPark.Arachnids;
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

        //another constructor for ? do i need this?
        public AmphibianView(Animal animal)
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

        //string color = txtColor.Text;

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        /*
        private void ShowSpecies()
        {
            txtSpecificSpecies.Text = $"Specific Data for {MainWindow.species.ToString()}";

            switch ((AmphibianSpecies)species)
            {
                case Amphibians.Frog
            }
        }*/
    }
}
