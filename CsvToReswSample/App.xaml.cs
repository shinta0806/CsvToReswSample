// ============================================================================
// 
// Application
// 
// ============================================================================

// ----------------------------------------------------------------------------
//
// ----------------------------------------------------------------------------

using CsvToReswSample.Views;

using Microsoft.UI.Xaml;

namespace CsvToReswSample;

public partial class App : Application
{
	// ====================================================================
	// Constructors
	// ====================================================================

	/// <summary>
	/// Main constructor
	/// </summary>
	public App()
	{
		InitializeComponent();

		UnhandledException += AppUnhandledException;
	}

	// ====================================================================
	// Public properties
	// ====================================================================

	/// <summary>
	/// Main window
	/// </summary>
	public static WindowEx MainWindow
	{
		get;
	} = new MainWindow();

	// ====================================================================
	// Protected functions
	// ====================================================================

	/// <summary>
	/// Application launched
	/// </summary>
	/// <param name="args"></param>
	protected override void OnLaunched(LaunchActivatedEventArgs args)
	{
		base.OnLaunched(args);

		MainWindow.Activate();
	}

	// ====================================================================
	// Private functions
	// ====================================================================

	/// <summary>
	/// Error handler
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void AppUnhandledException(object sender, Microsoft.UI.Xaml.UnhandledExceptionEventArgs e)
	{
	}
}
