namespace zevBrowser;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this
            .Background(ThemeResource.Get<Brush>("ApplicationPageBackgroundThemeBrush"))
            .Content(new StackPanel()
            {
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                Children =
                {
                       new Button
                       {
                           Name = "btnSelectFolder",
                           Content = "Select Folder"
                       }.Apply(button => button.Click += OnClick_SelectFolder)
                }
            });
    }

    private Windows.Storage.StorageFolder zmFolder; 

    private async void OnClick_SelectFolder(object sender, RoutedEventArgs e)
    {
        var picker = new Windows.Storage.Pickers.FolderPicker();
        picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.Desktop;
        picker.FileTypeFilter.Add("*");
        var folder = await picker.PickSingleFolderAsync();
        if (folder != null)
        {
            zmFolder = folder;
        }
    }
}

public static class UIElementExtensions
{
    public static T Apply<T>(this T element, Action<T> action) where T : UIElement
    {
        action(element);
        return element;
    }
}
