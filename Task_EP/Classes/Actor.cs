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
        
        public static bool operator ==(Actor actor1,Actor actor2)
        {
            if (actor1.FirstName == actor2.FirstName
                && actor1.HomeTown == actor2.HomeTown
                && actor1.CountOfMovie == actor2.CountOfMovie
                && actor1.Rating == actor2.Rating)
                return true;
            else { return false; }
            
        }
        public static bool operator !=(Actor actor1, Actor actor2)
        {
            if (actor1.FirstName != actor2.FirstName
                && actor1.HomeTown != actor2.HomeTown
                && actor1.CountOfMovie != actor2.CountOfMovie
                && actor1.Rating != actor2.Rating)
                return true;
            else { return false; }
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

        public override bool Equals(object obj)
        {
            var otherActor = obj as Actor;
            return this.CountOfMovie == otherActor?.CountOfMovie && this.FirstName == otherActor?.FirstName
                && this.HomeTown == otherActor?.HomeTown && this.Rating == otherActor?.Rating;
        }

    }
}
