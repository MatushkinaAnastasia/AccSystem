using PsuAccSystem.Interfaces;
using PsuAccSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PsuAccSystem.Forms.Pages
{
	/// <summary>
	/// Логика взаимодействия для AddClientPage.xaml
	/// </summary>
	public partial class AddClientPage : Page, INotifyPropertyChanged
	{
		public AddClientPage()
		{
			InitializeComponent();
			DataContext = this;
		}

		public string	ClName { get; set; }
		public string SurName { get; set; }
		public string ThirdName { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;

		private void AddClient(object sender, RoutedEventArgs e)
		{
			var client = new Client(10, ClName, SurName, ThirdName, Email, PhoneNumber);
			Data.Instance.Clients.Add(client);
			MessageBox.Show("Информация о клиенте успешно добавлена в список!");
			NavigationService.GoBack();
		}
	}
}
