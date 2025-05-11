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
        var dialog = new MessageDialog("Zone-Minder Folder button clicked!");
        await dialog.ShowAsync();
    }

}
