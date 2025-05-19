using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace zevBrowserXaml2;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class SettingsPage : Page
{
    public SettingsPage()
    {
        this.InitializeComponent();
    }


    private async void btnSettingsSelectFolder_Click(object sender, RoutedEventArgs e)
    {
        var dialog = new ContentDialog
        {
            Content = "btnSettingsSelectFolder was clicked",
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

    private async void btnSaveSettings_Click(object sender, RoutedEventArgs e)
    {
        var dialog = new ContentDialog
        {
            Content = "btnSaveSettings was clicked",
            Title = "Saved settings",
            PrimaryButtonText = "Yes",
            SecondaryButtonText = "No",
            CloseButtonText = "Cancel",
            XamlRoot = this.XamlRoot
        };
        var result = await dialog.ShowAsync();
        Frame.Navigate(typeof(MainPage));
    }

    private async void btnCancelSettings_Click(object sender, RoutedEventArgs e)
    {
        var dialog = new ContentDialog
        {
            Content = "btnCancelSettings was clicked",
            Title = "Canceled Edit Settings",
            PrimaryButtonText = "Yes",
            SecondaryButtonText = "No",
            CloseButtonText = "Cancel",
            XamlRoot = this.XamlRoot
        };
        var result = await dialog.ShowAsync();
        Frame.Navigate(typeof(MainPage));
    }


}
