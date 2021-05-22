using PsuAccSystem.Interfaces;
using System.ComponentModel;

namespace PsuAccSystem.Forms.Pages
{
	internal class PsuEmailProvideService : IService, INotifyPropertyChanged
	{
		public PsuEmailProvideService()
		{
			Name = "Предостовления почты на домене @psu.ru";
		}

		public string Name { get; set; }


		public event PropertyChangedEventHandler PropertyChanged;

		public double GetCost()
		{
			return 0;
		}
	}
}