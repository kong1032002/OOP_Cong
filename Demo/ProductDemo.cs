using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OOP_Cong.Enity;

namespace OOP_Cong.Demo
{
    internal class ProductDemo
    {
        public void CreateProductTest()
        {
            Product product = new Product();
        }

        public void PrintProduct(Product product)
        {
            Console.WriteLine(product);
        }
    }
}
