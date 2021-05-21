using PsuAccSystem.Interfaces;
using PsuAccSystem.Model;
using PsuAccSystem.Tools;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace PsuAccSystem.Forms.Pages
{
	/// <summary>
	/// Логика взаимодействия для ViewOrderPage.xaml
	/// </summary>
	public partial class ViewOrderPage : Page
	{
		private readonly IPageHandler pageHandler;
		
		public ViewOrderPage(IPageHandler pageHandler)
		{
			InitializeComponent();
			
			AddOrderCommand = new RelayCommand(AddOrder);
			ChangeOrderCommand = new RelayCommand(ChangeOrder, () => SelectedOrder != null);

			DataContext = this;
			this.pageHandler = pageHandler;
		}

		public ICommand AddOrderCommand { get; private set; }
		public ICommand ChangeOrderCommand { get; private set; }
		public ObservableCollection<Order> Orders => Data.Instance.Orders;
		public Order SelectedOrder { get; set; }

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
