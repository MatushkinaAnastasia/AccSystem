using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PsuAccSystem.Model
{
	public class Tarif
	{
		public static ObservableCollection<Tarif> Tarifs = new ObservableCollection<Tarif>()
		{
			new Tarif("1 мбит/с 450 руб", 450),
			new Tarif("1.2 мбит/с 850 руб", 850),
		};

		public Tarif(string name, int cost)
		{
			Name = name;
			Cost = cost;
		}

		public string Name { get; set; }
		public int Cost { get; set; }
	}
}

