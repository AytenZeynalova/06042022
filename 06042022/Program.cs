using System;
using ClassLibrary;

namespace _06042022
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "cola";
            product1.type = ProductTypes.Drink;
            product1.Price = 2;
            product1.Show();

            Product product2 = new Product();
            product2.Name = "dana eti";
            product2.type = ProductTypes.Meat;
            product2.Price = 20;
            product2.Show();

            Product product3 = new Product();
            product3.Name = "sud";
            product3.type = ProductTypes.Diary;
            product3.Price = 3;
            product3.Show();


            Product product4 = new Product();
            product4.Name = "quzu eti";
            product4.type = ProductTypes.Meat;
            product4.Price = 15;
            product4.Show();

            Product product5 = new Product();
            product5.Name = "baton coreyi";
            product5.type = ProductTypes.Baker;
            product5.Price = 0.75;
            product5.Show();


            Store store = new Store();
            store.AddGroup(product1);
            store.AddGroup(product2);
            store.AddGroup(product4);







        }
    }
}
