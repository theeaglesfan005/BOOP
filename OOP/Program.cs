using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            RetailSalesPerson retailSalesPerson = new RetailSalesPerson("Bruce", "Wayne");
            retailSalesPerson.Sell();

            RetailSalesPerson retailSalesPerson2 = new RetailSalesPerson("Bruce", "Wayne");
            retailSalesPerson2.Sell();

            CarSalesman carSalesman = new CarSalesman("Mike", "Wayne");
            carSalesman.Sell();
        }
    }
}
