using PsuAccSystem.Interfaces;
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

namespace PsuAccSystem.AdminForms.Pages
{
	/// <summary>
	/// Логика взаимодействия для AddWorkersForm.xaml
	/// </summary>
	public partial class AddWorkersForm : Page, INotifyPropertyChanged
	{
		public string SurName { get; set; }
		public string FirstName { get; set; }
		public string ThirdName { get; set; }
		public AddWorkersForm()
		{
			InitializeComponent();
			DataContext = this;
		}
		public event PropertyChangedEventHandler PropertyChanged;

		private void AddClient(object sender, RoutedEventArgs e)
		{

		}
	}
}
