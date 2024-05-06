using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rublesInwallet;
            float dollarInWallet;

            int rubToUsd = 64, usdToRub = 66;
            float exchangeCurrentcyCount;

            float exchangeCurrencyCount;

            string desiredOperatiton;

            Console.WriteLine("Добро пожаловать в обмен валют!");
            Console.Write("Введите баланс руьлей: ");
            rublesInwallet = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс доларов: ");
            dollarInWallet = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("выберите операцию");
            Console.WriteLine("1-обьменять рубли на долары");
            Console.WriteLine("2- обьменять долары на рубли");
            Console.Write("Ваш выбор: ");
            desiredOperatiton = Console.ReadLine();

            switch (desiredOperatiton)
            {
                case "1":
                    Console.WriteLine("оьмен рублей на долары:");
                    Console.Write("Сколько вы хотите обменять: ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (rublesInwallet >= exchangeCurrencyCount)
                    {
                        rublesInwallet -= exchangeCurrencyCount;
                        dollarInWallet += exchangeCurrencyCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("недопустимое количество рублей");
                    }
                    break;
                case "2":
                    Console.WriteLine("Обмен доларов на рубли:");
                    Console.Write("Сколько вы хотите обменять: ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (dollarInWallet >= exchangeCurrencyCount)
                    {
                        dollarInWallet -= exchangeCurrencyCount;
                        rublesInwallet += exchangeCurrencyCount * usdToRub;

                    }
                    else
                    {
                        Console.WriteLine("недопустимое количество доларов");
                    }

                    break;
                default:
                    Console.WriteLine("Выбранна неверная операция");
                    Console.WriteLine("попробуйте еще раз");
                    break;
            }

            Console.WriteLine($"ваш баланс {rublesInwallet} рублей " + $"{dollarInWallet} доларов");


        }
    }
}
