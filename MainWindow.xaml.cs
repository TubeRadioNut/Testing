//Charles Milender
//2-25-2024
//Programming 122
//Assignment Assignment: Classes, Lists, and All of our controls
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

namespace Testing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //declare instance of Stock
        Stock inStock;
        public MainWindow()
        {
            InitializeComponent();//<--Don't delete this
            //Create a list of Vehicles
            List<Vehicle> externalList = new List<Vehicle>();
            //inticialize inStock and add list of Vehicles to it
            inStock = new Stock(externalList);
        }
        //create click event for btnAdd
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Add vehicles to instock list of Vehicles with user input for the fields
            inStock.Vehicles.Add(new Vehicle(txtMake.Text, txtModel.Text, txtYear.Text, txtVin.Text));

            
            //call the DisplayList method passing the inStock list to it
            DisplayList(inStock.Vehicles);
            
        }
        //create DisplayList() method that takes a List<Vehicle> in its parameters
        public void DisplayList(List<Vehicle> currentStock)
        {
            //clear rich text box
            rtbDisplay.Text = "";
            //loop throught List<Vehicles>
            for (int i = 0; i < currentStock.Count; i++)
            {
                //display list to rich text box using ToString() override from Vehicle class
                rtbDisplay.Text += $"{currentStock[i].ToString()}";
            }
        }
        //create click event for btnRemoveStock
        private void btnRemoveStock_Click(object sender, RoutedEventArgs e)
        {
            //create string variable for user input from txtRemoveVin
            string removeVin = txtRemoveVin.Text;
            
            //Loop through inStock.Vehicles
            for (int i = 0; inStock.Vehicles.Count > i; i++)
            {
                //test inStock.Vehicles.Vin if it matches user input
                if (inStock.Vehicles[i].Vin == removeVin)
                {
                    //remove index from list if found
                    inStock.Vehicles.Remove(inStock.Vehicles[i]);
                    //clear user input from txRemoveVin
                    txtRemoveVin.Clear();
                    //call the DisplayList method passing updated list to it
                    DisplayList(inStock.Vehicles);
                    //stop searching for Vin match with return;
                    return;
                }
        
            }
            //only gets here if Vin does not match user input(removeVin)
            MessageBox.Show($"Vehicle with VIN: {removeVin} was not found.");
            //clear user input from txRemoveVin
            txtRemoveVin.Clear();

        }
    }
}