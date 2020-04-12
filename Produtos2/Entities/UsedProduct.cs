using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Produtos2.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManuFactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manuFactureDate)
            : base(name, price)
        {
            ManuFactureDate = manuFactureDate;
        }
        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (ManuFacture date: "
                + ManuFactureDate.ToString("dd/mm/yyyy")
                + ") ";
        }
    }
}
