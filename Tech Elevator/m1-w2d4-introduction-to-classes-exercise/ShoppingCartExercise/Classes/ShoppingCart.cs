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
        public int totalNumberOfItems = 0;
        public double totalAmountOwed = 0;


        public int TotalNumberOfItems
        {
            get { return totalNumberOfItems; }
            set { totalNumberOfItems = value; }
        }

        public double TotalAmountOwed
        {
            get { return totalAmountOwed; }
            set { totalAmountOwed = value; }
        }


        public void Empty()
        {
            totalNumberOfItems = 0;
            totalAmountOwed = 0;
        }

        public void AddItems(int numberOfItems, double pricePerItem)
        {
            totalNumberOfItems += numberOfItems;
            totalAmountOwed += (numberOfItems * pricePerItem);
        }

       public double GetAveragePricePerItem()
        {
            if (totalNumberOfItems == 0)
            {
                return 0;
            }
            return (totalAmountOwed / totalNumberOfItems);
        }
    }
}
