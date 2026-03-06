namespace MultiJoseph;

public partial class MissionEnd : ContentPage
{
    public MissionEnd()
    {
        InitializeComponent();
    }

    private async void OnRestartClicked(object? sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}