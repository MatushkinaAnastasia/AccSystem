using PsuAccSystem.Model;
using PsuAccSystem.Tools;
using System.ComponentModel;
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
		public Brush ColorButton { get; set; }
		public string ContentButton { get; set; }
		public Brush BackgroundTB { get; set; }
		public string CurrentWorker => Data.Instance.CurrentWorker.FIO;
		public ChangeOrderPage(Order order)
		{
			InitializeComponent();

			ChangeOrderCommand = new RelayCommand(ChangeOrder);
			DeleteOrderCommand = new RelayCommand(DeleteOrder);

			ThisOrder = order;
			IsReadOnly = true;
			ColorButton = new SolidColorBrush(Color.FromArgb(255, 226, 127, 27));
			ContentButton = "🖊";
			BackgroundTB = new SolidColorBrush(Color.FromArgb(255, 238, 238, 238));

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
				Data.Instance.Orders.Remove(ThisOrder);
				MessageBox.Show("Заказ удален успешно!");
				NavigationService.GoBack();
			}
		}
		private void ChangeOrder()
		{
			if (IsReadOnly == true)
			{
				IsReadOnly = false;
				ColorButton = new SolidColorBrush(Color.FromArgb(255, 29, 192, 62));
				ContentButton = "✔️";
				BackgroundTB = new SolidColorBrush(Color.FromArgb(255, 209, 217, 222));
			}
			else
			{
				IsReadOnly = true;
				ColorButton = new SolidColorBrush(Color.FromArgb(255, 226, 127, 27));
				ContentButton = "🖊";
				BackgroundTB = new SolidColorBrush(Color.FromArgb(255, 238, 238, 238));
			}
		}
	}
}
