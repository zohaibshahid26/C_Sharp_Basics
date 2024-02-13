using C__Basics;
using System.Collections;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Data.SqlClient;

class Program

{
    static void Main(string[] args)
    {

        //Lecture 5

        // authentication of user

        //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyDB;Integrated Security=True");
        // connection.Open();
        // Console.Write("Enter username: ");
        // string userName = Console.ReadLine();
        // Console.Write("Enter password: ");
        // string password = Console.ReadLine();

        // string query = "select * from myUsers where UserName = '" + userName + "' and Password = '" + password + "'";

        // can give unauthorized access to the database

        // to prevent SQL injection


        // string query = "select * from myUsers where UserName = @userName and Password = @password";
        // SqlCommand cmd = new SqlCommand(query, connection);
        // cmd.Parameters.AddWithValue("@userName", userName);
        // cmd.Parameters.AddWithValue("@password", password);
        // SqlDataReader reader = cmd.ExecuteReader();
        // if (reader.HasRows)
        // {
        //     Console.WriteLine("Welcome " + userName);
        // }
        // else
        // {
        //     Console.WriteLine("Invalid username or password");
        // }


        // tuples

        //Person p = new Person();
        // p.Name = "John";
        // p.Country = "USA";
        // p.Age = 25;
        // returning multiple values or tuple

        //(string name, string county, int age) = p.GetPerson();
        // Console.WriteLine(name + " " + county + " " + age);

        // Other way to use tuple
        //var person = p.GetPerson();
        // Console.WriteLine(person.Item1 + " " + person.Item2 + " " + person.Item3);

        // (string, string, int) person1 = p.GetPerson();
        // Console.WriteLine(person1.Item1 + " " + person1.Item2 + " " + person1.Item3);

        // (string name, string country, int age) person2 = p.GetPerson();
        // Console.WriteLine(person2.name + " " + person2.country + " " + person2.age);






        // Lecture 4

        //    //string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyDB;Integrated Security=True";
        //    //SqlConnection connection = new SqlConnection(connectionString);

        //    //string query = "insert, update, delete";

        //    //SqlCommand cmd = new SqlCommand(query, connection);
        //    //connection.Open();

        //    //int i = cmd.ExecuteNonQuery();



        //    //connection.Close();
        //    Store s = new Store { Id = 2, Name = "some name" };

        //    Product p = new Product { Id = 1, Name = "something",
        //        Description = "xd", Price = 100, 
        //        Storex = s 
        //    };
        //    StreamWriter sw = new StreamWriter("a.txt", true);
        //    string jsonString = JsonSerializer.Serialize(p);
        //    Console.WriteLine(jsonString);
        //    sw.WriteLine(jsonString);
        //    sw.Close();


        //    Product p = new Product
        //    {
        //        Id = 1,
        //        Name = "Laptop",
        //        Description = "some desc",
        //        Price = 23M
        //    };

        //    string jsonString = JsonSerializer.Serialize(p);
        //    Console.WriteLine(jsonString);
        //    StreamWriter sw = new StreamWriter("data.txt", append: true);
        //    sw.WriteLine(jsonString);
        //    sw.Close();

        //    ProductRepository productRepository = new ProductRepository();
        //    Product p1 = new Product
        //    {
        //        Id = 1,
        //        Name = "P1",
        //        Description = "product1",
        //    };
        //    productRepository.Save(p1);
        //    Product p2 = new Product
        //    {
        //        Id = 2,
        //        Name = "P2",
        //        Description = "product2"
        //    };
        //    productRepository.Save(p2);


        //    ArrayList plist = new ArrayList();
        //    plist = productRepository.ReadProducts();
        //    for (int i = 0; i < plist.Count; i++)
        //    {
        //        Console.WriteLine(plist[i]);
        //    }
        //}



    }

}

