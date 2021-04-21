using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_EP.Classes
{
     public class Actor : Human
    {
     
        public int CountOfMovie { get; set; }
        public int Rating { get; set; }

        public Actor(string firstName="", string homeTown="", int counrOfMovie=0 , int rating=0) 
            : base(firstName, homeTown)
        {
            CountOfMovie = counrOfMovie;
            Rating = rating;
          
        }
        public override int GetRating()
        {
            return Rating;
        }
        public override string StrInfoOnly()
        {
            return $"{FirstName} {HomeTown} {CountOfMovie} {Rating}";
        }
       
        public override string ToString()
        {
            return ($"Name: {FirstName}\t|\tHome Town: {HomeTown}" +
                 $"\t|\tAct in movies: {CountOfMovie}\t|\tRating: {Rating}");
        }
        
    }
}
