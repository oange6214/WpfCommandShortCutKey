using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace WpfCommandShortCutKey.ViewModels;

public partial class MyViewModel : ObservableRecipient
{
    public RelayCommand<string> OpenCommand { get; }

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OpenCommand))]
    private string _myText;

    public MyViewModel()
    {
        OpenCommand = new RelayCommand<string>(ExecuteOpen, CanExecuteOpen);
    }

    private void ExecuteOpen(string parameter)
    {
        // Open 命令的邏輯
        MessageBox.Show($"{parameter}, {_myText}");

    }

    private bool CanExecuteOpen(string parameter)
    {
        // 判斷 Open 命令是否可執行
        return !string.IsNullOrEmpty(_myText);
    }
}
