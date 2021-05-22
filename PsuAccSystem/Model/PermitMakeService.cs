using PsuAccSystem.Interfaces;
using System.ComponentModel;

namespace PsuAccSystem.Forms.Pages
{
	internal class PermitMakeService : IService, INotifyPropertyChanged
	{
		public PermitMakeService()
		{
			Name = "Изготовление пропуска";
		}

		public string Name { get; set; }


		public event PropertyChangedEventHandler PropertyChanged;

		public double GetCost()
		{
			return 200;
		}
	}
}