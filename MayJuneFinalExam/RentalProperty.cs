using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace MayJuneFinalExam
{
    public enum RentalType//enum
    {
        House,
        Flat,
        Share
    }
    public class RentalProperty//class for property
    {
        //properties
        public int ID { get; set; }

        public RentalType RentalType { get; set; }

        public string Location { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        //constructors

        //methods
        public void IncreaseRent(decimal increase)
        {
            Price +=   Price * increase;
        }
    }//end of class

    public class RentalData : DbContext
    {
        public RentalData() : base("MyRentalData") { }

        public DbSet<RentalProperty> Properties { get; set; }
    }
}
