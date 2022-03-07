using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Customer
    {
        private string _navn;

        public Customer(string Navn)
        {
            _navn = Navn;

        }

        public string Navn
        {
            get { return _navn; }
        }

        public override string ToString()
        {
            return $"Kunden hedder: {_navn}";
        }
    }
}

