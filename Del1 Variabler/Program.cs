using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Del1_Variabler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oppg 2
            Console.WriteLine("Hallo verden!!!");

            //Oppg 3
            Console.WriteLine("\nVennligst skriv et navn"); //Jeg bruker \n for å få et mellomrom mellom deloppgavene
            string navn1 = Console.ReadLine(); //.ReadLine() omgjør det brukeren skriver på linjen til en string variabel
            Console.WriteLine("Hei, " + navn1);
            Console.WriteLine($"Hei, {navn1}"); //Her er to forskjellige måter å skrive ut "Hei, navn1" linjen på

            //Oppg 4
            int tall1 = 13; //Når du definerer en integer så må du ikke bruke ""
            int tall2 = 9;
            Console.WriteLine($"\n{tall1}\n{tall2}");
            Console.WriteLine(tall1 + "\n" + tall2); //To forskjellige måter å gjøre det på

            //Oppg 5
            Console.WriteLine("\nVennligst si et navn til");
            string navn2 = Console.ReadLine();
            string sammen = navn1 + navn2; //Her slår jeg sammen to variabler og lagrer dem som en ny stringvariabel
            Console.WriteLine(sammen); //Når du bare skal skrive ut en variabel så trnger du ikke ""

            //Oppg 6
            sammen = navn1 + " og " + navn2; //her gjør jeg det samme, men legger til " og " for å få mellomrom mellom navnene
            Console.WriteLine(sammen);

            Console.ReadLine(); //For å hindre at programmet lukker seg ummidelbart
        }
    }
}
