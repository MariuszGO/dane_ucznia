namespace dane_ucznia;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Dodatkowa strona dostępna pod adresem "ProfilPage".
        Routing.RegisterRoute(nameof(ProfilPage), typeof(ProfilPage));
    }
}
