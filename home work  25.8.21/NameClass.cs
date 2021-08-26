using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work__25._8._21
{
    interface IBaceName
    {
        public string  name { get; set; }
    }
    class NameClass : IBaceName
    {
        public string name { get; set; } = "propname";
        public string PrintName()
        {
            return name;
        }
        public override string ToString()
        {
            return GetType().Name;
            
        }
        
    }
    
}
