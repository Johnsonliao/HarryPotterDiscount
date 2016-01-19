using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleLibrary
{
    public class HarryPotterDiscount
    {
        public HarryPotterDiscount(List<Book> bookList)
        {

        }

        public int BuyFirstBook(int quantity, int price)
        {
            return quantity * price;
        }

        public int BuyBookDiscount(int quantity, int price, int discount)
        {
            return ((quantity * price) * discount) / 100;
        }

        public int BuyBookDiscountMixing()
        {

            return 0;
        }



    }
}
