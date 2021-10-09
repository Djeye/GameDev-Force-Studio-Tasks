using System;
using System.Collections.Generic;

namespace Force_Studio_Task_1.Application.Options
{
    public class MainMenu : IChoose
    {
        public string OptionName { get; }
        private readonly List<IChoose> _options = new List<IChoose>();

        public MainMenu(string optionName)
        {
            OptionName = optionName;
        }

        public void ShowOptions(MainMenu menu)
        {
            Console.WriteLine("-Choose what would you do:-");
            ShowOptionsList();
        }

        public void StartApplication()
        {
            Console.WriteLine(OptionName);
            AddOptions();
            ShowOptions(this);
        }

        private void ShowOptionsList()
        {
            Extension.WriteOptionList(_options);

            var choose = Extension.ChooseOption();

            if (choose < _options.Count)
                _options[choose].ShowOptions(this);
            else
                Console.WriteLine("-No options-");
        }

        private void AddOptions()
        {
            _options.Add(new RoomMenu("Inspect the room"));
            _options.Add(new ObjectsMenu("Inspect objects"));
        }
    }
}