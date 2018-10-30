using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Double raio = 0, altura = 0;
            string r, a;
            double V = 0, S = 0;
            Console.WriteLine(" ------------------------------------------------");
            Console.WriteLine("|\tCálculos de area e volume do cilíndro\t|");
            Console.WriteLine(" ------------------------------------------------");


            Console.Write(" Insira o valor do raio:  ");
            r= Console.ReadLine();
            raio = Convert.ToDouble(r);

            Console.Write("\n\nInsira o valor da altura:  ");
            a= Console.ReadLine();
            altura = Convert.ToDouble(a);

            V =  (Math.PI) * ((raio*raio)*altura);
            S = (2 * (Math.PI) * raio )* (raio + altura);
            Console.Clear();

            Console.WriteLine(" ------------------------------------------------");
            Console.WriteLine("|\tCálculos de area e volume do cilíndro\t|");
            Console.WriteLine(" ------------------------------------------------");

            Console.WriteLine("Altura = {0}\tRaio = {1}\tPI = {2}", altura, raio, pi);
            Console.WriteLine("Volume = {0}\tArea superfície = {1}\t", V, S);



        }
    }
}
