using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    internal class ProductRepository
    {
        public void Save(Product product)
        {
            FileStream fin = new FileStream("file.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(fin);
            writer.WriteLine(product);
            writer.Close();
            fin.Close();
        }

        public ArrayList ReadProducts()
        {

            ArrayList products = new ArrayList();
            FileStream fin = new FileStream("file.txt",FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fin);
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] parts = line.Split(',');
                Product product = new Product();
                product.Id = int.Parse(parts[0]);
                product.Name = parts[1];
                product.Description = parts[2];
                products.Add(product);
                line = reader.ReadLine();
            }
            reader.Close();
            fin.Close();
            return products;
         
        }
    }
}
