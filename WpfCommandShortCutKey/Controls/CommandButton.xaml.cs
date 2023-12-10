using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfCommandShortCutKey;

public partial class CommandButton : UserControl, ICommandSource
{
    public CommandButton()
    {
        InitializeComponent();

        MouseLeftButtonDown += CommandButton_MouseLeftButtonDown;
    }

    private void CommandButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        if (Command != null)
        {
            if (Command.CanExecute(CommandParameter))
            {
                Command.Execute(CommandParameter);
            }
        }
    }

    public ICommand Command { get; set; }

    public object CommandParameter { get; set; }

    public IInputElement CommandTarget { get; set; }
}
