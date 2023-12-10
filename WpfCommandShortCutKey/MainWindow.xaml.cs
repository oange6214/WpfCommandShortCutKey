using System.Windows;
using System.Windows.Input;

namespace WpfCommandShortCutKey;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
        e.CanExecute = true;
    }

    private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
    {
        MessageBox.Show(e.Parameter as string);

        //MainWindow window = new MainWindow();
        //window.Show();
    }
}