using PsuAccSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PsuAccSystem.Model
{
	public class PrintService: IService, INotifyPropertyChanged 
	{
		public PrintService()
		{
			Name = "Печать А4";
			PageCost = 3; // 3 рубля лист
			PageCount = 1;
			Client = new Client(0, "*", "*", "*", "*", "*");
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
