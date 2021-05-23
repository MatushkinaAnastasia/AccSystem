using System.Collections.ObjectModel;

namespace PsuAccSystem.Model
{
	public class Data
	{
		private Data()
		{
			Clients = new ObservableCollection<Client>
			{
				new Client(2, "denis", "lazuk","bor", "den@", "85678995578"),
				new Client(3, "some", "allazuk","kipbor", "aasden@", "8438995578"),
				new Client(4, "ada", "ala","bor", "aaaaden@", "85678995578"),
			};

			Orders = new ObservableCollection<Order>
			{
				new Order(1, "привет как дела что делаешб", Clients[0], "раевский", "150","15/15/15", "15:34", "Поступил"),
				new Order(4, "как дела что делаешб", Clients[1], "кий", "150","15//15", "15", "Ожидает оплаты"),
				new Order(5, "привет как дела что делаешб", Clients[2], "раевский", "150","15/15/15", "15:34", "В обработке"),
			};
		}

		public ObservableCollection<Order> Orders { get; private set; }
		public ObservableCollection<Client> Clients { get; private set; }



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