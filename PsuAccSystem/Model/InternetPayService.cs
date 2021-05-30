using PsuAccSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PsuAccSystem.Model
{
	public class InternetPayService: IService, INotifyPropertyChanged
	{
		public static readonly string ServiceName = "Оплата интернета";

		public static readonly string type = nameof(InternetPayService);

		public InternetPayService()
		{
			Name = ServiceName;
			Tarif = Tarif.Tarifs.First();
			Client = Clients.First();
		}

		public string Name { get; set; }
		public ObservableCollection<Client> Clients => Data.Instance.Clients;
		public Client Client { get; set; }

		public Tarif Tarif { get; set; }

		public ObservableCollection<Tarif> Tarifs => Tarif.Tarifs;

		public event PropertyChangedEventHandler PropertyChanged;

		public string ClientName { get; set; }

		public void Clear()
		{
			Client = null;
		}

		public double GetCost()
		{
			return Tarif.Cost;
		}
	}
}
