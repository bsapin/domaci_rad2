using domaci_rad2.Controls;
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

namespace domaci_rad1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

		private void Window_Loaded_1(object sender, RoutedEventArgs e)
		{
			this.l_button.Click += l_button_Click;
			this.r_button.Click += r_button_Click;

			foreach (var element in this.currentUser.Children)
			{
				if (element is User)
				{
					var user = (User)element;
					user.Delete += user_Delete;
				}
			}

			foreach (var element in this.l_panel.Children)
			{
				if (element is User)
				{
					var userList = (User)element;
					userList.Delete += userList_Delete;
				}
			}
		}

		void r_button_Click(object sender, RoutedEventArgs e)
		{
			PostControl newPost = new PostControl();
			r_panel.Children.Add(newPost);
		}

		

		void postList_Delete(object sender, RoutedEventArgs e)
		{
			if (!(sender is User)) { return; }

			var user = (User)sender;
			this.r_panel.Children.Remove(user);
		}

		void l_button_Click(object sender, RoutedEventArgs e)
		{
			User newUser = new User() { Title="NewUser"};
			newUser.Delete += userList_Delete;
			l_panel.Children.Add(newUser);
		}

		private void user_Delete(object sender, RoutedEventArgs e)
		{
			if (!(sender is User)) { return; }

			var user = (User)sender;

			this.currentUser.Children.Remove(user);
		}
		void userList_Delete(object sender, RoutedEventArgs e)
		{
			if (!(sender is User)) { return; }

			var user = (User)sender;
			this.l_panel.Children.Remove(user);
		}
    }
}
