using PsuAccSystem.Interfaces;
using PsuAccSystem.Model;
using System.ComponentModel;

namespace PsuAccSystem.Services
{
	internal class PermitMakeService : IService, INotifyPropertyChanged
	{
		public static readonly string ServiceName = "Изготовление пропуска";
		public PermitMakeService()
		{
			Name = "Изготовление пропуска";
		}

		public string Name { get; set; }
		public Client Client { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

		public event PropertyChangedEventHandler PropertyChanged;

		public void Clear()
		{
	
		}

		public double GetCost()
		{
			return 200;
		}
	}
}