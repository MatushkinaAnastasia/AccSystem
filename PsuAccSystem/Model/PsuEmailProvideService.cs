using PsuAccSystem.Interfaces;
using PsuAccSystem.Model;
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
		public Client Client { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

		public event PropertyChangedEventHandler PropertyChanged;

		public double GetCost()
		{
			return 0;
		}
	}
}