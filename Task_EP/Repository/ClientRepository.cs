using System;
using Task_EP.Classes;
using System.Collections.Generic;


namespace Task_EP.Repository
{
    public class ClientRepository : IRepository<Client>
    {
        bool data;
        List<Client> clientArr;

        public ClientRepository(bool data = false)
        {
            this.data = data;
            clientArr = new List<Client>();
        }

        public void Add(Client temp)
        {
            clientArr.Add(temp);
        }

       
        public List<Client> Array()
        {
          
            return clientArr;
        }
        public int GetSizeArr()
        {
            return clientArr.Count;
        }

        public void ChangeValue(int tempNumber, int newPrice)
        {
            throw new NotImplementedException();
        }

        public string PopularObjStr()
        {
            throw new NotImplementedException();
        }

        public void RemoveByIndex(int index)
        {
            index -= 1;
            clientArr.RemoveAt(index);
            
        }

        public void GetMetodToRead()
        {
            throw new NotImplementedException();
        }
    }
}
