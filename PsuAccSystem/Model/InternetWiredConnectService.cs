using PsuAccSystem.Interfaces;
using PsuAccSystem.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace PsuAccSystem.Forms.Pages
{
	internal class InternetWiredConnectService : IService, INotifyPropertyChanged
	{
		public static readonly string ServiceName = "Подключение проводного интернета";
		public InternetWiredConnectService()
		{
			Name = "Подключение проводного интернета";
			Tarif = Tarif.Tarifs.First();
		}

		public string Name { get; set; }

		public Tarif Tarif { get; set; }

		public ObservableCollection<Tarif> Tarifs => Tarif.Tarifs;

		public Client Client { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;

		public double GetCost()
		{
			return Tarif.Cost;
		}
	}
}