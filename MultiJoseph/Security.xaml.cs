namespace MultiJoseph;

public partial class Security : ContentPage
{
    int count = 0;

    public Security()
    {
        InitializeComponent();
    }

    private void OnLockClicked(object sender, EventArgs e)
    {
        count = count + 1;

        if (count < 7)
        {
            LockBtn.Text = "TAP " + (7 - count) + " MORE";
        }
        else
        {
            LockBtn.Text = "AUTHORIZED";
            LockBtn.BackgroundColor = Colors.Green;

            NextBtn.IsVisible = true;
        }
    }

    private async void OnNextClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Logs());
    }
}