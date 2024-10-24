using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Product
    {
        private static int _no = 1;
        public int No { get; private set; }
        public string Name { get; set; }
        private int _price;
        public ProductType Type { get; set; }

        public Product(string name, int price, ProductType type)
        {
            Name = name;
            Price = price;
            Type = type;
            No = _no;
            _no++;
        }

        public int Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                {
                    throw new PriceMustBeGratherThanZeroException();
                }
                _price = value;
            }
        }
    }

}
