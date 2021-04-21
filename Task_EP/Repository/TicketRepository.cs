using System;
using Task_EP.Classes;
using System.Collections.Generic;


namespace Task_EP.Repository
{
    public class TicketRepository : IRepository<Ticket>
    {
        bool data;
        List<Ticket> ticketArr;

        public int GetSizeArr()
        {
            return ticketArr.Count;
        }
       
        public TicketRepository(bool data=false)
        {
            this.data = data;
            ticketArr = new List<Ticket>();
        }
        public void Add(Ticket temp)
        {
            ticketArr.Add(temp);
        }

        public List<Ticket> Array()
        {
            return ticketArr;
        }

        public string PopularObjStr()
        {
            int maxRating = ticketArr[0].GetRating();
            int i = 0;
            int index = 0;
            foreach (IClasses movie in ticketArr)
            {
                if (maxRating < movie.GetRating())
                {
                    maxRating = movie.GetRating();
                    index = i;
                }
                i++;
            }
            return ticketArr[index].ToString();
        }

        public void ChangeValue(int tempNumber, int newPrice)
        {
            foreach (IClasses tickt in ticketArr)
            {
                if (tempNumber < tickt.GetRating())
                {
                    tickt.ChangePrice(newPrice);
                }
            }

        }

        public void RemoveByIndex(int index)
        {
            index -= 1;
            ticketArr.RemoveAt(index);
        }

        public void GetMetodToRead()
        {
            throw new NotImplementedException();
        }
    }
}
