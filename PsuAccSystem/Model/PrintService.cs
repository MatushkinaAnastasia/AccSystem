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
		}

		public string Name { get; set; }

		public int PageCount { get; set; }
		public int PageCost { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;

		public int GetCost()
		{
			return PageCost * PageCount;
		}
	}
}
