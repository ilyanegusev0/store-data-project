using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDataProject.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"ID: {Id} | Name: {Name}";
        }
    }
}
