using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> names = new MyList<string>();
            //Listeye ekle
            names.Add("Serhat");
            names.Add("Sural");
            //listedeki değerleri oku
            foreach (var item in names.Items)
            {
                Console.WriteLine(item);
            }
            //Listenin uzunluğunu göster
            Console.WriteLine(names.Length);

            MyDictionary<string, int> product = new MyDictionary<string, int>();
            product.Add("Laptop", 1500);
            product.Add("Mouse", 500);
            product.Add("Keyboard", 750);

            foreach (var products in product.Values)
            {
                Console.WriteLine(products);
            }

            foreach (var products in product.Key)
            {
                Console.WriteLine(products);
            }


        }
    }
}
