namespace MultiJoseph;

public partial class Details : ContentPage
{
    public Details()
    {
        InitializeComponent();
    }

    private async void OnNextClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new Security());
    }
}