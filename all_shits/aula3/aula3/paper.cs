using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3
{
    class paper : IFuel
    {

        public float Eficiency { get { return 32.5f; } }
        

        public void Burn()
        {
            Console.WriteLine("The paper is burning");
        }

        
    }
}
