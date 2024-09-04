using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation.Collections;
using Windows.UI.Popups;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainMenu : Page
	{
		public MainMenu()
		{
			this.InitializeComponent();
		}

		private void mathCalculatorButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
		{
			Frame.Navigate(typeof(MainPage));
		}

		private void mortgageCalculatorButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
		{
			Frame.Navigate(typeof(MortgageCalculator));
		}

		private void currencyConverterButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
		{
			Frame.Navigate(typeof(CurrencyConverter));
		}

		private void exitButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
		{
			CoreApplication.Exit();
		}

		private async void tripCalculator_Click(object sender, RoutedEventArgs e)
		{
			var dialogMessage = new MessageDialog("Trip calculator C# code will be developed later");
			await dialogMessage.ShowAsync();
		}
	}
}
