﻿using PsuAccSystem.Interfaces;
using PsuAccSystem.Model;
using System.ComponentModel;

namespace PsuAccSystem.Services
{
	internal class PsuEmailProvideService : IService, INotifyPropertyChanged
	{
		public static readonly string ServiceName = "Предостовления почты";
		public PsuEmailProvideService()
		{
			Name = "Предостовления почты на домене @psu.ru";
		}

		public string Name { get; set; }
		public Client Client { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

		public event PropertyChangedEventHandler PropertyChanged;

		public void Clear()
		{
			
		}

		public double GetCost()
		{
			return 0;
		}
	}
}