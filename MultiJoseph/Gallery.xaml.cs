namespace MultiJoseph;

public partial class Gallery : ContentPage
{
    public Gallery()
    {
        InitializeComponent();
    }

    private async void OnNextClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new Details());
    }
}