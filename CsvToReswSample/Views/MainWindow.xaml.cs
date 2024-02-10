using CsvToReswSample.Helpers;

namespace CsvToReswSample.Views;

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
