using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaloniaHelloWorldMD2;

public partial class MainView : UserControl
{
    private int _clickCount;

    public MainView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void OnGreetButtonClick(object? sender, RoutedEventArgs e)
    {
        _clickCount++;
        var responseText = this.FindControl<TextBlock>("ResponseText");
        if (responseText != null)
        {
            responseText.Text = _clickCount == 1
                ? "Hello! Welcome to Material Design 2 on Android! 👋"
                : $"You've said hello {_clickCount} times! 🎉";
        }
    }
}