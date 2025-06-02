using Windows.Storage.Pickers;
using Windows.UI.Popups;
using GridScroller.Package;
using System.Collections.ObjectModel;
using Microsoft.Extensions.Logging;
using Uno.Extensions;
using Uno.UI.Extensions;
using Uno.UI.Xaml;

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
        this.Log().LogDebug("==> Inside onClick_btnFolder.....");
        var folderPicker = new FolderPicker();
        folderPicker.FileTypeFilter.Add("*");

        // Set the window handle for the picker
        //var window = (Application.Current as App)?.MainWindow;
        //var hwnd = WinRT.Interop.WindowNative.GetWindowHandle( window );
        //WinRT.Interop.InitializeWithWindow.Initialize(folderPicker, hwnd);

        this.Log().LogDebug($"folderPicker = {folderPicker.FileTypeFilter}");
        var storageFolder = await folderPicker.PickSingleFolderAsync();
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
