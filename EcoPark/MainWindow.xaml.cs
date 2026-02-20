using EcoPark.AnimalsGen;
using EcoPark.View;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EcoPark;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        InitializeCategoryLstBox();
        //fyll comboboxarna med listor på djur som default
    }

    //fill combobox with categoryType enum

    //fill other combobox with speciesType enum
    //based on what category is selected

    //?
    Window view = null;

    private void ReadGenAnimalData()
    {
        //how do i reach them from the instance vaiables in Animal?
        //Id?
        //Name = txtName.Text;
        //Age = int.Parse(txtAge.Text);
        //Gender = cboSelectGender.SelectedItem.ToString();
        //Weight = int.Parse(txtWeight.Text);
    }

    private void btnAddGenData_Click(object sender, RoutedEventArgs e)
    {

    }

    private void btnCreateAnimal_Click(object sender, RoutedEventArgs e)
    {
        //write code that reads what item in the comboboxes that were
        //selected and opens a NEW WINDOW with the correct animal category and species
        switch (lstCategories.SelectedItem.ToString())
        {
            case "Mammal":
                //mammalView.Show();
                break;
            case "Amphibian":
                //amphibianView.Show();
                break;
            case "Bird":
                //birdView.Show();
                break;
            case "Marine":
                //marineView.Show();
                break;
            case "Insect":
                //insectView.Show();
                break;
            case "Reptile":
                //reptileView.Show();
                break;
            case "Arachnid":
                //arachnidView.Show();
                break;
        }
    }

    // Metod för att fylla comboboxen med pirattitlar
    private void InitializeCategoryLstBox()
    {
        foreach (CategoryType animalCategory in Enum.GetValues(typeof(CategoryType)))
        {
            lstCategories.Items.Add(animalCategory);
        }
        //to select the first item in the list by default,
        //to prevent errors when trying to read the selected item
        //before the user has selected anything
        lstCategories.SelectedIndex = 0;
    }

    //to get the right species in the second combobox based on
    //what category is selected in the first one
    private void lstCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        //To start off with the list being empty
        lstSpecies.Items.Clear();

        if (lstCategories.SelectedItem is CategoryType selectedCategory)
        {
            //do a switch case for each category and fill the species list
            //with the correct species for the chosen category
            switch (selectedCategory)
            {
                case CategoryType.Mammal:
                    FillListOfSpecies<Mammals.MammalSpecies>();
                    break;
                case CategoryType.Amphibian:
                    FillListOfSpecies<Amphibians.AmphibianSpecies>();
                    break;
            }
        }
    }

    //help-method to fill the species list with the correct species based on the chosen category
    private void FillListOfSpecies<T>() where T : Enum
    {
        //loop through the enum values of the species type and add them to the listOfSpecies
        foreach (T species in Enum.GetValues(typeof(T)))
        {
            lstSpecies.Items.Add(species);
        }
        //default to select first item to prevent errors if user doesnt click anything
        lstSpecies.SelectedIndex = 0;
    }

    private void ComboBox_GenderSelection(object sender, SelectionChangedEventArgs e)
    {

    }

  
}