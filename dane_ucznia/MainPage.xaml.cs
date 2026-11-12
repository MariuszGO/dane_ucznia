namespace dane_ucznia;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnDalejClicked(object sender, EventArgs e)
    {
        string imie = ImieEntry.Text?.Trim() ?? "";

        if (imie == "")
        {
            KomunikatLabel.Text = "Podaj imię!";
            return;
        }

        KomunikatLabel.Text = "";

        // Przekazujemy imię na drugi ekran.
        var dane = new ShellNavigationQueryParameters
        {
            { "imie", imie }
        };

        await Shell.Current.GoToAsync(nameof(ProfilPage), dane);
    }
}
