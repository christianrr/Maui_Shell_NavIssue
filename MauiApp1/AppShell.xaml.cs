namespace MauiApp1;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
    }

    protected override void OnNavigating(ShellNavigatingEventArgs args)
    {
        base.OnNavigating(args);
        Console.WriteLine(args);
    }

    protected override void OnNavigated(ShellNavigatedEventArgs args)
    {
        //base.OnNavigatedTo(args);
        Console.WriteLine(args);
    }
}