using PsuAccSystem.Interfaces;
using System.ComponentModel;

namespace PsuAccSystem.Forms.Pages
{
	public class PhotocopyService : IService, INotifyPropertyChanged
	{
		public PhotocopyService()
		{
			Name = "Ксерокопия";
			PageCost = 2; // 2 рубля лист
		}

		public string Name { get; set; }

		public int PageCount { get; set; }
		public int PageCost { get; set; }
		public double FinallyCost { get => GetCost(); set => GetCost(); }

		public event PropertyChangedEventHandler PropertyChanged;

		public double GetCost()
		{
			return PageCost * PageCount;
		}
	}
}