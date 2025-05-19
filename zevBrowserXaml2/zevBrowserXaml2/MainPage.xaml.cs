using Windows.Storage.Pickers;
using Windows.UI.Popups;
using GridScroller.Package;
using System.Collections.ObjectModel;


namespace zevBrowserXaml2;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
        this.gsDates.Items = new ObservableCollection<UIElement>
        {
            new CheckBox { Content = "2025-05-12" },
            new CheckBox { Content = "2025-05-13" },
            new CheckBox { Content = "2025-05-14" },
            new Button { Content = "A" },
            new Button { Content = "B" }
        };
    }

    private async void onClick_btnFolder(object sender, RoutedEventArgs e)
    {
        var folderPicker = new FolderPicker();
        folderPicker.FileTypeFilter.Add("*");

        Task.Delay(10).Wait();
        var storageFolder = await folderPicker.PickSingleFolderAsync();
        Task.Delay(10).Wait();
        if (storageFolder != null)
        {
            //Task.Delay(10).Wait();
            var fileList = await storageFolder.GetFilesAsync();
            var folderList = await storageFolder.GetFoldersAsync();
            //Task.Delay(10).Wait();

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
