using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work__25._8._21
{
    class item <T>
    {
        T[] SortArr = new T[6];
        public int count { get; set; } = 0;
        public string add(T Data)
        {
            if (SortArr.Length != count)
            {
                
                SortArr[count] = Data;
                count++;
                Array.Sort(SortArr);
                return $"Entered to {Data.GetType().Name} Array";
            }
            return "Error";

        }

    }
}
