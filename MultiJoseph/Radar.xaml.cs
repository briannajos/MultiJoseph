namespace MultiJoseph;

public partial class Radar : ContentPage
{
    public Radar()
    {
        InitializeComponent();
    }

    private async void OnNextClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new MissionEnd());
    }
}