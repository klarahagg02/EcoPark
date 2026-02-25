using EcoPark.Amphibians;
using EcoPark.AnimalsGen;
using EcoPark.Mammals;
using EcoPark.Birds;
using EcoPark.Insects;
using EcoPark.Reptiles;
using EcoPark.Arachnids;
using EcoPark.Marine;
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
    //to reach the animals atributes
    private Animal animal = new Animal();
    
    public MainWindow()
    {
        InitializeComponent();
        //fill listbox with categories from the enum CategoryType
        InitializeCategoryLstBox();
        InitializeGenders();
    }

    //to get the data from the general data section
    private void ReadGenAnimalData()
    {
        
        if (animal == null)
            return;
        
            animal.Name = txtName.Text;
            animal.Age = int.Parse(txtAge.Text);
            animal.Gender = (GenderType)Enum.Parse(typeof(GenderType),cboSelectGender.SelectedItem.ToString());
            animal.Weight = int.Parse(txtWeight.Text);
    }

    //when Add is clicked in the general data section, read the data and save it in the instance variables in the Animal class
    private void btnAddGenData_Click(object sender, RoutedEventArgs e)
    {
        ReadGenAnimalData();
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (animal == null)
            return;
        //print the data from the whole animal (cat, turtle or bee etc) in the output textbox
        txtAnimalOutput.Text = animal.ToString();
    }

    private void btnCreateAnimal_Click(object sender, RoutedEventArgs e)
    {
        //switch that reads what item in the comboboxes that were
        //selected and opens a NEW WINDOW with the correct animal category and correct species textboxes
        switch (lstCategories.SelectedItem.ToString())
        {
            case "Mammal":
                if (lstSpecies.SelectedItem is MammalSpecies selectedMammal)
                {
                    MammalView mammalView = new MammalView((int)(MammalSpecies)lstSpecies.SelectedItem);
                   // mammalView.ShowDialog();
                    if (mammalView.ShowDialog() == true)
                    {
                        // Get the created animal from the MammalView
                        animal = mammalView.Animal;
                    }
                }
                break;

            case "Amphibian":
                if (lstSpecies.SelectedItem is AmphibianSpecies selectedAmphibian)
                {
                    AmphibianView amphibianView = new AmphibianView((int)(AmphibianSpecies)lstSpecies.SelectedItem);
                    if (amphibianView.ShowDialog() == true)
                    {
                        animal = amphibianView.Animal;
                    }
                }
                break;

            case "Bird":
                if (lstSpecies.SelectedItem is BirdSpecies selectedBird)
                {
                    BirdView birdView = new BirdView((int)(BirdSpecies)lstSpecies.SelectedItem);
                    if (birdView.ShowDialog() == true)
                    {
                        animal = birdView.Animal;
                    }
                }
                break;

            case "Marine":
                if (lstSpecies.SelectedItem is MarineSpecies selectedMarine)
                {
                    MarineView marineView = new MarineView((int)(MarineSpecies)lstSpecies.SelectedItem);
                    if (marineView.ShowDialog() == true)
                    {
                        animal = marineView.Animal;
                    }
                }
                break;

            case "Insect":
                if (lstSpecies.SelectedItem is InsectSpecies selectedInsect)
                {
                    InsectView insectView = new InsectView((int)(InsectSpecies)lstSpecies.SelectedItem);
                    if (insectView.ShowDialog() == true)
                    {
                        animal = insectView.Animal;
                    }
                }
                break;

            case "Reptile":
                if (lstSpecies.SelectedItem is ReptileSpecies selectedReptile)
                {
                    ReptileView reptileView = new ReptileView((int)(ReptileSpecies)lstSpecies.SelectedItem);
                    if (reptileView.ShowDialog() == true)
                    {
                        animal = reptileView.Animal;
                    }
                }
                break;

            case "Arachnid":
                if (lstSpecies.SelectedItem is ArachnidSpecies selectedArachnid)
                {
                    ArachnidView arachnidView = new ArachnidView((int)(ArachnidSpecies)lstSpecies.SelectedItem);
                    if (arachnidView.ShowDialog() == true)
                    {
                        animal = arachnidView.Animal;
                    }
                }
                break;
        }
    }

    //method to fill comobox 1 with gategories
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

    private void InitializeGenders()
    {
        foreach (GenderType gender in Enum.GetValues(typeof(GenderType)))
        {
            cboSelectGender.Items.Add(gender);
        }
        //it automatically selects the first gender to prevent errors
        cboSelectGender.SelectedIndex = 0;
    }

    //to get the right species in the second combobox based on
    //what category is selected in the first one
    private void lstCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        //To start off with the list being empty
        lstSpecies.Items.Clear();
        //call method to fill the species list with the correct species based on the chosen category
        FillRightSpeciesList();
    }


    //help-method to fill the species list based on chosen category
    private void FillRightSpeciesList()
    {
        if (lstCategories.SelectedItem is CategoryType selectedCategory)
        {
            //do a switch case for each category and fill the species list
            //with the correct species for the chosen category
            //eventually erase the folder names?
            switch (selectedCategory)
            {
                case CategoryType.Mammal:
                    FillListOfSpecies<Mammals.MammalSpecies>();
                    break;
                case CategoryType.Amphibian:
                    FillListOfSpecies<Amphibians.AmphibianSpecies>();
                    break;
                case CategoryType.Bird:
                    FillListOfSpecies<Birds.BirdSpecies>();
                    break;
                case CategoryType.Marine:
                    FillListOfSpecies<Marine.MarineSpecies>();
                    break;
                case CategoryType.Insect:
                    FillListOfSpecies<Insects.InsectSpecies>();
                    break;
                case CategoryType.Reptile:
                    FillListOfSpecies<Reptiles.ReptileSpecies>();
                    break;
                case CategoryType.Arachnid:
                    FillListOfSpecies<Arachnids.ArachnidSpecies>();
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