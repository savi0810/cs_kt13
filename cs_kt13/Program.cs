using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_kt13
{
    internal class Program
    {
        static void GoMax()
        {
            Console.WriteLine("=== Демонстрация метода Max<T> ===");

            int a = 10, b = 20;
            Console.WriteLine($"Max({a}, {b}) = {GenericMethods.Max(a, b)}");

            string s1 = "1111", s2 = "111";
            Console.WriteLine($"Max(\"{s1}\", \"{s2}\") = \"{GenericMethods.Max(s1, s2)}\"");

            DateTime date1 = new DateTime(2023, 1, 1);
            DateTime date2 = new DateTime(2024, 1, 1);
            Console.WriteLine($"Max({date1:yyyy-MM-dd}, {date2:yyyy-MM-dd}) = {GenericMethods.Max(date1, date2):yyyy-MM-dd}");
        }

        static void GoSwap()
        {
            Console.WriteLine("\n=== Демонстрация метода Swap<T> ===");

            int num1 = 10, num2 = 20;
            Console.WriteLine($"До Swap: num1 = {num1}, num2 = {num2}");
            GenericMethods.SwapStructs(ref num1, ref num2);
            Console.WriteLine($"После Swap: num1 = {num1}, num2 = {num2}");

            string str1 = "Hello", str2 = "World";
            Console.WriteLine($"До Swap: str1 = {str1}, str2 = {str2}");
            GenericMethods.SwapClasses(ref str1, ref str2);
            Console.WriteLine($"После Swap: str1 = {str1}, str2 = {str2}");

            Person person1 = new Person("Александр", 25);
            Person person2 = new Person("Виктория", 30);
            Console.WriteLine($"До Swap: person1 = {person1}, person2 = {person2}");
            GenericMethods.SwapClasses(ref person1, ref person2);
            Console.WriteLine($"После Swap: person1 = {person1}, person2 = {person2}");
        }

        static void GoPrint()
        {
            Console.WriteLine("\n=== Демонстрация метода Print<T> ===");

            string[] strings = { "apple", "banana", "cherry" };
            Console.Write("Массив строк: ");
            GenericMethods.Print(strings);

            Book[] books = {
            new Book("Война и мир", "Лев Толстой"),
            new Book("Преступление и наказание", "Федор Достоевский"),
            new Book("Мастер и Маргарита", "Михаил Булгаков")
        };
            Console.Write("Массив книг: ");
            GenericMethods.Print(books);

            object[] objects = { 1, "два", 3.0, DateTime.Now };
            Console.Write("Массив объектов: ");
            GenericMethods.Print(objects);
        }

        static void Main(string[] args)
        {
            GoMax();
            GoSwap();
            GoPrint();
        }
    }
}
