using PsuAccSystem.Interfaces;
using PsuAccSystem.Model;
using System.ComponentModel;

namespace PsuAccSystem.Forms.Pages
{
	public class PhotocopyService : IService, INotifyPropertyChanged
	{
		public static readonly string ServiceName = "Ксерокопия";
		public PhotocopyService()
		{
			Name = "Ксерокопия";
			PageCost = 2; // 2 рубля лист
			Client = new Client(0, "*","*","*","*","*");
		}

		public string Name { get; set; }

		public int PageCount { get; set; }
		public int PageCost { get; set; }
		public double FinallyCost { get => GetCost(); set => GetCost(); }
		public Client Client { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;

		public double GetCost()
		{
			return PageCost * PageCount;
		}
	}
}