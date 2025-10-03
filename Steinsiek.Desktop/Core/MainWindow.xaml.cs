using Microsoft.UI.Xaml;

namespace Steinsiek.Desktop.Core;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        ExtendsContentIntoTitleBar = true;
    }
}
