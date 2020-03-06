using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            ClassLibraryAddition.Expression exp1 = new ClassLibraryAddition.Addition(new ClassLibraryAddition.Nombre(33),
    new ClassLibraryAddition.Nombre(33));


            ClassLibraryAddition.Expression exp2 = new ClassLibraryAddition.Addition(new ClassLibraryAddition.Nombre(33),
                new ClassLibraryAddition.Addition(new ClassLibraryAddition.Nombre(33),
                new ClassLibraryAddition.Nombre(11)));


            ClassLibraryAddition.Expression exp3 = new ClassLibraryAddition.Soustraction(new ClassLibraryAddition.Nombre(33),
    new ClassLibraryAddition.Nombre(33));
            int resultat3 = exp3.Evalue();
            string str3 = exp3.Format();

            ClassLibraryAddition.Expression exp4 = new ClassLibraryAddition.Soustraction(new ClassLibraryAddition.Nombre(33),
    new ClassLibraryAddition.Addition(new ClassLibraryAddition.Nombre(33),
                new ClassLibraryAddition.Nombre(11)));



            Console.WriteLine("Addition simple 33+33");
            Console.WriteLine(exp1);

            Console.WriteLine("Addition composé 33+33+11");
            Console.WriteLine(exp2);

            Console.WriteLine("Soustraction 33-33");
            Console.WriteLine(exp3);

            Console.WriteLine("Soustraction composé 33-(33+11)");
            Console.WriteLine(exp4);

            Console.ReadKey();


        }
    }
}
