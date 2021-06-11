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

		public ViewOrderPage(IPageHandler pageHandler)
		{
			InitializeComponent();

			AddOrderCommand = new RelayCommand(AddOrder);
			ChangeOrderCommand = new RelayCommand(ChangeOrder, () => SelectedOrder != null);

			DateFirst = DateTime.Now.Date;
			DateSecond = DateTime.Now.Date;

			Data.Instance.Orders.CollectionChanged += Orders_CollectionChanged;

			DataContext = this;
			this.pageHandler = pageHandler;
		}

		private void Orders_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Orders)));
		}

		public ICommand AddOrderCommand { get; private set; }
		public ICommand ChangeOrderCommand { get; private set; }
		public ObservableCollection<Order> Orders => Data.Instance.Orders;
		//public ObservableCollection<Order> Orders => new ObservableCollection<Order>(Data.Instance.Orders.Where(x => x.Date >= DateFirst && x.Date <= DateSecond));
		public Order SelectedOrder { get; set; }
		public DateTime DateFirst { get; set; }
		public DateTime DateSecond 
		{ 
			get => dateSecond;
			set
			{
				dateSecond = value + TimeSpan.FromDays(1) - TimeSpan.FromSeconds(1);
			}
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
