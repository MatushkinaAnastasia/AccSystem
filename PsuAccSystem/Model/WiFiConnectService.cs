using PsuAccSystem.Interfaces;
using System.ComponentModel;

namespace PsuAccSystem.Forms.Pages
{
	internal class WiFiConnectService : IService, INotifyPropertyChanged
	{
		public WiFiConnectService()
		{
			Name = "Подключение беспроводного интернета";
		}

		public string Name { get; set; }


		public event PropertyChangedEventHandler PropertyChanged;

		public double GetCost()
		{
			return 300;
		}
	}
}