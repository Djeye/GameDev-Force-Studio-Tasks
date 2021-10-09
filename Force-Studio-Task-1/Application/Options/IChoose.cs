namespace Force_Studio_Task_1.Application.Options
{
    public interface IChoose
    {
        public string OptionName { get; }

        public void ShowOptions(MainMenu menu);
    }
}