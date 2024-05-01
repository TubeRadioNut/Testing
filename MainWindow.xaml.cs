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
        
        Stock inStock;
        public MainWindow()
        {
            InitializeComponent();//<--Don't delete this
            List<Vehicle> externalList = new List<Vehicle>();
            inStock = new Stock(externalList);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            inStock.Vehicles.Add(new Vehicle(txtMake.Text, txtModel.Text, txtYear.Text, txtVin.Text));

            
            
            DisplayList(inStock.Vehicles);
            
        }

        public void DisplayList(List<Vehicle> currentStock)
        {
            
            rtbDisplay.Text = "";
            for (int i = 0; i < currentStock.Count; i++)
            {
                
                rtbDisplay.Text += $"{currentStock[i].ToString()}";
                
                
            }

        }

        private void btnRemoveStock_Click(object sender, RoutedEventArgs e)
        {
            string removeVin = txtRemoveVin.Text;
            

            for (int i = 0; inStock.Vehicles.Count > i; i++)
            {
                
                if (inStock.Vehicles[i].Vin == removeVin)
                {
                    inStock.Vehicles.Remove(inStock.Vehicles[i]);
                    txtRemoveVin.Clear();
                    DisplayList(inStock.Vehicles);
                    return;
                }
        
            }

            MessageBox.Show($"Vehicle with VIN: {removeVin} was not found.");
            
        }
    }
}