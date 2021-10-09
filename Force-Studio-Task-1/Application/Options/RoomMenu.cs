using System;
using System.Collections.Generic;

namespace Force_Studio_Task_1.Application.Options
{
    public class RoomMenu : IChoose
    {
        private readonly List<IChoose> _options = new List<IChoose>();
        public string OptionName { get; }

        public RoomMenu(string optionName)
        {
            OptionName = optionName;
            Initialize();
        }

        public void ShowOptions(MainMenu menu)
        {
            Console.WriteLine("-Room is inspected-");
            ShowOptionsList(menu);
        }

        private void Initialize()
        {
            _options.Add(new SimpleOption("Inspect the table"));
            _options.Add(new BackOption());
        }

        private void ShowOptionsList(MainMenu menu)
        {
            Extension.WriteOptionList(_options);

            var choose = Extension.ChooseOption();

            if (choose < _options.Count)
                _options[choose].ShowOptions(menu);
            else
                Console.WriteLine("-No options-");
        }
    }
}