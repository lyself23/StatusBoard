using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using StatusBoardLibrary;
using StatusBoardLibrary.Data;

namespace StatusBoardWinform
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddBlazorWebView();
            //serviceCollection.AddSingleton<AppState>(_appState);

            serviceCollection.AddSingleton<WeatherForecastService>();

            InitializeComponent();

            blazorWebView.HostPage = @"wwwroot\index.html";
            blazorWebView.Services = serviceCollection.BuildServiceProvider();
            blazorWebView.RootComponents.Add<App>("#app");
        }
    }
}