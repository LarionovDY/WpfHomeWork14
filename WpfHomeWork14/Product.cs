using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHomeWork14
{
    public enum ProductCategory
    {
        Applience,
        Food,
        Meds
    }
    class Product
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public ProductCategory Category { get; set; }
        public string ImageSource { get; set; }
    }
}
