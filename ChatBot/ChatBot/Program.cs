using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {

            bool _exit = false;
            string _q;

            Console.WriteLine("\t|------------------------|");
            Console.WriteLine("\t| Bem vindo ao ChatBot!! |");
            Console.WriteLine("\t|------------------------|");
           
            Console.WriteLine("\n\nOlá ,me faça perguntas \\( º u º )/ ");


            while (_exit == false)
            {

                _q = Console.ReadLine();

                switch (_q)
                {

                    case "quem é voce?":

                        Console.WriteLine("\nEu sou o ChatBot!! estou aqui para conversar cobtigo （＾ｖ＾）");
                        break;

                    case "o que podes fazer?":

                        Console.WriteLine( "\nEou consigo te responder algumas questões, ainda não sei tudo (；V；)");
                        Console.WriteLine( "Mas um dia saberei  ( o U o )");
                        Console.Write("\nSempre saberei responder essas questões: \n- quem é voce?\n- de onde vens?\n- sabes quantas linguas?\n- sabes quantas linguas?\n- adeus");
                        break;

                    case "de onde vens?":

                        Console.WriteLine( "\nNão sei bem... aliás... quem sabe de onde viemos todos?? （・o・）");
                        break;

                    case "sabes quantas linguas?":

                        Console.WriteLine( "\nPor enquanto só Português, mas um dia saberei mais ( > v < )");
                        break;

                    case "adeus":

                        Console.WriteLine("\nAté a proxima !! （＾ｖ＾）" );
                        _exit = true;

                        break;

                    default:
                        Console.WriteLine("\nEu ainda não sei responder isto  (T --- T ) ");
                        break;
                        
                }

                if (_exit == false)
                {
                    Console.Write("\n \n Me faça mais perguntas !! ∩( ・v・)∩ \n");
                }

            }
        }
    }
}
