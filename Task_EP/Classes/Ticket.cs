using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_EP.Classes
{
    public class Ticket: IClasses
    {
        
        public string NameMovie { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }

        public string KindM { get; set; }
        public int Price { get; set; }

        public Ticket(string nameMovie=" ", string genre = " ", int rating=0, int price =100, string kindM = " ")
           
        {
            NameMovie = nameMovie;
            Genre = genre;
            Rating = rating;
            KindM = kindM;
            Price = price;
        }

        public string StrInfoOnly()
        {
            return $"{NameMovie} {Genre} {Rating} {Price} {KindM}";
        }
       
        public override string ToString()
        {
            return $"Name: { NameMovie}\t|\tGenre: {Genre}" +
                 $"\t|\tRating: {Rating}\t|\tPrice: {Price}\t|\t  Type: {KindM}";
        }

        /// get one elem of the object
        public int GetRating()
        {
            return Rating;
        }
       
        public void ChangePrice(int value)
        {
            Price = value;
        }
    }
}
