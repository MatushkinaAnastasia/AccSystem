using PsuAccSystem.Forms.Pages;
using PsuAccSystem.Interfaces;
using PsuAccSystem.Tools;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PsuAccSystem.Forms
{
	/// <summary>
	/// Логика взаимодействия для ViewOrder.xaml
	/// </summary>
	public partial class MainForm : Window, INotifyPropertyChanged, IPageHandler
	{
		public MainForm()
		{
			InitializeComponent();
			
			MainPage = new ViewOrderPage(this);
			ExitCommand = new RelayCommand(Exit);
			DataContext = this;
		}

		public Page MainPage { get; set; }
		public ICommand ExitCommand { get; private set; }

		public event PropertyChangedEventHandler PropertyChanged;

		private void Exit()
		{
			var auth = new Auth();
			auth.Show();
			Close();
		}
	}
}
