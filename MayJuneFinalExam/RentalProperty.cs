using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }//end of class
}
