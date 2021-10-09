using System;

namespace Force_Studio_Task_1.Application.Options
{
    public class SimpleOption : IChoose
    {
        public string OptionName { get; }

        public SimpleOption(string optionName)
        {
            OptionName = optionName;
        }

        public void ShowOptions(MainMenu menu)
        {
            Console.WriteLine(OptionName);
        }
    }
}