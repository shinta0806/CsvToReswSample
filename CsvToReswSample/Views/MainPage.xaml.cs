// ============================================================================
// 
// Main page
// 
// ============================================================================

// ----------------------------------------------------------------------------
//
// ----------------------------------------------------------------------------

using CsvToReswSample.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace CsvToReswSample.Views;

internal sealed partial class MainPage : Page
{
	// ====================================================================
	// Constructors
	// ====================================================================

	/// <summary>
	/// Main constructor
	/// </summary>
	public MainPage(MainWindow mainWindow)
	{
		ViewModel = new(mainWindow);
		InitializeComponent();
	}

	// ====================================================================
	// Public properties
	// ====================================================================

	/// <summary>
	/// View model
	/// </summary>
	public MainPageViewModel ViewModel
	{
		get;
	}
}
