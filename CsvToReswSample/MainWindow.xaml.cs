using CsvToReswSample.Helpers;
using CsvToReswSample.Views;
using Windows.UI.ViewManagement;

namespace CsvToReswSample;

public sealed partial class MainWindow : WindowEx
{
	public MainWindow()
	{
		InitializeComponent();

		AppWindow.SetIcon(Path.Combine(AppContext.BaseDirectory, "Assets/WindowIcon.ico"));
		Content = new MainPage();
		Title = "AppDisplayName".GetLocalized();
	}
}
