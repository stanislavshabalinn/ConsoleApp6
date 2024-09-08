using System;

class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Напишите что-то");
        var str = Console.ReadLine();
        
        Console.WriteLine("Укажите глубину эха");
        var deep = int.Parse(Console.ReadLine());

        Echo(str, deep);

        Console.ReadKey();
        }
        static void Echo(string phrase, int deep) { 
            Console.WriteLine(phrase);

        if (deep>1)
        {
            Echo(phrase, deep - 1);
        }
        static void Echo(string saidword, int deep)
        {
            var modif = saidword;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
                var d = modif.Length;
                    Console.WriteLine("..." + modif);

                if (d > 1)
                {
                    Echo(modif, d - 1);

                    static void Echo(string saidworld, int deep);
                    {
                        var modif = saidword;

                        if (modif.Length > 2)
                        {
                            modif = modif.Remove(0, 2);
                        }
                        Console.BackgroundColor = (ConsoleColor)deep;
                        Console.WriteLine("..." + modif);

                        if (deep > 1)
                        {
                            Echo(modif, deep - 1);
                        }
                    }
                }
            }
        }
    }
}
