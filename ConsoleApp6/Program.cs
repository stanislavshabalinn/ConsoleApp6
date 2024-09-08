using System;
using System.Drawing;

class MainClass
{
    public static void Main(string[] args)
    {
        (string Name, string Lastname, int Age, bool HasPet, string[] colors) Enteruser;
        {
            (string Name, string Lastname, int Age, bool HasPet, string[] colors) user;

            Console.WriteLine("Введите свое имя");
            user.Name = Console.ReadLine();

            Console.WriteLine("Введите свою фамилию");
            user.Lastname = Console.ReadLine();

            bool validAge = false;
            while (!validAge)
            {
                try
                {
                    Console.Write("Введите возраст: ");
                    int Age = int.Parse(Console.ReadLine());
                    validAge = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: возраст должен быть целым числом.");
                }

                Console.WriteLine("Есть ли у вас животные? Да или нет");
                var result = Console.ReadLine();
                if (result == "Да")
                {
                    user.HasPet = true;
                    Console.WriteLine("перечислите всех ваших домашних питомцев");

                }
                else
                {
                    user.HasPet = false;

                    user.colors = new string[3];
                    Console.WriteLine("Введите любимыe цвета");

                    for (int i = 0; i < user.colors.Length; i++)
                    {
                        user.colors[i] = Console.ReadLine();

                    }
                }
                Console.WriteLine($"Вы ввели: Имя - {user.Name},Фамилия - {user.Lastname}, Возраст - {int.MinValue}, Домашние питомцы - {user.HasPet}, Любимые цвета -{0}");
            }
        }
    }
}