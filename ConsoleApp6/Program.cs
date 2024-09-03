using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Xml.Linq;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Stas";
            byte Myage = 49;
            bool HaveIApet = true;
            double MуShoeSise = 42.5;


            Console.WriteLine("My name is" + MyName);
            Console.WriteLine("Myage"+ Myage);
            Console.WriteLine("Do I have a pet?"+ HaveIApet);
            Console.WriteLine("My shoe size is"+ MуShoeSise);
            
            Console.ReadKey();
        }
    }
}
