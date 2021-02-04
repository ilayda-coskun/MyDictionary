using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int, string> customer = new MyList<int, string>();

            customer.Add(1, "İlayda");
            customer.Add(2, "Engin");
            customer.Add(3, "Melek");
            customer.Add(4, "Ahmet");

            Console.WriteLine("---C# Dictionary İle Müşteri Ekleme---\n");

            for (int i = 0; i < customer.Key.Length; i++)
            {
                Console.WriteLine("\tAnahtar : " + customer.Key[i] + "\n\tDeğer : " + customer.Value[i] + "\n");
            }
        }
    }
}
