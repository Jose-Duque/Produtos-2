using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Produtos2.Entities
{
    class ImporteProducts : Product
    {
        public double CustomFee { get; set; }

        public ImporteProducts()
        {

        }

        public ImporteProducts(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }
        public double TotalPrice()
        {
            return Price + CustomFee;
        }
        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs Fee: $ "
                + CustomFee.ToString("F2", CultureInfo.InvariantCulture)
                + " )";
        }
    }
}
