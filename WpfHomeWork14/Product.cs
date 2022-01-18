using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHomeWork14
{
    public enum ProductCategory
    {
        Appliance,
        Food,
        Meds
    }
    public class Product
    {
        private decimal price;      
        public string Title { get; set; }
        public decimal Price
        {
            get { return Math.Round(price, 2); }
            set
            {
                if (value > 0)
                    price = value;
                else
                    price = 0;
            }
        }
        public ProductCategory Category { get; set; }
        public string ImageSource { get; set; }
    }
}
