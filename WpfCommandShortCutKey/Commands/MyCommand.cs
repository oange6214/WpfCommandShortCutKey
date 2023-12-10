using System.Windows.Input;

namespace WpfCommandShortCutKey;

static class MyCommand
{
    public static RoutedUICommand Hello { get; set; }

    static MyCommand()
    {
        var inputs = new InputGestureCollection();
        var shortKey = new KeyGesture(Key.E, ModifierKeys.Control);
        inputs.Add(shortKey);

        Hello = new RoutedUICommand("Hi", "Hello", typeof(MyCommand), inputs);
    }
}
