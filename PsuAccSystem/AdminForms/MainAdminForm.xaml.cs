using PsuAccSystem.AdminForms.Pages;
using PsuAccSystem.Forms;
using PsuAccSystem.Interfaces;
using PsuAccSystem.Model;
using PsuAccSystem.Tools;
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
using System.Windows.Shapes;

namespace PsuAccSystem.AdminForms
{
	/// <summary>
	/// Логика взаимодействия для MainAdminForm.xaml
	/// </summary>
	public partial class MainAdminForm : Window, INotifyPropertyChanged, IPageHandler
	{
		public Page MainPage { get; set; }
		public MainAdminForm()
		{
			InitializeComponent();
			MainPage = new MainPage(this);

			ExitCommand = new RelayCommand(Exit);

			DataContext = this;
		}

		public ICommand ExitCommand { get; private set; }

		public event PropertyChangedEventHandler PropertyChanged;
		private void Exit()
		{
			Data.Instance.CurrentWorker = null;
			var auth = new Auth();
			auth.Show();
			Close();
		}
	}
}
