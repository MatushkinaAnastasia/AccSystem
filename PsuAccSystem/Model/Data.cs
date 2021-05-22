using System.Collections.ObjectModel;

namespace PsuAccSystem.Model
{
	public class Data
	{
		private Data()
		{
			Orders = new ObservableCollection<Order>
			{
				new Order(1, "привет как дела что делаешб", "вася вася васенька", "раевский", "150","15/15/15", "15:34", "Поступил"),
				new Order(4, "как дела что делаешб", "сенька", "кий", "150","15//15", "15", "Ожидает оплаты"),
				new Order(5, "привет как дела что делаешб", "вася вася васенька", "раевский", "150","15/15/15", "15:34", "В обработке"),
			};
		}

		public ObservableCollection<Order> Orders { get; private set; }



		private static Data _instance;
		public static Data Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new Data();
				}

				return _instance;
			}
		}
	}
}