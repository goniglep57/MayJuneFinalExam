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

namespace MayJuneFinalExam
{
    /// <summary>
    /// Interaction logic for AddProperty.xaml
    /// </summary>
    public partial class AddProperty : Window
    {
        RentalData1 db = new RentalData1();
        public AddProperty()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbxType.ItemsSource = Enum.GetValues(typeof(RentalType));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string location = tblkLocation.Text;
            string price =   tblkPrice.Text;

            decimal realPrice = Convert.ToDecimal(price);
            RentalType rentalType = (RentalType)cbxType.SelectedItem;

           
            RentalProperty newProp = new RentalProperty()
            {
                Price = realPrice,
                Location = location,
                RentalType = rentalType,
                PropImage = "\\Images\\share.png"



            };

            db.Properties.Add(newProp);

            db.SaveChanges();
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {

           
            MainWindow mw = new MainWindow();

            mw.Show();

            this.Close();
        }
    }
}
