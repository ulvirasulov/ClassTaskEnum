using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Store
    {
        private Product[] products = new Product[0];

        public void AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[^1] = product;
            Console.WriteLine($"mehsul elave edildi: {product.Name}");
        }

        public void RemoveProductByNo(int no)
        {
            int index = -1;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].No == no)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("bele bir mehsul yoxdu");
                return;
            }

            for (int i = index; i < products.Length - 1; i++)
            {
                products[i] = products[i + 1];
            }

            Array.Resize(ref products, products.Length - 1);
            Console.WriteLine($"product nomresi {no} olan mehsul cixarildi");
        }

        public void GetProduct(int no)
        {
            Product product = null;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].No == no)
                {
                    product = products[i];
                    break;
                }
            }

            if (product != null)
            {
                Console.WriteLine($"mehsul tapildi: No: {product.No}, Ad: {product.Name}, Qiymət: {product.Price}, Tip: {product.Type}");
            }
            else
            {
                Console.WriteLine("bele mehsul yoxdu");
            }
        }

        public void FilterProductByName(string name)
        {
            bool found = false;
            foreach (var product in products)
            {
                if (product.Name.ToLower().Contains(name.ToLower()))
                {
                    Console.WriteLine($"axtarilan mehsul: {product.Name}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("bele mehsul tapilmadi");
            }
        }

        public void FilterProductByType(string type)
        {
            bool found = false;
            foreach (var product in products)
            {
                if (product.Type.ToString().ToLower() == type.ToLower())
                {
                    Console.WriteLine($"type: {product.Type}, ad: {product.Name}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("verilen tipe aid mehsul tapilmadi");
            }
        }

        public void GetAllProducts()
        {
            if (products.Length == 0)
            {
                Console.WriteLine("mehsul yoxdu");
            }
            else
            {
                foreach (var product in products)
                {
                    Console.WriteLine($"no: {product.No}, ad: {product.Name}, qiymet: {product.Price}, type: {product.Type}");
                }
            }
        }
    }
}
