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
	/// Interaction logic for User.xaml
	/// </summary>
	public partial class User : UserControl
	{
		public User()
		{
			InitializeComponent();
		}

		private void UserItemControl_Loaded_1(object sender, RoutedEventArgs e)
		{
			this.DeleteImage.MouseDown += (obj, eventArgs) => this.RaiseDeleteEvent();
		}

		public String Title
		{
			get { return (String)GetValue(TitleProperty); }
			set { SetValue(TitleProperty, value); }
		}

		// Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty TitleProperty = DependencyProperty.Register
		(
			"Title",
			typeof(String),
			typeof(User), 
			new PropertyMetadata("New User")
		);

		public static readonly RoutedEvent DeleteEvent = EventManager.RegisterRoutedEvent
		(
		   "Delete", //ime eventa
			RoutingStrategy.Bubble,
			typeof(RoutedEventHandler),
			typeof(User) //tip elementa koji posjeduje event
		);

		public event RoutedEventHandler Delete //za registraciju/deregistraciju 
		{
			add { AddHandler(DeleteEvent, value); }
			remove { RemoveHandler(DeleteEvent, value); }
		}

		public void RaiseDeleteEvent()
		{
			RoutedEventArgs newEventArgs = new RoutedEventArgs(User.DeleteEvent);
			RaiseEvent(newEventArgs);
		}

		


	
	}
}
