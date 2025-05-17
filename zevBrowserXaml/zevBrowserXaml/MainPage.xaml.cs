using Windows.UI.Popups;


namespace zevBrowserXaml;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    private async void onClick_btnFolder(object sender, RoutedEventArgs e)
    {
        // Add your logic here
        var dialog = new ContentDialog
        {
            Content = "This is a Dialog.",
            Title = "My Dialog",
            PrimaryButtonText = "Yes",
            SecondaryButtonText = "No",
            CloseButtonText = "Cancel",
            XamlRoot = this.XamlRoot
        };

        var result = await dialog.ShowAsync();
        if (result == ContentDialogResult.Primary)
        {

        }
        else if (result == ContentDialogResult.Secondary)
        {

        }
        else
        {

        }
    }

    private async void btnSettings_Click(object sender, RoutedEventArgs e)
    {
        Frame.Navigate(typeof(SettingsPage));
    }
}
