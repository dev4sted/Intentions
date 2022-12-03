using Intentions.Pl.Menus.Abstract;
using Spectre.Console;

namespace Intentions.Pl.Menus;

internal sealed class MainMenu : DialogMenu<string>
{
    public static class Options
    {
        public const string AddIntention = "Новое намерение";

        public const string SelectIntention = "Выбрать намерение";

        public const string AddIntentionsGroup = "Добавить группу";

        public const string SelectIntentionsGroup = "Список групп";

        public const string Quit = "Выйти";
    }

    protected override string Ask()
    {
        SelectionPrompt<string> prompt = new SelectionPrompt<string>()
            .AddChoices(
                Options.AddIntention,
                Options.SelectIntention,
                Options.AddIntentionsGroup,
                Options.SelectIntentionsGroup,
                Options.Quit)
            .UseConverter(
                option => option.Equals(Options.Quit, StringComparison.OrdinalIgnoreCase) ?
                    (option + ".") :
                    (option + ";"));

        return AnsiConsole.Prompt(prompt);
    }

    protected override bool ProcessAnswer(string answer) => answer switch
    {
        Options.AddIntention => false,
        Options.SelectIntention => false,
        Options.AddIntentionsGroup => false,
        Options.SelectIntentionsGroup => false,
        _ => false
    };
}

