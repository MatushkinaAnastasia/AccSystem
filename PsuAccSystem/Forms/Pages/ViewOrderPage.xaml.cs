using PsuAccSystem.Interfaces;
using PsuAccSystem.Model;
using PsuAccSystem.Tools;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;

namespace PsuAccSystem.Forms.Pages
{
	/// <summary>
	/// Логика взаимодействия для ViewOrderPage.xaml
	/// </summary>
	public partial class ViewOrderPage : Page, INotifyPropertyChanged
	{
		private readonly IPageHandler pageHandler;
		private DateTime dateSecond;
		private DateTime dateFirst;

		public ViewOrderPage(IPageHandler pageHandler)
		{
			InitializeComponent();

			AddOrderCommand = new RelayCommand(AddOrder);
			ChangeOrderCommand = new RelayCommand(ChangeOrder, () => SelectedOrder != null);

			DateFirst = DateTime.Now.Date;
			DateSecond = DateTime.Now.Date;

			DataContext = this;
			this.pageHandler = pageHandler;
		}

		public ICommand AddOrderCommand { get; private set; }
		public ICommand ChangeOrderCommand { get; private set; }

		public ObservableCollection<Order> Orders => Data.Instance.FilteredOrders;

		public Order SelectedOrder { get; set; }

		public DateTime DateFirst
		{
			get => Data.Instance.DateFirst;
			set => Data.Instance.DateFirst = value;
		}

		public DateTime DateSecond
		{
			get => Data.Instance.DateSecond;
			set => Data.Instance.DateSecond = value + TimeSpan.FromDays(1) - TimeSpan.FromSeconds(1);
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void AddOrder()
		{
			pageHandler.MainPage = new AddOrderPage();
		}

		private void ChangeOrder()
		{
			pageHandler.MainPage = new ChangeOrderPage(SelectedOrder);
		}
	}
}
