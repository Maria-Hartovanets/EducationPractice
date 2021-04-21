using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_EP.Classes
{
    public  class Human : IClasses
    {

        public string FirstName { get; set; }
        public string HomeTown { get; set; }
        public Human(string firstName = "", string homeTown = "")
        {
            FirstName = firstName;
            HomeTown = homeTown;
        }

        public virtual string InfoString()
        {
            return ($"Name: {FirstName}\t|\tHome town: {HomeTown}");
        }
        public virtual string StrInfoOnly()
        {
            return ($"{FirstName} {HomeTown}");
        }
        public virtual int GetRating()
        {
            return 0;
        }

        void IClasses.ChangePrice(int value)
        {
            throw new NotImplementedException();
        }

      
    }
}
