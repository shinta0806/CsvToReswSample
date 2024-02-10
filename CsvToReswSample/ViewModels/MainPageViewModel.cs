// ============================================================================
// 
// Main page view model
// 
// ============================================================================

// ----------------------------------------------------------------------------
//
// ----------------------------------------------------------------------------

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using CsvToReswSample.Strings;
using CsvToReswSample.Views;

using Microsoft.UI.Xaml.Controls;

namespace CsvToReswSample.ViewModels;

internal partial class MainPageViewModel : ObservableRecipient
{
	// ====================================================================
	// Constructors
	// ====================================================================

	/// <summary>
	/// Main constructor
	/// </summary>
	public MainPageViewModel(MainWindow mainWindow)
	{
		_mainWindow = mainWindow;

		ButtonOrderClickedCommand = new RelayCommand(ButtonOrderClicked);
	}

	// ====================================================================
	// Public properties
	// ====================================================================

	// --------------------------------------------------------------------
	// Commands
	// --------------------------------------------------------------------

	#region Order button
	public RelayCommand ButtonOrderClickedCommand
	{
		get;
	}

	private async void ButtonOrderClicked()
	{
		ContentDialog contentDialog = new()
		{
			Title = Localize.MainPageViewModel_MessageTitle.Localized(),
			Content = Localize.MainPageViewModel_MessageContent.Localized(),
			PrimaryButtonText = Localize.MainPageViewModel_ButtonOk.Localized(),
			XamlRoot = _mainWindow.Content.XamlRoot,
		};
		await contentDialog.ShowAsync();
	}
	#endregion

	// ====================================================================
	// Private fields
	// ====================================================================

	/// <summary>
	/// Main window
	/// </summary>
	private readonly MainWindow _mainWindow;
}
