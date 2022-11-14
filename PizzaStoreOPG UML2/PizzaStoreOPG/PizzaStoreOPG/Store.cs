using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreOPG
{
    public class Store
    {
        public void Start()
        {
            PizzaMenu PizzaM = new PizzaMenu();

            Pizza p1 = new Pizza(1, "Salat", 80, "Salat, dressing");
            Pizza p2 = new Pizza(2, "Pepperoni", 65, "Pepperoni,Cheese, Tomatoes");
            Pizza p3 = new Pizza(3, "Shawarma", 85, "Shawarma, Cheese, Peber");
            Pizza p4 = new Pizza(3, "ss", 825, "Shawassrma, Cheese, Peber");

            Console.WriteLine("Pizza Created");
            PizzaM.CreatePizza(p1);
            PizzaM.CreatePizza(p2);
            PizzaM.CreatePizza(p3);
            PizzaM.CreatePizza(p3);

            PizzaM.DeletePizza(p2);
            PizzaM.CreatePizza(p2);
            Console.ReadLine();




            Console.WriteLine("Menu");
            PizzaM.PrintMenu(p2);

            Console.WriteLine("Updating pizza 3....");
            PizzaM.UpdatePizza(p3, 60, "Cheese");
            Console.WriteLine(PizzaM.ReadPizza(3));

            Console.WriteLine(PizzaM.SearchPizza(1));
        }

        public void Starts()
        {
            CustomerAdmin customer = new CustomerAdmin();

            Customer c1 = new Customer(20, "Robby", "p1");
            Customer c2 = new Customer(20, "Johnny", "p2");
            Customer c3 = new Customer(20, "Benji", "p3");

            Console.WriteLine("Customer Added");
            customer.AddCustomer(c1);
            customer.AddCustomer(c2);
            customer.AddCustomer(c3);

            customer.DeleteCustomer(c1);

            customer.UpdateCustomer(c1, "Benji", "p3");

        }
    }
}

