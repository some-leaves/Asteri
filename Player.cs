using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteri
{
    class Player
    {
        public string Name { get; set; }

        public List<Items> Inventory { get; set; }


        public void PickUpItem(Items item)
        {
            //Checks if the player does not have the item
            if (!Inventory.Contains(item))
            {
                //Add it to the inventory
                Inventory.Add(item);
            }

            Console.Clear();
            //Show inventory details
            ShowInventory();
        }

        public void ShowInventory()
        {
            //Create a local string list to hold items names
            List<string> namesOfItems = new List<string>();
            foreach (Items item in Inventory)
            {
                namesOfItems.Add(item.Name);
            }
            //Use built in string.join function to display items in a comma separated list.
            Console.WriteLine($"You have these item(s): {String.Join(",", namesOfItems)}");

        }
    }
}
