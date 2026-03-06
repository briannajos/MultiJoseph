namespace MultiJoseph;

public partial class Logs : ContentPage
{
    public Logs()
    {
        InitializeComponent();
    }

    private async void OnNextClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavComputer());
    }
}