using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pathway
{
	/// <summary>
	/// Interaction logic for NewFileTransferPage.xaml
	/// </summary>
	public partial class NewFileTransferPage : Page
	{

		public string SourceFile { get; set; }
		public string SourceFolder { get; set; }
		public string DestinationFolder { get; set; }

		public NewFileTransferPage()
		{
			InitializeComponent();
		}
		private void BackToHome_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			NavigationService.Navigate(new HomePage());
		}

		private void AddFileTransfer_Click(object sender, RoutedEventArgs e)
		{
			SourceFile = SourceFileTextBox.Text;
			SourceFolder = SourceFolderTextBox.Text;
			DestinationFolder = DestinationFolderTextBox.Text;

			NavigationService.Navigate(new HomePage());
		}
	}
}
