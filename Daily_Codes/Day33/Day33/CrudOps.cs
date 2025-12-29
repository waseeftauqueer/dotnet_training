using Day33;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33
{
    internal class CrudOps
    {
        Model1Container model = new Model1Container();

        public void Insert()
        {
            Pizzas pizzas = new Pizzas()
            {
                PizzaId = 1,
                PizzaName = "Macroon",
                Price = "22.50",
                Description = "Tasty Pizza",
                Type = "Chicken Pizza"
            };
            model.Pizzas.Add(pizzas);
            int i = model.SaveChanges();
            Console.WriteLine("total record inserted is " + i);

            foreach (var item in model.Pizzas)
            {
                Console.WriteLine($"{item.PizzaId}  {item.PizzaName}  {item.Description}  {item.Price}  {item.Type}");
            }

        }

        public void EvenOdd()
        {
            int x = 11;
            Console.WriteLine(x.IsEven());
        }
    }
    static class myclass
    {
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }
    }
}