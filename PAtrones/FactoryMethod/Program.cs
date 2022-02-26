using System;

namespace FactoryMethod
{
    class Program
    {
        /*
         factory method: Fábrica creadora de objetos.

        imagina que tienes una fábrica, esta fábrica hace productos, estos productos peuden ser de distinto tipo. Puedes tener un conjunto de fábricas.

        La practica habla que tenemos clase abstracta creador
        tenemos clases hijas que heredan de creador que son los creadores concretos.

        Tenemos productos, una interfaz y podemos cerar productos concretos usando el creador concreto.

        Ventjas: la ceracion del objeto va a estar en la fabrica. (una unica responsabilidad en creador concreto)

         objetos muy parecidos, flexibilidad que da para no crear la rueda.

         */
        static void Main(string[] args)
        {
            int extra = 100;
            int discount = 20;
            SaleFactory storeSaleFactory = new StoreSellFactory(extra);
            SaleFactory internetSaleFactory = new InternetSaleFactory(discount);

            ISale storeSale1 = storeSaleFactory.GetSale();
            storeSale1.Sell(25);


            ISale internetSale1 = internetSaleFactory.GetSale();
            storeSale1.Sell(45);


        }
    }
}
