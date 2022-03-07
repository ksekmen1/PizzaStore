using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Store
    {
        public void Start()
        {
            Pizza p1 = new Pizza("Magarita", 70);
            Pizza p2 = new Pizza("Peperoni", 82);
            Pizza p3 = new Pizza("Salat", 90);

            Customer c1 = new Customer("John");
            Customer c2 = new Customer("Karen");
            Customer c3 = new Customer("Jesper");

            Order o1 = new Order(p1, c1);
            Order o2 = new Order(p2, c2);
            Order o3 = new Order(p3, c3);


            // Der kan kaldes på p, c og o

            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.WriteLine(o3);

        }
    }
}
