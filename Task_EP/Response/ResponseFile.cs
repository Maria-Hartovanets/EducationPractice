using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_EP.Response
{
    public class ResponseFile
    {
        readonly string filePath;
       
       
        List<string> response;

        public List<string> ResponesList()
        {
            return response;
        }
        public ResponseFile()
        {
            
            
            filePath = @"D:\Programming\C#\Task_EP\Task_EP\Data\Response.txt";

            response = new List<string>();

            SafetyReadItemsFromFile();
        }
        private void SafetyReadItemsFromFile()
        {
            try
            {
                response.Clear();
                ReadItemsFromFile();      
            }
            catch (Exception ex)
            {
                throw new Exception($"Error during read file: {ex.Message}");
            }
        }

        private void ReadItemsFromFile()
        {
            string str = "";
            using (var streamReader = new StreamReader(filePath))
            {
                while (!streamReader.EndOfStream)
                {
                    str = streamReader.ReadLine();
                    response.Add(str);
                }
            }
        }
        public  void AddResponse(string str)
        {
            response.Add(str);
            using (StreamWriter streamWriter = new StreamWriter(filePath, true, System.Text.Encoding.Default))
            {//only to add to the previous data file
                streamWriter.WriteLine(str); 
            }
        }
        public int GetSizeArr()
        {  
            return  response.Count;
        }
        public void MetodToRead()
        {
            SafetyReadItemsFromFile();
        }
    }
}
