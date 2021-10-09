using System;
using System.Collections.Generic;
using Force_Studio_Task_1.Application.Options;

namespace Force_Studio_Task_1.Application
{
    public static class Extension
    {
        public static void WriteOption(int i, string value)
        {
            Console.WriteLine($"\t{i} - {value}");
        }

        public static void WriteOptionList(List<IChoose> options)
        {
            for (var i = 0; i < options.Count; i++)
                WriteOption(i, options[i].OptionName);
        }

        public static short ChooseOption()
        {
            return Convert.ToInt16(Console.ReadLine());
        }
    }
}