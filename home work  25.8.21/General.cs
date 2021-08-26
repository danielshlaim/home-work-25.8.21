using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work__25._8._21
{
    class Basic
    {
        public int Id  { get; set; }
    }
    class  student : Basic
    {
        public override string ToString()
        {
            return "student";
        }
    }
    class Course : Basic
    {
        public override string ToString()
        {
            return "course";
        }
    }
    class General <T> where T : Basic 
    {
        public int count { get; set; }
        T[] Tarr = new T[3];
      public string  Add(T Data)
        {  
            Tarr[count++] = Data;
            return Data.ToString();
        }
        
        
        

    }
}
