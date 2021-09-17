using System;
using System.Collections.Generic;
using Task_EP.Classes;


namespace Task_EP.Repository
{
    public interface IRepository<T>
    {
        List<T> Array();
        void Add(T temp);
        void RemoveByIndex(int index);
        void ChangeValue(int tempNumber, int newPrice);
        string PopularObjStr();
        int GetSizeArr();
        void GetMetodToRead();
    }
}
