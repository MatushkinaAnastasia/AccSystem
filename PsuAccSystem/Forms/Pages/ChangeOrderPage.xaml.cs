using PsuAccSystem.Model;
using PsuAccSystem.Tools;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace PsuAccSystem.Forms.Pages
{
	/// <summary>
	/// Логика взаимодействия для ChangeOrderPage.xaml
	/// </summary>
	public partial class ChangeOrderPage : Page, INotifyPropertyChanged
	{
		public Order ThisOrder { get; set; }
		public bool IsReadOnly { get; set; }
		public bool IsEditable { get; set; }
		public Brush ColorButton { get; set; }
		public string ContentButton { get; set; }
		public Brush BackgroundTB { get; set; }
		public string CurrentWorker => Data.Instance.CurrentWorker.FIO;
		public ObservableCollection<Client> Clients => Data.Instance.Clients;
		public Client Client { get; set; }		
		public ObservableCollection<string> Statuses => Data.Instance.Statuses;
		public string Status { get; set; }
		public ChangeOrderPage(Order order)
		{
			InitializeComponent();

			ChangeOrderCommand = new RelayCommand(ChangeOrder);
			DeleteOrderCommand = new RelayCommand(DeleteOrder);

			ThisOrder = order;
			IsReadOnly = true;
			IsEditable = false;
			ColorButton = new SolidColorBrush(Color.FromArgb(255, 226, 127, 27));
			ContentButton = "🖊";
			BackgroundTB = new SolidColorBrush(Color.FromArgb(255, 238, 238, 238));

			Client = ThisOrder.Customer;
			Status = ThisOrder.Status;

			DataContext = this;
		}

		public ICommand ChangeOrderCommand { get; private set; }
		public ICommand DeleteOrderCommand { get; private set; }

		public event PropertyChangedEventHandler PropertyChanged;

		private void DeleteOrder()
		{
			var result = MessageBox.Show("Вы уверены, что хотите удалить заказ?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
			if (result == MessageBoxResult.Yes)
			{
				var deleteReason = new DeletionReason();
				deleteReason.ShowDialog();
				if (deleteReason.DialogResult == true)
				{
					MessageBox.Show("Заказ удален успешно!");
					Data.Instance.Orders.Remove(ThisOrder);
					NavigationService.GoBack();
				}
			}
		}
		private void ChangeOrder()
		{
			if (IsReadOnly == true)
			{
				IsReadOnly = false;
				ColorButton = new SolidColorBrush(Color.FromArgb(255, 29, 192, 62));
				ContentButton = "✔️";
				BackgroundTB = new SolidColorBrush(Color.FromArgb(255, 176, 194, 192));
				IsEditable = true;
				ComboboxClients.Visibility = Visibility.Visible;
				HiddenTextBox.Visibility = Visibility.Hidden;
			}
			else
			{
				IsReadOnly = true;
				ColorButton = new SolidColorBrush(Color.FromArgb(255, 226, 127, 27));
				ContentButton = "🖊";
				BackgroundTB = new SolidColorBrush(Color.FromArgb(255, 238, 238, 238));
				IsEditable = false;
				ComboboxClients.Visibility = Visibility.Hidden;
				HiddenTextBox.Visibility = Visibility.Visible;
				HiddenTextBox.Text = Client.FIO;
				Client = null;
			}
		}
	}
}
