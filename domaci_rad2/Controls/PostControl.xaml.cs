using System;
using System.Collections.Generic;
using System.Linq;
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

namespace domaci_rad2.Controls
{
	/// <summary>
	/// Interaction logic for PostControl.xaml
	/// </summary>
	public partial class PostControl : UserControl
	{
		public PostControl()
		{
			InitializeComponent();
		}

		private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
		{
			
		}

		private void Post_Delete(object sender, RoutedEventArgs e)
		{
			DependencyObject parent = this.Parent;

			StackPanel postList = (StackPanel)parent;

			postList.Children.Remove(this);
		}

	}
}
