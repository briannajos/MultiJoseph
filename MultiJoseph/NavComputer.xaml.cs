namespace MultiJoseph;

public partial class NavComputer : ContentPage
{
    public NavComputer()
    {
        InitializeComponent();
    }

    private async void OnNextClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new Radar());
    }
}