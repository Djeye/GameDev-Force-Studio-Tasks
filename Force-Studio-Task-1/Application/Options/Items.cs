using System.Collections.Generic;
using Force_Studio_Task_1.Application.Options;

namespace Force_Studio_Task_1.Application
{
    public class Item : IChoose
    {
        public string OptionName { get; set; }
        public void ShowOptions(MainMenu menu)
        {
            menu.ShowOptions(menu);
        }
    }
    
    public static class Items
    {
        public static IEnumerable<Item> GetItems()
        {
            yield return new Item
            {
                OptionName = "33 Coins"
            };

            yield return new Item
            {
                OptionName = "Amulet"
            };

            yield return new Item
            {
                OptionName = "Book"
            };
        }
    }
}