using PsuAccSystem.Model;
using PsuAccSystem.Tools;
using System.ComponentModel;
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
		public ChangeOrderPage(Order order)
		{
			InitializeComponent();

			ChangeOrderCommand = new RelayCommand(ChangeOrder);

			ThisOrder = order;
			IsReadOnly = true;
			ColorButton = new SolidColorBrush(Color.FromArgb(255, 226, 127, 27));
			ContentButton = "🖊";

			DataContext = this;
		}

		public ICommand ChangeOrderCommand { get; private set; }

		public event PropertyChangedEventHandler PropertyChanged;

		private void ChangeOrder()
		{
			if (IsReadOnly == true)
			{
				IsReadOnly = false;
				ColorButton = new SolidColorBrush(Color.FromArgb(255, 29, 192, 62));
				ContentButton = "✔️";
			} 
			else
			{
				IsReadOnly = true;
				ColorButton = new SolidColorBrush(Color.FromArgb(255, 226, 127, 27));
				ContentButton = "🖊";
			}
		}
	}
}
