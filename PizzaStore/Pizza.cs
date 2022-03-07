using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Pizza
    {
        //InstanceFields
        public string _navn;

        public double _pizzaPris;
        private double _taxPct;
        private double _deleveryCost;



        //Constructor


        public Pizza(string navn, double pizzaPris)
        {
            _navn = navn;

            _pizzaPris = pizzaPris;
            _taxPct = 1.25;
            _deleveryCost = 40;



        }
        //Properties
        public string Navn
        {
            get { return _navn; }

        }



        // i stedet for calculate pris.
        public double PizzaPris
        {
            get { return _pizzaPris * _taxPct + _deleveryCost; }


        }

        // ToString
        public override string ToString()
        {
            return $"Pizza navn: {Navn} og prisen er {PizzaPris}";
        }
    }
}
