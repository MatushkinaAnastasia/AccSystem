using PsuAccSystem.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PsuAccSystem.Forms
{
	/// <summary>
	/// Логика взаимодействия для ViewOrder.xaml
	/// </summary>
	public partial class ViewOrder : Window
	{
		public ViewOrder()
		{
			InitializeComponent();
			Orders = new ObservableCollection<Order>
			{
				new Order(1, "привет", "вася", "раевский", "15/15/15", "15:34"),
				new Order(2, "приседания", "миша", "раевский", "15/15/15", "15:35"),
				new Order(4, "привет", "вася", "раевский", "11/15/15", "11:34"),
				new Order(1, "привет", "вася", "раевский", "15/15/15", "15:34"),
				new Order(2, "приседания", "миша", "раевский", "15/15/15", "15:35"),
				new Order(4, "привет", "вася", "раевский", "11/15/15", "11:34"),
				new Order(1, "привет", "вася", "раевский", "15/15/15", "15:34"),
				new Order(2, "приседания", "миша", "раевский", "15/15/15", "15:35"),
				new Order(4, "привет", "вася", "раевский", "11/15/15", "11:34"),
			};

			DataContext = this;
		}

		public ObservableCollection<Order> Orders { get; private set; }
	}
}
