using System;
using System.Collections.Generic;

namespace Force_Studio_Task_1.Application.Options
{
    public class ObjectsMenu : IChoose
    {
        private readonly List<IChoose> _options = new List<IChoose>();
        private readonly List<IChoose> _inventory = new List<IChoose>();

        public string OptionName { get; }

        public ObjectsMenu(string optionName)
        {
            OptionName = optionName;
            Initialize();
        }

        public void ShowOptions(MainMenu menu)
        {
            Console.WriteLine("-Which object you want to grab?-");
            ShowOptionsList(menu);
        }

        private void Initialize()
        {
            var items = Items.GetItems().GetEnumerator();
            while (items.MoveNext()) _options.Add(items.Current);
            _options.Add(new BackOption());
        }

        private void ShowOptionsList(MainMenu menu)
        {
            Extension.WriteOptionList(_options);

            var choose = Extension.ChooseOption();

            if (choose < _options.Count)
            {
                if (choose < _options.Count - 1)
                {
                    var grabbedItem = _options[choose];
                    _options.Remove(grabbedItem);
                    _inventory.Add(grabbedItem);
                }

                _options[choose].ShowOptions(menu);
            }
            else
                Console.WriteLine("-No options-");
        }
    }
}