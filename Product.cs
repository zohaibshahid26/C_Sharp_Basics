using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace C__Basics
{
    internal class Product
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string description;

        [JsonIgnore]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        //auto implemented properties
        [JsonIgnore]
        public decimal Price { get; set; }

        public Store Storex { get; set; }
        public override string ToString()
        {
            return id + " , " + description + " , " + name;

        }

    }
}
