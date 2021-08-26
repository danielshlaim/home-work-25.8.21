using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work__25._8._21
{
   public class ReadOnlyGenerics <T>
    {
        public bool IsReadOnly { get; set; }
        T[] Switch = new T[10];
        public int count { get; set; } = 0;
        public void Add(T Data)
        {
            if (IsReadOnly == true)
            {
                throw new InvalidOperationException("you cant add");
            }
            else
            {
                Switch[count++] = Data;
                //count++;
            }
        } 
        public void ChangeReadOnly()
        {
            IsReadOnly = !IsReadOnly; // אתה שווה לעצמך רק ההפך  (חוסך איפ אלס)1
        }
	
	

	
    }
}
