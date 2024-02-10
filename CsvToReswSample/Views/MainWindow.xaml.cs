// ============================================================================
// 
// Main window
// 
// ============================================================================

// ----------------------------------------------------------------------------
//
// ----------------------------------------------------------------------------

using CsvToReswSample.Helpers;

namespace CsvToReswSample.Views;

internal sealed partial class MainWindow : WindowEx
{
	// ====================================================================
	// Constructors
	// ====================================================================

	/// <summary>
	/// Main constructor
	/// </summary>
	public MainWindow()
	{
		InitializeComponent();

		AppWindow.SetIcon(Path.Combine(AppContext.BaseDirectory, "Assets/WindowIcon.ico"));
		Content = new MainPage();
		Title = "AppDisplayName".GetLocalized();
	}
}
