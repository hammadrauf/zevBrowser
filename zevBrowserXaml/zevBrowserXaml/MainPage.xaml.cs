using Windows.Storage.Pickers;
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
        var folderPicker = new FolderPicker();
        folderPicker.FileTypeFilter.Add("*");

        var storageFolder = await folderPicker.PickSingleFolderAsync();
        if (storageFolder != null)
        {
            var fileList = await storageFolder.GetFilesAsync();
            var folderList = await storageFolder.GetFoldersAsync();

            // Do something with the contents...
        }
        else
        {
            // Did not pick any folder.
        }

    }

    private async void btnSettings_Click(object sender, RoutedEventArgs e)
    {
        Frame.Navigate(typeof(SettingsPage));
    }
}
