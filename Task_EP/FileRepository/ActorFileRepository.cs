using System;
using Task_EP.Classes;
using Task_EP.Repository;
using System.Collections.Generic;
using System.IO;

namespace Task_EP.FileRepository
{
    public class ActorFileRepository: IRepository<Actor>
    {
        List<Actor> actorArr;
        readonly string filePath;
        readonly char delim;
        bool dataFetched;

        public ActorFileRepository() 
        {
            delim = ' ';
            dataFetched = false;
            filePath = @"D:\Programming\C#\Task_EP\Task_EP\Data\Actor.txt";
           
            actorArr = new List<Actor>();
            SafetyReadItemsFromFile();
        }
        private void WriteToFile()
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath, false))
            {
                foreach (Actor tick in actorArr)
                {
                    streamWriter.WriteLine(tick.StrInfoOnly());
                }
            }
        }
        public void SafetyReadItemsFromFile()
        {
            try
            {
                if (dataFetched)
                    return;

                actorArr.Clear();
                ReadItemsFromFile();

               
            }
            catch (Exception ex)
            {
                throw new Exception($"Error during read file: {ex.Message}");
            }
        }

        public void ReadItemsFromFile()
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
                Actor temp = ConvertToObject(strObjItems);
                actorArr.Add(temp);
            }
        }

        protected Actor ConvertToObject(string[] strObjItems)
        {
            int fieldsCount = 4;

            if (strObjItems.Length != fieldsCount)
                throw new Exception("Line is in incorrect format!");
            int tempCountMow = Convert.ToInt32(strObjItems[2]);
            int tempRating = Convert.ToInt32(strObjItems[3]);
            return new Actor(strObjItems[0], strObjItems[1], tempCountMow, tempRating);
        }


        public List<Actor> Array()
        {
            return actorArr;
        }

        public void Add(Actor temp)
        {
            actorArr.Add(temp);
            using (StreamWriter streamWriter = new StreamWriter(filePath, true, System.Text.Encoding.Default))
            {//only to add to the previous data file
                streamWriter.WriteLine(temp.StrInfoOnly());
            }
            SafetyReadItemsFromFile();
        }
        public void ChangeValue(int tempNumber, int newPrice)
        {
            foreach (IClasses actor in actorArr)
            {
                if (tempNumber < actor.GetRating())
                {
                    actor.ChangePrice(newPrice);
                }
            }
            WriteToFile();

        }

        public string PopularObjStr()
        {
            int maxRating = actorArr[0].GetRating();
            int i = 0;
            int index = 0;
            foreach (Actor actor in actorArr)
            {
                if (maxRating < actor.GetRating())
                {
                    maxRating = actor.GetRating();
                    index = i;
                }
                i++;
            }
            return actorArr[index].ToString();
        }


        public int GetSizeArr()
        {
            return (actorArr.Count == 0) ? actorArr.Count : 0;
        }

        public void RemoveByIndex(int index)
        {
            index -= 1;
            actorArr.RemoveAt(index);
            WriteToFile();
        }

        public void GetMetodToRead()
        {
            SafetyReadItemsFromFile();
        }
    }
}
