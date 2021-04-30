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

        public Client(Client cl)
        {
            FirstName = cl.FirstName;
            HomeTown = cl.HomeTown;
            Movie = cl.Movie;
        }
        
        public override string StrInfoOnly()
        {
            return $"{FirstName} {HomeTown} {Movie}";
        }

        public override string ToString()
        {
            return ($"Name: {FirstName}\t|\tHome Town: {HomeTown}\t|\tMovie: {Movie}");
        }

        public override bool Equals(object obj)
        {
            var otherClient = obj as Client;
            return this.FirstName==otherClient?.FirstName && this.HomeTown==otherClient?.HomeTown
                && this.Movie==otherClient?.Movie;
        }

    }
}
