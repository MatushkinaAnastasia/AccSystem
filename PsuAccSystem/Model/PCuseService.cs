using PsuAccSystem.Interfaces;
using PsuAccSystem.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace PsuAccSystem.Forms.Pages
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
		public double PsuUseCost { get; set; }
		public ObservableCollection<Client> Clients => Data.Instance.Clients;
		public Client Client { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;

		public double GetCost()
		{
			return PsuUseCost * Time;
		}
	}
}