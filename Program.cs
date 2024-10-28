using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    internal class Program
    {
        class Myclass{
            public int add(int a, int b);
            public int sub(int a, int b);
        }
        static void Main(string[] args)
        {
            Myclass obj = new Myclass(); // obj Название объекта  его можно заменить чем угодно Myclass Название класса 
            Console.WriteLine(obj.add(5,6)); //obj.add вызываем определенную функцию(add)
            Console.ReadKey(); // Задержка экрана

            Proverka p = new Proverka();
            Vichislenie v = new Vichislenie();
            int n = 0;
            double a, b, res;
            do
            {
                Console.WriteLine("Выберите операцию\n 1- сложение \n 2-вычитание \n 3-умножение \n 4- деление \n 9 - выход");
                n = Convert.ToInt32(p.prov());
                switch (n)
                {
                    case 1:
                        a = p.prov(); b = p.prov(); res = v.add(a, b); 
                        Console.WriteLine("{0} + {1} = {2}", a, b, res); 
                        break;
                    case 2:
                        a = p.prov(); b = p.prov(); res = v.sub(a, b);
                        Console.WriteLine("{0} - {1} = {2}", a, b, res);
                        break;
                    case 3:
                        a = p.prov(); b = p.prov(); res = v.mul (a, b);
                        Console.WriteLine("{0} * {1} = {2}", a, b, res);
                        break;
                    case 4:
                        a = p.prov(); b = p.prov();
                        if ( b!= 0)
                        {
                            res = v.sub(a, b);
                            Console.WriteLine("{0} / {1} = {2}", a, b, res);
                        }
                        else
                        {
                            Console.WriteLine("Деление на 0 невозможно");
                        }
                        break;
                    case 9:
                        Console.WriteLine("Выход");
                        break;
                    default:
                        Console.WriteLine("Ошибка выбора операции");
                        break;
                }
            }while (n != 9);
            Console.ReadKey();
        }
    }
}
