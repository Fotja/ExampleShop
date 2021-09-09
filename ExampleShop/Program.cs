using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityGoldOfBuyer;
            int numberOfCristalsOfTheBuyer;
            int priceOfCristals = 5;

            Console.WriteLine("Добро пожаловать в магазин кристалов!");
            Console.WriteLine($"Сегодня кристалы у нас можно купить по цене {priceOfCristals} золота за штуку!");
            Console.WriteLine("");

            Console.Write("Введите количество Вашего золота: ");
            quantityGoldOfBuyer = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество кристалов, которое хотите купить: ");
            numberOfCristalsOfTheBuyer = Convert.ToInt32(Console.ReadLine());
            quantityGoldOfBuyer -= numberOfCristalsOfTheBuyer * priceOfCristals;

            Console.WriteLine($"Сейчас у Вас {numberOfCristalsOfTheBuyer} залота и {quantityGoldOfBuyer} шт кристалов ");
            
            //Console.Write("Введите цену на кристалы: ");
            //priceOfCristals = Convert.ToInt32(Console.ReadLine());


        }
    }
}
