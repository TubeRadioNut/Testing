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
        //Stock instock = new Stock();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            inStock.Stock.Add(new Vehicle(txtMake.Text, txtModel.Text, txtYear.Text, txtYear.Text));

            DisplayList(inStock);

        }

        public void DisplayList(List<Vehicle> inStock)
        {
            foreach (Vehicle v in inStock)
            {
                rtbDisplay.Text = $"{inStock.v}";
            }
        }
    }
}