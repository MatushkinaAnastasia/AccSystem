﻿using PsuAccSystem.Interfaces;
using PsuAccSystem.Model;
using System.ComponentModel;

namespace PsuAccSystem.Services
{
	internal class WiFiConnectService : IService, INotifyPropertyChanged
	{
		public static readonly string ServiceName = "Подключение беспроводного интернета";
		public WiFiConnectService()
		{
			Name = "Подключение беспроводного интернета";
		}

		public string Name { get; set; }
		public Client Client { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

		public event PropertyChangedEventHandler PropertyChanged;

		public void Clear()
		{
			
		}

		public double GetCost()
		{
			return 300;
		}
	}
}