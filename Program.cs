using C__Basics;
using System.Collections;
using System.Text;

class Program

{
    static void Main(string[] args)
    {
   
       ProductRepository productRepository = new ProductRepository();
        Product p1 = new Product
        {
            Id = 1,
            Name= "P1",
            Description= "product1",
        };
        productRepository.Save(p1);
        Product p2 = new Product
        {
            Id = 2,
            Name = "P2",
            Description = "product2"
        };
        productRepository.Save(p2);


        ArrayList plist = new ArrayList();
        plist = productRepository.ReadProducts();
        for (int i = 0; i < plist.Count; i++)
        {
            Console.WriteLine(plist[i]);
        }
    }

  
}
