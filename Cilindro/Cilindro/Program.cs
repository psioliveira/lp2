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
            const float pi = 3.1415926f;
            float raio = 0f, altura = 0f;
            string r, a;
            float V = 0f, S = 0f;
            Console.WriteLine(" ------------------------------------------------");
            Console.WriteLine("|\tCálculos de area e volume do cilíndro\t|");
            Console.WriteLine(" ------------------------------------------------");


            Console.Write(" Insira o valor do raio:  ");
            r= Console.ReadLine();
            raio = Convert.ToSingle(r);
            Console.Write("\n\nInsira o valor da altura:  ");
            a= Console.ReadLine();
            altura = Convert.ToSingle(a);

            V = pi * ((raio*raio)*altura);
            S = (2 * pi * raio )* (raio + altura);
            Console.Clear();

            Console.WriteLine(" ------------------------------------------------");
            Console.WriteLine("|\tCálculos de area e volume do cilíndro\t|");
            Console.WriteLine(" ------------------------------------------------");

            Console.WriteLine("Altura = {0}\tRaio = {1}\tPI = {2}", altura, raio, pi);
            Console.WriteLine("Volume = {0}\tArea superfície = {1}\t", V, S);



        }
    }
}
