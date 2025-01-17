using System;

namespace Szamologep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Indit();
        }

        static void Indit(){
            Console.WriteLine("Kérem adja meg az első számot:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Kérem adja meg a második számot:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Kérem válasszon műveletet: +, -, *, /, %");
            string muvelet = Console.ReadLine();
            if (muvelet=="+"){
                System.Console.WriteLine("Az összeg: "+Osszeadas(a,b));
            }
            else if (muvelet=="-"){
                System.Console.WriteLine("A különbség: "+Kivonas(a,b));
            }
            else if (muvelet=="*"){
                System.Console.WriteLine("A szorzat: "+Szorzas(a,b));
            }
            else if (muvelet=="/"){
                System.Console.WriteLine("Az osztás: "+Osztas(a,b));
            }
            else if (muvelet=="%"){
                System.Console.WriteLine("A százalék: "+Szazalek(a,b));
            }
            else{
                System.Console.WriteLine("Nem megfelelő művelet!");
            }
        }

        static int Osszeadas(int a, int b)
        {
            return a + b;
        }
        static int Kivonas(int a, int b){
            return a-b;
        }

        static int Osztas (int a, int b){
            return a/b;
        }

        static int Szorzas (int a, int b){
            return a*b;
        }
        static int Szazalek(int a, int b){
            return a*b/100;
        }
    }
}