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
using EcoParkV2.AnimalsGen;

namespace EcoPark;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private AnimalManager animalManager = new AnimalManager();
    //to reach all attributes in genreal data, category data and species data
    private Animal? animal = null;

    //main constructor
    public MainWindow()
    {
        InitializeComponent();
        InitializeCategoryLstBox();
        InitializeGenders();
    }

    //to get the data from the general data info
    private void ReadGenAnimalData()
    {
        //a lot of if-statements to check if the input is valid, and if not, show a messagebox to prevent crashing. 
        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            MessageBox.Show("Fill in the name", "Name is missing", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }
        if (!int.TryParse(txtAge.Text, out int age) || age < 0)
        {
            MessageBox.Show("Write a valid age (0 or more years)", "Invalid age", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }
        if (cboSelectGender.SelectedItem == null)
        {
            MessageBox.Show("Choose a gender", "Gender missing", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }
        if (!int.TryParse(txtWeight.Text, out int weight) || weight <= 0)
        {
            MessageBox.Show("Write a valid weight", "Invalid weight", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }

        animal.Name = txtName.Text;
        animal.Age = int.Parse(txtAge.Text);
        animal.Gender = (GenderType)Enum.Parse(typeof(GenderType),cboSelectGender.SelectedItem.ToString());
        animal.Weight = int.Parse(txtWeight.Text);
    }

    //when the button Add is clicked, the program calls rhe read-general-data method and then updates 
    //the UI to show the object's data in the output, including an unique ID through AnimalManager
    private void btnAddGenData_Click(object sender, RoutedEventArgs e)
    {
        ReadGenAnimalData();

        //put this as its own method that is called instead if i have time
        if (animal != null)
        {
            if (string.IsNullOrWhiteSpace(animal.Id))
            {
                animalManager.AddAnimal(animal);
            }
            else if (!animalManager.ListOfAnimals.Contains(animal))
            {
                animalManager.Add(animal);
            }
        }
        UpdateUI();
    }

    //method for updating the output  with all data from the animal object.
    private void UpdateUI()
    {
        if (animal == null)
            return;
        //print the data from the whole animal (cat, turtle, bee etc) in the output
        txtAnimalOutput.Text = animal.ToString();
        //calls method to refresh list of all added animals
        RefreshAnimalList();
    }

    //refreshes the listbox in the UI to show updated list of all added animals
    private void RefreshAnimalList()
    {
        //begin with clear list and then loop through animals
        lstListOfAnimals.Items.Clear();
        foreach (Animal animal in animalManager.ListOfAnimals)
        {
            //uses ToStringSummary to show general info about species in listbox
            lstListOfAnimals.Items.Add(animal.ToStringSummary());
        }
    }

    //when the button Create Animal is clicked, based on selected cetegory+species, a new window opens and
    //based on the data input in that window, a new animal object is created and the data comes back to the main Window
    private void btnCreateAnimal_Click(object sender, RoutedEventArgs e)
    {
        switch (lstCategories.SelectedItem.ToString())
        {
            case "Mammal":
                if (lstSpecies.SelectedItem is MammalSpecies selectedMammal)
                {
                    MammalView mammalView = new MammalView((int)(MammalSpecies)lstSpecies.SelectedItem);
                    if (mammalView.ShowDialog() == true)
                    {
                        // Get the created animal from the MammalView
                        animal = mammalView.Animal;
                        if (animal != null)
                            animal.Category = CategoryType.Mammal;
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
                        if (animal != null)
                            animal.Category = CategoryType.Amphibian;
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
                        if (animal != null)
                            animal.Category = CategoryType.Bird;
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
                        if (animal != null)
                            animal.Category = CategoryType.Marine;
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
                        if (animal != null)
                            animal.Category = CategoryType.Insect;
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
                        if (animal != null)
                            animal.Category = CategoryType.Reptile;
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
                        if (animal != null)
                            animal.Category = CategoryType.Arachnid;
                    }
                }
                break;
        }
    }

    //method to fill comobox 1 with animal gategories
    private void InitializeCategoryLstBox()
    {
        //loops through enum CategoryType and adds each category to the listbox
        foreach (CategoryType animalCategory in Enum.GetValues(typeof(CategoryType)))
        {
            lstCategories.Items.Add(animalCategory);
        }
        //it automatically selects the first animal to prevent errors
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

    //to get the right species in combobox 2 based on
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
            switch (selectedCategory)
            {
                case CategoryType.Mammal:
                    FillListOfSpecies<MammalSpecies>();
                    break;
                case CategoryType.Amphibian:
                    FillListOfSpecies<AmphibianSpecies>();
                    break;
                case CategoryType.Bird:
                    FillListOfSpecies<BirdSpecies>();
                    break;
                case CategoryType.Marine:
                    FillListOfSpecies<MarineSpecies>();
                    break;
                case CategoryType.Insect:
                    FillListOfSpecies<InsectSpecies>();
                    break;
                case CategoryType.Reptile:
                    FillListOfSpecies<ReptileSpecies>();
                    break;
                case CategoryType.Arachnid:
                    FillListOfSpecies<ArachnidSpecies>();
                    break;
            }
        }
    }

    //help-method to fill the species list with the correct species based on the chosen category
    private void FillListOfSpecies<T>() where T : Enum
    {
        //loop through the enum values of the species type and add them to istOfSpecies
        foreach (T species in Enum.GetValues(typeof(T)))
        {
            lstSpecies.Items.Add(species);
        }
        //default to select first item to prevent errors if user doesn't click anything
        lstSpecies.SelectedIndex = 0;
    }

    //so that the combobox will work in the UI
    private void ComboBox_GenderSelection(object sender, SelectionChangedEventArgs e)
    {

    }

    private void btnDelete_Click(object sender, RoutedEventArgs e)
    {
        //implement code for deleting specific animal in list with help from listmanager
    }
}