using PsuAccSystem.Interfaces;
using PsuAccSystem.Model;
using System.ComponentModel;

namespace PsuAccSystem.Forms.Pages
{
	public class PCuseService : IService, INotifyPropertyChanged
	{
		public PCuseService()
		{
			Name = "Использование компьютера";
			Time = 10;
			PsuUseCost = 0.7;
		}

		public string Name { get; set; }
		public int Time { get; set; }
		public double PsuUseCost { get; set; }
		public Client Client { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

		public event PropertyChangedEventHandler PropertyChanged;

		public double GetCost()
		{
			return PsuUseCost * Time;
		}
	}
}