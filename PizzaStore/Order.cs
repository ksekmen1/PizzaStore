using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Order
    {
        private double _pizzaPris;
        private string _pizzaNavn;
        private string _customerNavn;




        public Order(Pizza pizza, Customer customer)
        {
            _pizzaNavn = pizza.Navn;
            _pizzaPris = pizza.PizzaPris;
            _customerNavn = customer.Navn;



        }



        public override string ToString()
        {
            return $"Kunde: {_customerNavn} Har bestilt en {_pizzaNavn} pizza som koster {_pizzaPris} Kr efter Tax og leveringsgebyr";
        }
    }
}
