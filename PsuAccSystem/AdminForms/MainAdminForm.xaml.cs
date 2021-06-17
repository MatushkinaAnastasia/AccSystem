using PsuAccSystem.AdminForms.Pages;
using System;
using System.Collections.Generic;
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
	public partial class MainAdminForm : Window
	{
		public Page MainPage { get; set; }
		public MainAdminForm()
		{
			InitializeComponent();
			MainPage = new MainPage();

			DataContext = this;
		}
	}
}
