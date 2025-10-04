using Microsoft.UI.Xaml;
using Steinsiek.Desktop.Modules.Auth;

namespace Steinsiek.Desktop.Core;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        ExtendsContentIntoTitleBar = true;
        ContentFrame.Navigate(typeof(AuthPage));
    }
}
