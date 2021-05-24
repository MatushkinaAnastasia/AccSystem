using PsuAccSystem.Forms.Pages;
using PsuAccSystem.Interfaces;
using System;
using System.Collections.ObjectModel;

namespace PsuAccSystem.Model
{
	public class Data
	{
		private Data()
		{
			InitializeObjects();
			
		}

		private void InitializeObjects()
		{
			Clients = new ObservableCollection<Client>
			{
				new Client(2, "Дмитрий", "Дмитриев","Дмитриевич", "den@", "85678995578"),
				new Client(3, "Кот", "Котов","Котович", "aasden@", "8438995578"),
				new Client(4, "Архыз", "Архызов","Архызович", "aaaaden@", "85678995578"),
			};

			Workers = new ObservableCollection<Worker>
			{
				new Worker(1, "Денис", "Лазуков", "Борисович", "denis", "123"),
				new Worker(2, "Анастасия", "Матушкина", "Алексеевна", "nasya", "123"),
			};

			Orders = new ObservableCollection<Order>
			{
				new Order(1, InternetPayService.ServiceName, Clients[0], Workers[0], "150", DateTime.Now, DateTime.Now, "Поступил"),
				new Order(4, "", Clients[1], Workers[0], "150", DateTime.Now, DateTime.Now, "Ожидает оплаты"),
				new Order(5, "", Clients[2], Workers[1], "150", DateTime.Now, DateTime.Now, "В обработке"),
			};
		}

		public ObservableCollection<Order> Orders { get; private set; }
		public ObservableCollection<Client> Clients { get; private set; }
		public ObservableCollection<Worker> Workers { get; private set; }
		public Worker CurrentWorker { get; set; }



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