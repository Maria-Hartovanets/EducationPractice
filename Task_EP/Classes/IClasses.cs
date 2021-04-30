using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_EP.Classes
{
    public interface IClasses
    {
        string StrInfoOnly();
        int GetRating();
        void ChangePrice(int value);
        string ToString();
    }
}
