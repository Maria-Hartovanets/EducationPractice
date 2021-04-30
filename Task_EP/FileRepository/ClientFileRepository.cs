using System;
using Task_EP.Classes;
using Task_EP.Repository;
using System.Collections.Generic;
using System.IO;


namespace Task_EP.FileRepository
{
    public class ClientFileRepository: IRepository<Client>
    {
        List<Client> clientArr;
        readonly string filePath;
        readonly char delim;
        bool dataFetched;

        public ClientFileRepository()
        {
            delim = ' ';
            dataFetched = false;
            filePath = @"D:\Programming\C#\Task_EP\Task_EP\Data\Client.txt";

            clientArr = new List<Client>();
            SafetyReadItemsFromFile();
        }
        private void WriteToFile()
        {
            if (clientArr.Count != 0)
            {
                using (StreamWriter streamWriter = new StreamWriter(filePath, false))
                {
                    foreach (Client client in clientArr)
                    {
                        streamWriter.WriteLine(client.StrInfoOnly());
                    }
                }
            }
            else 
            {
                StreamWriter streamWriter = new StreamWriter(filePath, false);
                streamWriter.WriteLine("Empty arr!");
            }
        }
        private void SafetyReadItemsFromFile()
        {
            try
            {
                if (dataFetched)
                    return;

                clientArr.Clear();
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
                Client temp = ConvertToObject(strObjItems);
                clientArr.Add(temp);
            }
        }

        protected Client ConvertToObject(string[] strObjItems)
        {
            int fieldsCount = 3;

            if (strObjItems.Length != fieldsCount)
                throw new Exception("Line is in incorrect format!");
           
            return new Client(strObjItems[0], strObjItems[1], strObjItems[2]);
        }


        public List<Client> Array()
        {
            return clientArr;
        }

        public void Add(Client temp)
        {
            clientArr.Add(temp);
            using (StreamWriter streamWriter = new StreamWriter(filePath, true, System.Text.Encoding.Default))
            {//only to add to the previous data file
                streamWriter.WriteLine(temp.StrInfoOnly());
            }
            SafetyReadItemsFromFile();
        }
        public void ChangeValue(int tempNumber, int newPrice)
        {
            foreach (IClasses client in clientArr)
            {
                if (tempNumber < client.GetRating())
                {
                    client.ChangePrice(newPrice);
                }
            }
            WriteToFile();

        }

        public string PopularObjStr()
        {
            return null;
        }

        public int GetSizeArr()
        {
            return (clientArr.Count == 0) ? clientArr.Count : 0;
        }

        public void RemoveByIndex(int index)
        {
            index -= 1;
            clientArr.RemoveAt(index);
        }

        public void GetMetodToRead()
        {
            SafetyReadItemsFromFile();
        }

        public void RemoveAllItems()
        {
            clientArr.Clear();
            WriteToFile();
           
        }
    }
}
