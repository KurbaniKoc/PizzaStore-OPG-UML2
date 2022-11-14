using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreOPG
{
    public class PizzaMenu
    {
        Dictionary<int, Pizza> pizzas;


        public PizzaMenu()
        {
            pizzas = new Dictionary<int, Pizza>();
        }

        //public void CreatePizza(Pizza pizza)

        //{
        //    pizzas.Add(pizza.PizzaID, pizza);
        //}
        public void CreatePizza(Pizza pizza)
        {
            if (pizzas.ContainsKey(pizza.Id))
            {
                Console.WriteLine("pizza already excist");
            }
            else
            {
                pizzas.Add(pizza.Id, pizza);
                Console.WriteLine("pizza added");
            }
        }


        public Pizza ReadPizza(int PizzaID)
        {
            return pizzas[PizzaID];
        }

        public void UpdatePizza(Pizza pizza, int NewPrice, string NewName)
        {
            pizza.Price = NewPrice;
            pizza.Name = NewName;
        }
        public void DeletePizza(Pizza pizza)
        {
           if (pizzas.Remove(pizza.PizzaID))
            {
                Console.WriteLine($"Pizza Deleted");
            }
            else
            {
                Console.WriteLine("Not Delete Pizza");
            }
        }

        public Pizza SearchPizza(int PizzaID)

        {
            if (pizzas.ContainsKey(PizzaID))
            {
                Console.WriteLine("Pizza found");
            }
            else
            {
                Console.WriteLine("Pizza not found");
            }
            return null;
        }


        public void PrintMenu(Pizza p2)
        {
            foreach (var Pizza in pizzas)

            {
                Console.WriteLine(Pizza);
            }

        }

    }
}