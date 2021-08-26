using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work__25._8._21
{
    class ClassCombine <T>
    {
        public string Combine(T[] arr1 , T[] arr2)
        {
            int i = 0;
            T[] allarr = new T[arr1.Length + arr2.Length];
            foreach (var item in arr1)
            {
                allarr[i++] = item;
            }
            foreach (var item in arr2)
            {
                allarr[i++] = item;
            }
            return allarr.Length.ToString();
             
        }
    }
}
