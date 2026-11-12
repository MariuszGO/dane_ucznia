namespace dane_ucznia;

public partial class ProfilPage : ContentPage, IQueryAttributable
{
    public ProfilPage()
    {
        InitializeComponent();
    }

    // Odbieramy imię przekazane przez MainPage.
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.TryGetValue("imie", out var imie))
        {
            PowitanieLabel.Text = $"Witaj, {imie}!";
        }
    }

    private async void OnWrocClicked(object sender, EventArgs e)
    {
        // ".." oznacza powrót do poprzedniej strony.
        await Shell.Current.GoToAsync("..");
    }
}
