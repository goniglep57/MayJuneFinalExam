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

        //link
        //https://github.com/goniglep57/MayJuneFinalExam.git
        //creating list that will hae all the properties
        List<RentalProperty> allProperties;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //getting a db for the rental data
            RentalData1 db = new RentalData1();

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

        private void AddPropertyButton_Click(object sender, RoutedEventArgs e)
        {
            AddProperty addPage = new AddProperty();

            this.Close();
            addPage.Show();

            addPage.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
    }
}
