using EcoPark.Amphibians;
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

        public AmphibianView()
        {
            InitializeComponent();
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
