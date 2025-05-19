using UIKit;
using Uno.UI.Hosting;
using zevBrowserXaml2;

App.InitializeLogging();

var host = UnoPlatformHostBuilder.Create()
    .App(() => new App())
    .UseAppleUIKit()
    .Build();

host.Run();
