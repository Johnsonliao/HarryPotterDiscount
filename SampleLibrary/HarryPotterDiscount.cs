using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleLibrary
{
    public class HarryPotterDiscount
    {
        private List<Book> _books;

        //private List<DiscountPKG> _discountPKG;

        public HarryPotterDiscount(List<Book> bookList)
        {
            this._books = bookList;
        }

        public int BuyFirstBook(int quantity, int price)
        {
            return quantity * price;
        }

        public int BuyBookDiscount(int quantity, int price, int discount)
        {
            return ((quantity * price) * discount) / 100;
        }

        public int BuyBookDSTMixing(int normal)
        {
            switch (normal)
            {
                case 1:
                    normal = 100;
                    break;
                case 2:
                    normal = (((normal * 100) * 95) / 100);
                    break;
                case 3:
                    normal = (((normal * 100) * 90) / 100);
                    break;
                case 4:
                    normal = (((normal * 100) * 80) / 100);
                    break;
                case 5:
                    normal = (((normal * 100) * 75) / 100);
                    break;
            }
            return normal;
        }

        public int BuyBookDiscountMixing()
        {
            int j = 0;
            int totalPrice = 0;

            var normal = _books.GroupBy(x =>new { x.BookID,x.Price })
                .Select(x => new { SIgnleBookTotal=x.Count(),x.Key.BookID,SingleBookPrice=x.Sum(y=>y.Price)}).ToList();
            
            for (int i = 0; i < normal.Count; i++)
            {
                if (i == 0)
                    totalPrice = BuyBookDSTMixing(normal.Count);

                if (normal[i].SIgnleBookTotal > 1)
                    j++;

                if(i== normal.Count -1 && j>0)
                    totalPrice += BuyBookDSTMixing(j);
            }

            return totalPrice;
        }

    }
}
