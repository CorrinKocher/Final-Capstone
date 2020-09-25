using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// A shopping cart class stores items in it.
    /// </summary>
    public class ShoppingCart
    {
        /// <summary>
        /// The number of items in the shopping cart. All shopping carts have 0 items by default.
        /// </summary>
        public int TotalNumberOfItems { get; private set; }
       
        /// <summary>
        /// The total for the shopping cart. All shopping carts have 0.0 owed by default.
        /// </summary>
        public decimal TotalAmountOwed { get; private set; }

        public decimal GetAveragePricePerItem()
        {
            if(this.TotalAmountOwed > 0 && this.TotalAmountOwed > 0)
            {
                return this.TotalAmountOwed / this.TotalNumberOfItems;
            }
            else
            {
                return 0;
            }
        }
        public void AddItems(int numberOfItems, decimal pricePerItem)
        {
            this.TotalNumberOfItems += numberOfItems;
            this.TotalAmountOwed += (pricePerItem * numberOfItems);
        }
        public void Empty()
        {
            this.TotalNumberOfItems = 0;
            this.TotalAmountOwed = 0;
        }
    }
}
