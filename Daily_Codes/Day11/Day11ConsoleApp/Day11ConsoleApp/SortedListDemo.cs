using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11ConsoleApp
{
    internal class SortedListDemo
    {
        public static void SortedListOperations()
        {
            SortedList<int, string> inventory = new SortedList<int, string>();
            inventory.Add(101, "Wheat");
            inventory.Add(102, "Rice");
            inventory.Add(103, "Sugar");
            inventory.Add(104, "Salt");

            Console.WriteLine("Inventory Details : ");
            Console.WriteLine("First Item Code " + inventory.Keys[101]);
            Console.WriteLine("Last Item Code : " + inventory.Values[inventory.Count - 1]);
            foreach (var item in inventory)
            {
                Console.WriteLine("key : " + item.Key + "Value: " + item.Value);
            }

            Console.WriteLine("Enter Key to Search : ");
            int keyToSearch = Convert.ToInt32(Console.ReadLine());
            if (inventory.ContainsKey(keyToSearch))
            {
                Console.WriteLine("Item FOund : " + inventory[keyToSearch]);
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            Console.WriteLine("Enter the Value : ");
            //search  by value
            Console.WriteLine("Enter the value to search : ");
            string valuetosearch = Console.ReadLine();
            if (inventory.ContainsValue(valuetosearch))
            {
                Console.WriteLine("value found :" + inventory.IndexOfValue(valuetosearch));
            }
            else
            {
                Console.WriteLine("Item not found");
            }

            Console.WriteLine("enter the value to update : ");
            int keytoupdate = Convert.ToInt32(Console.ReadLine());
            string newValue = Console.ReadLine();
            inventory[keytoupdate] = newValue;
            Console.WriteLine("updated value : " + inventory[keytoupdate]);

            //update value
            Console.WriteLine("Enter the key to update the value");
            int keyToUpdate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a new value: ");
            string newValue1 = Console.ReadLine();
            inventory[keyToUpdate] = newValue1;
            Console.WriteLine("Updated Inventory:");
            foreach (var item in inventory)
            {
                Console.WriteLine($"Item Key: {item.Key}, New Item Value: {item.Value}");
            }

            Console.WriteLine($"Updated Value: {inventory[keyToUpdate]}");

            //Remove by key
            Console.WriteLine("Remove item code 2004");
            inventory.Remove(2004);
            Console.WriteLine("Inventory after removal:");
            foreach (var item in inventory)
            {
                Console.WriteLine($"Item Key: {item.Key}, Item Value: {item.Value}");
            }

            //Remove by index
            inventory.RemoveAt(0);
            Console.WriteLine("Inventory after removing item at index 0:");
            foreach (var item in inventory)
            {
                Console.WriteLine($"Item Key: {item.Key}, Item Value: {item.Value}");
            }

            //get index of key
            Console.WriteLine("Index of key 2003: " + inventory.IndexOfKey(2003));

            inventory.Clear();
            Console.WriteLine("Inventory cleared. Count: " + inventory.Count);



            Console.ReadLine();
        }
    }
}
