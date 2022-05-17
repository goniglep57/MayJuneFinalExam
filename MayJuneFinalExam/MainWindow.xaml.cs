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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MayJuneFinalExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //creating list that will hae all the properties
        List<RentalProperty> allProperties;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //getting a db for the rental data
            RentalData db = new RentalData();

            //sorting by price
            var query = from p in db.Properties
                        orderby p.Price
                        select p;
            allProperties = query.ToList();

            //setting the results to the listbox
            lbxProperties.ItemsSource = allProperties;


        }

        private void lbxProperties_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Determine what was selected
            RentalProperty selected = lbxProperties.SelectedItem as RentalProperty;
            //check not null
            if (selected != null)
            {

                //update display
                tblkDescription.Text = selected.Description;
                

            }
        }
    }
}
