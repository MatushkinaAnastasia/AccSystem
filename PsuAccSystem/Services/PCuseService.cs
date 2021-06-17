using PsuAccSystem.Interfaces;
using PsuAccSystem.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace PsuAccSystem.Services
{
	public class PCuseService : IService, INotifyPropertyChanged
	{
		public static readonly string ServiceName = "Использование компьютера";
		public PCuseService()
		{
			Name = "Использование компьютера";
			Time = 10;
			PsuUseCost = 0.7;
			Client = Clients.First();
		}

		public string Name { get; set; }
		public int Time { get; set; }
		public ObservableCollection<Client> Clients => Data.Instance.Clients;
		public Client Client { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;
		public double PsuUseCost { get => GetCost(); set => GetCost(); }

		public void Clear()
		{
			
		}

		public double GetCost()
		{
			return Math.Round(0.7 * Time, 2);
		}
	}
}