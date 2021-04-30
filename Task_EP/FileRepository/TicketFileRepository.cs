using System;
using Task_EP.Classes;
using Task_EP.Repository;
using System.Collections.Generic;
using System.IO;

namespace Task_EP.FileRepository
{
    public class TicketFileRepository: IRepository<Ticket>
    {
       
        List<Ticket> ticketArr;
        readonly string filePath;
        readonly char delim;
        bool dataFetched;

        public TicketFileRepository()
        {
            delim = ' ';
            dataFetched = false;
            filePath = @"D:\Programming\C#\Task_EP\Task_EP\Data\Ticket.txt";
           
            ticketArr = new List<Ticket>();
            SafetyReadItemsFromFile();
        }
        private void WriteToFile()
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath, false))
            {
                foreach(IClasses tick in ticketArr)
                {
                    streamWriter.WriteLine(tick.StrInfoOnly());
                }
            }
        }
        private void SafetyReadItemsFromFile()
        {
            try
            {
                if (dataFetched)
                    return;

                ticketArr.Clear();
                ReadItemsFromFile();

                
            }
            catch (Exception ex)
            {
                throw new Exception($"Error during read file: {ex.Message}");
            }
        }

        private void ReadItemsFromFile()
        {
            using (var streamReader = new StreamReader(filePath))
            {
                ReadItemsFromStream(streamReader);
            }
        }

        private void ReadItemsFromStream(StreamReader streamReader)
        {
            string fileLine;
           // Init();

            while ((fileLine = streamReader.ReadLine()) != null)
            {
                string[] strObjItems = fileLine.Split(delim);
                Ticket temp =ConvertToObject(strObjItems);
                ticketArr.Add(temp);
            }
        }

        protected  Ticket ConvertToObject(string[] strObjItems)
        {
            int fieldsCount = 5;

            if (strObjItems.Length != fieldsCount)
                throw new Exception("Line is in incorrect format!");
            int tempPrice = Convert.ToInt32(strObjItems[3]);
            int tempRating = Convert.ToInt32(strObjItems[2]);
            return new Ticket(strObjItems[0], strObjItems[1], tempRating, tempPrice,strObjItems[4]);
        }
       

        public List<Ticket> Array()
        {
            return ticketArr;
        }

        public void Add(Ticket temp)
        {
            ticketArr.Add(temp);
            using (StreamWriter streamWriter = new StreamWriter(filePath, true, System.Text.Encoding.Default))
            {//only to add to the previous data file
                streamWriter.WriteLine(temp.StrInfoOnly());
            }
            SafetyReadItemsFromFile();
        }
        public void ChangeValue(int tempNumber, int newPrice)
        {
            foreach (Ticket tickt in ticketArr)
            {
                if (tempNumber < tickt.GetRating())
                {
                    tickt.ChangePrice(newPrice);
                }
            }
            WriteToFile();
            
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
        public int GetSizeArr()
        {
            return (ticketArr.Count == 0) ? ticketArr.Count : 0;
        }

        public void RemoveByIndex(int index)
        {
            index -= 1;
            ticketArr.RemoveAt(index);
            WriteToFile();
        }

        public void GetMetodToRead()
        {
            SafetyReadItemsFromFile();
        }

        public Ticket TheWorstTicket()
        {
            int minRating = ticketArr[0].GetRating();
            int i = 0;
            int index = 0;
            

            foreach (IClasses movie in ticketArr)
            {
                if (minRating > movie.GetRating())
                {
                    minRating = movie.GetRating();
                    index = i;
                }
                i++;
            }
            return ticketArr[index];

        }
    }
}
