using Microsoft.UI.Xaml;
using Steinsiek.Desktop.Core;

namespace Steinsiek.Desktop;

public partial class App : Application
{
    private Window? _window;

    public App()
    {
        InitializeServices();
        InitializeLogging();
        InitializeComponent();
    }

    private void InitializeServices()
    {

    }

    private void InitializeLogging()
    {

    }

    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        _window = new MainWindow();
        _window.Activate();
    }
}
