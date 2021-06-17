using PsuAccSystem.Forms.Pages;
using PsuAccSystem.Interfaces;
using PsuAccSystem.Services;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace PsuAccSystem.Model
{
	public class Data
	{
		public const string workerType = "Сотрудник";
		public const string adminType = "Администратор";
		private Data()
		{
			InitializeObjects();
			Orders.CollectionChanged += (s, e) => Filter = filter;
			Filter = string.Empty;
		}
		private void InitializeObjects()
		{
			Clients = new ObservableCollection<Client>
			{
				new Client(0, "*", "","", "", ""),
				new Client(1, "Дмитрий", "Дмитриев","Дмитриевич", "dm@mail.ru", "85678995578"),
				new Client(2, "Дмитрий", "Дмитров","Дмитрович", "aasden@", "8438995578"),
				new Client(3, "Демитрий", "Демтриев","Демитриевич", "aaaaden@", "85678995578"),
				new Client(4, "Иван", "Иванов","Иванович", "aaaaden@", "85678995578"),
				new Client(5, "Илья", "Ильин","Ильинович", "aaaaden@", "85678995578"),
				new Client(6, "Анастас", "Анастасов","Анастасович", "aaaaden@", "85678995578"),
				new Client(7, "Артем", "Артемов","Артемович", "aaaaden@", "85678995578"),
				new Client(8, "Арнольд", "Арнольдов","Арнольдович", "aaaaden@", "85678995578"),
				new Client(9, "Архыз", "Архызов","Архызович", "aaaaden@", "85678995578"),
			};


			Workers = new ObservableCollection<Worker>
			{
				new Worker(1, "Денис", "Лазуков", "Борисович", "denis", "123", workerType),
				new Worker(2, "Анастасия", "Матушкина", "Алексеевна", "nasya", "123", adminType),
			};

			Orders = new ObservableCollection<Order>
			{
				new Order(1, InternetPayService.ServiceName, Clients[1], Workers[1], "150", DateTime.Now, DateTime.Now + TimeSpan.FromMinutes(5), "В обработке"),
				new Order(2, PCuseService.ServiceName, Clients[1], Workers[1], "150", DateTime.Now, DateTime.Now + TimeSpan.FromMinutes(10), "В обработке"),
				new Order(3, PermitMakeService.ServiceName, Clients[2], Workers[1], "150", DateTime.Now, DateTime.Now + TimeSpan.FromMinutes(15), "В обработке"),
				new Order(4, PrintService.ServiceName, Clients[0], Workers[1], "150", DateTime.Now, DateTime.Now + TimeSpan.FromMinutes(20), "В обработке"),
				new Order(5, PhotocopyService.ServiceName, Clients[0], Workers[1], "150", DateTime.Now, DateTime.Now + TimeSpan.FromMinutes(25), "В обработке"),
				new Order(6, WiFiConnectService.ServiceName, Clients[3], Workers[1], "150", DateTime.Now, DateTime.Now + TimeSpan.FromMinutes(35), "В обработке"),
				new Order(7, InternetWiredConnectService.ServiceName, Clients[4], Workers[1], "150", DateTime.Now, DateTime.Now + TimeSpan.FromMinutes(45), "В обработке"),
				new Order(8, PCuseService.ServiceName, Clients[0], Workers[1], "150", DateTime.Now, DateTime.Now + TimeSpan.FromMinutes(55), "В обработке"),
				new Order(9, PermitMakeService.ServiceName, Clients[5], Workers[1], "150", DateTime.Now, DateTime.Now + TimeSpan.FromMinutes(65), "В обработке"),
				new Order(10, PermitMakeService.ServiceName, Clients[6], Workers[1], "150", DateTime.Now, DateTime.Now + TimeSpan.FromMinutes(75), "В обработке"),
				new Order(11, PrintService.ServiceName, Clients[0], Workers[1], "150", DateTime.Now, DateTime.Now + TimeSpan.FromMinutes(95), "В обработке"),
				new Order(12, PrintService.ServiceName, Clients[0], Workers[1], "150", DateTime.Now, DateTime.Now + TimeSpan.FromMinutes(85), "В обработке"),
				new Order(13, PrintService.ServiceName, Clients[0], Workers[1], "150", DateTime.Now, DateTime.Now + TimeSpan.FromMinutes(85), "В обработке"),
				new Order(14, InternetPayService.ServiceName, Clients[7], Workers[1], "150", DateTime.Now, DateTime.Now + TimeSpan.FromMinutes(65), "В обработке"),
				new Order(15, InternetPayService.ServiceName, Clients[8], Workers[1], "150", DateTime.Now, DateTime.Now + TimeSpan.FromMinutes(55), "В обработке"),
				new Order(16, InternetPayService.ServiceName, Clients[9], Workers[1], "150", DateTime.Now, DateTime.Now + TimeSpan.FromMinutes(45), "В обработке"),
				new Order(17, InternetPayService.ServiceName, Clients[9], Workers[1], "150", DateTime.Now, DateTime.Now + TimeSpan.FromMinutes(35), "В обработке"),
				new Order(18, InternetPayService.ServiceName, Clients[2], Workers[1], "150", DateTime.Now, DateTime.Now + TimeSpan.FromMinutes(25), "В обработке"),
				new Order(19, InternetPayService.ServiceName, Clients[2], Workers[1], "150", DateTime.Now, DateTime.Now + TimeSpan.FromMinutes(15), "В обработке"),
				new Order(20, InternetPayService.ServiceName, Clients[2], Workers[1], "150", DateTime.Now, DateTime.Now + TimeSpan.FromMinutes(15), "В обработке"),
			};


			Statuses = new ObservableCollection<string>
			{
				"В обработке",
				"Выполнен",
				"Поступил",
			};
		}


		public ObservableCollection<Order> FilteredOrders { get; private set; } = new ObservableCollection<Order>();
		public string Filter
		{
			get => filter;
			set
			{
				filter = value;
				if (filter == null) filter = string.Empty;

				UpdateFilter();
			}
		}
		public DateTime DateFirst
		{
			get => dateFirst;
			set
			{
				dateFirst = value;
				UpdateFilter();
			}
		}
		public DateTime DateSecond
		{
			get => dateSecond;
			set
			{
				dateSecond = value;
				UpdateFilter();
			}
		}
		private void UpdateFilter()
		{
			FilteredOrders.Clear();
			var f = filter.ToLower();

			foreach (var order in Orders)
			{
				if (order.FullOrder.ToLower().Contains(f) && dateFirst <= order.Date && dateSecond >= order.Date)
				{
					FilteredOrders.Add(order);
				}
			}
		}


		public ObservableCollection<Order> Orders { get; set; }
		public ObservableCollection<Client> Clients { get; private set; }
		public ObservableCollection<Worker> Workers { get; private set; }
		public Worker CurrentWorker { get; set; }
		public ObservableCollection<string> Statuses { get; set; }


		private string filter;
		private DateTime dateFirst;
		private DateTime dateSecond;


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