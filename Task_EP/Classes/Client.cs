using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_EP.Classes
{
    public class Client : Human
    {

        public string Movie { get; set; }

        public Client(string firstName="", string homeTown="", string movie="")
            : base(firstName, homeTown)
        {
            Movie = movie;
        }
        
        public override string StrInfoOnly()
        {
            return $"{FirstName} {HomeTown} {Movie}";
        }

        public override string ToString()
        {
            return ($"Name: {FirstName}\t|\tHome Town: {HomeTown}\t|\tMovie: {Movie}");
        }



    }
}
