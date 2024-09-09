using System;
using System.ComponentModel.Design;
using System.Drawing;

class MainClass
{
    public static void Main(string[] args)

    {
        var User = GetData();
        ShowData(User.Item1, User.Item2, User.Item3, User.Item4, User.Item5, User.Item6, User.Item7, User.Item8);


        static (string, string, int, bool, int, string[], int, string[]) GetData()
        {
            Console.WriteLine("Введите свое имя");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию");
            string Surname = Console.ReadLine();
            Console.WriteLine("Введите возраст пользователя цифрами");
            int Age = Proverka();
            Console.WriteLine("Есть ли у вас животные");
            bool HavePet = Console.ReadLine() == "Да" ? true : false;
            int Pets;
            string[] PetNames;
            if (HavePet)
            {
                Console.WriteLine("Сколько у вас животных");
                Pets = Proverka();
                PetNames = new string[Pets];
                for (int i = 0; i < Pets; i++)
                {
                    Console.WriteLine("Как зовут ваше животное");
                    PetNames[i] = Console.ReadLine();
                }
            }
            else
            {
                Pets = 0;
                PetNames = new string[1] { "Нет домашних питомцев" };
            }

            Console.WriteLine("Сколько у вас любимых цветов?");
            int Colors = Proverka();
            string[] ColorsNames = new string[Colors];
            for (int i = 0; i < Colors; i++)
            {
                Console.WriteLine("Какие любимые цвета?");
                ColorsNames[i] = Console.ReadLine();
            }

            return (Name, Surname, Age, HavePet, Pets, PetNames, Colors, ColorsNames);
        }

        static void ShowData(string Name, string Surname, int Age, bool HavePet, int Pets, string[] PetNames, int Colors, string[] ColorsNames)
        {
            Console.WriteLine(Name + " " + Surname);
            Console.WriteLine(Age);
            Console.WriteLine(HavePet);
            Console.WriteLine(Pets);
            foreach (string PetName in PetNames)
             {
                Console.WriteLine(PetName);
                
            }
          
        }

        static int Proverka()
        {
            int Number = 0;
            bool b = true;
            int Age = 0;
            const int MinAge = 0;
            const int MaxAge = 100;

            while (b)
            {
                b = false;
                string a = Console.ReadLine();

                try
                {
                    Age = Int32.Parse(a);
                }
                catch
                {
                    Console.WriteLine("Возоаст должен быть числом.");
                    b = true;
                }

                if (Age < MinAge || Age > MaxAge)
                {
                    Console.WriteLine("Возоаст должен быть цифрами от 0 до 120");
                    b = true;
                }
            }
            return Age;
        }
    }
}