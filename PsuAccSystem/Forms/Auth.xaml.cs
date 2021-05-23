using PsuAccSystem.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
		public string Password { get; set; } = string.Empty;
		public ObservableCollection<Worker> Workers => Data.Instance.Workers;

		public event PropertyChangedEventHandler PropertyChanged;

		private void Enter(object sender, RoutedEventArgs e)
		{
			var worker = Workers.FirstOrDefault(x => x.Login == Login);
			if (worker == null)
			{
				MessageBox.Show("Неверный логин! Попробуйте еще раз или обратитесь к администратору.");
			} else if (Password == worker.Password)
			{
				Data.Instance.CurrentWorker = worker;
				var viewOrder = new MainForm();
				viewOrder.Show();
				Close();
			}
			else
			{
				MessageBox.Show("Неверный пароль! Попробуйте еще раз.");
			}
		}
	}
}
