using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymform
{
    class Calculo 
    {
       

        public double resultado (double peso , double repeticiones )
        {
            double r = 0.033 * peso * repeticiones + peso;
            return  r ;
        }

        
    }
}
 