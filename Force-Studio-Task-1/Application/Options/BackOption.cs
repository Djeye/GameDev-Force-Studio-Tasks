using System;
using Force_Studio_Task_1.Application.Options;

namespace Force_Studio_Task_1.Application
{
    public class BackOption : IChoose
    {
        public string OptionName { get; }

        public BackOption()
        {
            OptionName = "--Back--";
        }

        public void ShowOptions(MainMenu menu)
        {
            menu.ShowOptions(menu);
        }
    }
}