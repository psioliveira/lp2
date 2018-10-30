using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3
{
    interface IFuel
    {
        float Eficiency { get; }

        void Burn();
    }
}
