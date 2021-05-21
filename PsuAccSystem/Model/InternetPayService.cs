using PsuAccSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PsuAccSystem.Model
{
	public class InternetPayService: IService, INotifyPropertyChanged
	{
		public InternetPayService()
		{
			Name = "Оплата интернета";
			Tarif = Tarif.Tarifs.First();
		}

		public string Name { get; set; }

		public Tarif Tarif { get; set; }

		public ObservableCollection<Tarif> Tarifs => Tarif.Tarifs;

		public event PropertyChangedEventHandler PropertyChanged;

		public int GetCost()
		{
			return Tarif.Cost;
		}
	}
}
