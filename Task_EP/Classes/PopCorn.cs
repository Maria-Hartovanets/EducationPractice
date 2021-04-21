using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_EP.Classes
{
    public class PopCorn
    {
        readonly string filePath;

        public int Caramel { get; set; }
        public int Chesse { get; set; }
        public int Bacon { get; set; }
        public int Salt { get; set; }
        public int Sugar { get; set; }
        public int Chocolate { get; set; }
        public PopCorn()
        {
            filePath = @"D:\Programming\C#\Task_EP\Task_EP\Data\PopCorn.txt";

            Caramel = 0;
            Chesse =0;
            Bacon = 0;
            Salt =0;
            Sugar = 0;
            Chocolate = 0;
            ReadItemsFromFile();

        }
        private void ReadItemsFromFile()
        {
            StreamReader streamReader = new StreamReader(filePath);
            Caramel = Convert.ToInt32(streamReader.ReadLine());
            Chesse= Convert.ToInt32(streamReader.ReadLine());
            Bacon= Convert.ToInt32(streamReader.ReadLine());
            Salt= Convert.ToInt32(streamReader.ReadLine());
            Sugar= Convert.ToInt32(streamReader.ReadLine());
            Chocolate= Convert.ToInt32(streamReader.ReadLine());
        }
        public string StringInfo()
        {
            return "Caramel: " + Caramel.ToString() + "\nChesse: " + Chesse.ToString() +
                "\nBacon: " + Bacon.ToString() + "\nSalted: " + Salt.ToString() +
                "\nSugar: " + Sugar.ToString() + "\nChocolate: " + Chocolate.ToString();
        }
       
    }
}
