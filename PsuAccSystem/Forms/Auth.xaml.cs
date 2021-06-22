using PsuAccSystem.AdminForms;
using PsuAccSystem.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace PsuAccSystem.Forms
{
	/// <summary>
	/// Логика взаимодействия для Auth.xaml
	/// </summary>
	public partial class Auth : Window, INotifyPropertyChanged
	{
		public Auth()
		{
			InitializeComponent();

			DataContext = this;
		}

		public string Login { get; set; } = string.Empty;
		public string Password { private get; set; }
		//public SecureString SecurePassword { private get; set; }
		public ObservableCollection<Worker> Workers => Data.Instance.Workers;

		public event PropertyChangedEventHandler PropertyChanged;

		private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
		{
			if (DataContext != null)
			{ ((dynamic)DataContext).Password = ((PasswordBox)sender).Password; }
		}
		private void Enter(object sender, RoutedEventArgs e)
		{
			var worker = Workers.FirstOrDefault(x => x.Login == Login);
			if (worker == null)
			{
				MessageBox.Show("Неверный логин! Попробуйте еще раз или обратитесь к администратору.");
			}
			else if (Password == worker.Password)
			{
				if (worker.UserType == Data.adminType)
				{
					var result = MessageBox.Show("Войти как администратор?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
					if (result == MessageBoxResult.Yes)
					{
						var adminForm = new MainAdminForm();
						adminForm.Show();
						Close();
					}
					else
					{
						Data.Instance.CurrentWorker = worker;
						var viewOrder = new MainForm();
						viewOrder.Show();
						Close();
					}
				} else
				{
					Data.Instance.CurrentWorker = worker;
					var viewOrder = new MainForm();
					viewOrder.Show();
					Close();
				}
			}
			else
			{
				MessageBox.Show("Неверный пароль! Попробуйте еще раз.");
			}
		}
	}
}
