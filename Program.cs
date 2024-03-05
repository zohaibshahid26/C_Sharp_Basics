using C__Basics;
using System.Collections;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Net.Http.Headers;
class Program
{
    static void Main(string[] args)
    {

        //Lecture 7 and 8 

        DataTable PersonTable = new DataTable();

        DataColumn idColumn = new DataColumn("Id", typeof(int));
        DataColumn nameColumn = new DataColumn("Name", typeof(string));
        DataColumn ageColumn = new DataColumn("age", typeof(int));

        idColumn.AutoIncrement = true;
        idColumn.AutoIncrementSeed = 1;
        idColumn.AutoIncrementStep = 1;

        PersonTable.Columns.Add(idColumn);
        PersonTable.Columns.Add(nameColumn);
        PersonTable.Columns.Add(ageColumn);

        PersonTable.PrimaryKey = new DataColumn[] { idColumn };

        DataRow r1 = PersonTable.NewRow();
        r1["Name"] = "Ali";
        r1[2] = 15;

        PersonTable.Rows.Add(r1);

        DataRow r2 = PersonTable.NewRow();
        r2["Name"] = "Ibrahim";
        r2[2] = 5;

        PersonTable.Rows.Add(r2);

        //index based
        DataRow r3 = PersonTable.Rows[0];
        Console.WriteLine(r3[0]);
        Console.WriteLine(r3[1]);
        Console.WriteLine(r3["age"]);

        //based on primary key
        DataRow r4 = PersonTable.Rows.Find(2);

        //condition based retrival
        DataRow[] rows = PersonTable.Select("age >6 OR name like 'I%'");

        foreach (var r in rows)
        {
            Console.WriteLine($"id {r[0]}, name {r[1]} and age {r[2]}");
        }
        // update
        r4["name"] = "usman";

        //delete
        PersonTable.Rows.Remove(r4);

        DataSet ds = new DataSet();
        ds.Tables.Add(PersonTable);


        DataTable Employee = new DataTable();
        DataColumn Id = new DataColumn("EmpId", typeof(int));
        DataColumn name = new DataColumn("Name", typeof(string));
        DataColumn Pid = new DataColumn("Pid", typeof(int));


        Id.AutoIncrement = true;
        Id.AutoIncrementSeed = 1;
        Id.AutoIncrementStep = 1;

        Employee.Columns.Add(Id);
        Employee.Columns.Add(name);
        Employee.Columns.Add(Pid);

        Employee.PrimaryKey = new DataColumn[] { Id };
        ds.Tables.Add(Employee);

        DataRelation rel1 = new DataRelation("PersonEmprelation",
            PersonTable.Columns["id"], Employee.Columns["Pid"]);
        ds.Relations.Add(rel1);

        DataRow[] rows2 = PersonTable.Rows[0].GetChildRows("PersonEmprelation");
        DataRow parentrow = Employee.Rows[0].GetParentRow("PersonEmprelation");

        /*DataRow row1 = Employee.NewRow();
          row1[2] = 1;//setting foreign key column
          row1[1] = "Ahmad";
          Employee.Rows.Add(row1);
        */


        //Lecture 6
        //int[] data = { 1, 2, 3, 4 };
        //ArrayList list = new ArrayList();
        //list.Add(1);
        //list.Add(2);
        //list.Add(3);

        //foreach (var x in list)
        //{
        //    Console.WriteLine(x);

        //}


        /*int i = 10;
        (int a, string b, float c) t1 = (12, "some value", 34.2f);
        Console.WriteLine(t1.a);
        Console.WriteLine(t1.b);
        Console.WriteLine(t1.c);
        */


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

