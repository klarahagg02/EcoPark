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

        //another constructor for ? do i need this?
        public InsectView(Animal animal)
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

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
