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
        public Ticket(Ticket ticket)
        {
            NameMovie = ticket.NameMovie;
            Genre = ticket.Genre;
            Rating = ticket.Rating;
            KindM = ticket.KindM;
            Price = ticket.Price;
        }

        public static Ticket operator ++(Ticket ticket1)
        {
            ticket1.Price += 100;
            return ticket1;
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
        public override bool Equals(object obj)
        {
            var otherTicket = obj as Ticket;

            return this.Genre == otherTicket?.Genre && this.KindM == otherTicket?.KindM 
                && this.Price == otherTicket?.Price && this.NameMovie == otherTicket?.NameMovie
                && this.Rating == otherTicket?.Rating; 
        }
        //public bool IsTheSame(Ticket t)
        //{
        //    if (this.NameMovie == t.NameMovie && this.Genre == t.Genre
        //        && this.KindM == t.KindM && this.Price == t.Price
        //        && this.Rating == t.Rating)
        //        return true;
        //    else { return false; }
            
        //}
         
    }
}
