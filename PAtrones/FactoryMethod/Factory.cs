using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //diagrama que sale de la imagen Factory-Method.png
    /// <summary>
    /// Creator
    /// </summary>
    public abstract class SaleFactory
    {
        public abstract ISale GetSale();
    }

    /// <summary>
    /// concrete creator
    /// </summary>
    public class InternetSaleFactory : SaleFactory
    {
        private decimal _discount;

        public InternetSaleFactory(decimal discount)
        {
            _discount = discount;
        }

        public override ISale GetSale()
        {
            return new InternetSale(_discount);
        }
    }

    /// <summary>
    /// concrete creator
    /// </summary>
    public class StoreSellFactory : SaleFactory
    {
        private decimal _extra;

        public StoreSellFactory(decimal extra)
        {
            _extra = extra;
        }

        public override ISale GetSale()
        {
            return new StoreSale(_extra);
        }
    }

    /// <summary>
    /// concrete product
    /// </summary>
    public class StoreSale : ISale
    {
        private decimal _extra;
        public StoreSale(decimal extra)
        {
            _extra = extra;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en tienda cuesta: {total + _extra}");
        }
    }

    /// <summary>
    /// concrete product
    /// </summary>
    public class InternetSale : ISale
    {
        private decimal _discount;
        public InternetSale(decimal discount)
        {
            _discount = discount;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en internet cuesta: {total - _discount}");
        }
    }

    /// <summary>
    /// product
    /// </summary>
    public interface ISale
    {
        public void Sell(decimal total);
    }
}
