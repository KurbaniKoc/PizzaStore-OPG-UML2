using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreOPG
{
    public class Pizza
    {
        private static int nextId = 1;
        public int PizzaID;

        public Pizza(int id, string name, double price, string ingredients)
        {
            nextId = id++;
            Id = id;
            Name = name;
            Price = price;
            Ingredients = ingredients;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Ingredients { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name.ToString()}, {nameof(Ingredients)}={Ingredients}}}";
        }
    }
}  
