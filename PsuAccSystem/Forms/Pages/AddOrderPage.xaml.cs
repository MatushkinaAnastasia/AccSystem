﻿using PsuAccSystem.Interfaces;
using PsuAccSystem.Model;
using PsuAccSystem.Services;
using PsuAccSystem.UserControls;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace PsuAccSystem.Forms.Pages
{
	public partial class AddOrderPage : Page, INotifyPropertyChanged
	{
		private IService selectedService;

		public AddOrderPage()
		{
			InitializeComponent();
			DataContext = this;


			Services = new ObservableCollection<IService>
			{
				new PrintService(),
				new InternetPayService(),
				new PhotocopyService(), 
				new InternetWiredConnectService(),
				new WiFiConnectService(),
				new PermitMakeService(),
				new PsuEmailProvideService(),
				new PCuseService(),
			};
			SelectedService = Services.First();
		}

		public ObservableCollection<IService> Services { get; set; }

		public UserControl CurrentControl { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;

		public IService SelectedService
		{
			get => selectedService;
			set
			{
				selectedService = value;

				if (selectedService is PrintService printService)
				{
					CurrentControl = new PrintServiceControl(printService);
				}
				else if (selectedService is InternetPayService internetService)
				{
					CurrentControl = new InternetPayServiceControl(internetService);
				}
				else if (selectedService is PhotocopyService photocopyService)
				{
					CurrentControl = new PhotocopyServiceControl(photocopyService);
				}
				else if (selectedService is PCuseService pCuse)
				{
					CurrentControl = new PCuseServiceControl(pCuse);
				}
				else
				{
					throw new NotImplementedException();
				}
			}
		}

		private void CalcCostClick(object sender, RoutedEventArgs e)
		{
			double lastCost = 0;
			if (SelectedService != null)
			{
				lastCost = SelectedService.GetCost();
			}
			Order newOrder = new Order(11, SelectedService.Name, SelectedService.Client, Data.Instance.CurrentWorker, lastCost.ToString(), DateTime.Now, DateTime.Now, "Выполнен");
			Data.Instance.Orders.Add(newOrder);

			SelectedService.Clear();
			
			MessageBox.Show($"Итого:{lastCost} руб.\nЗапись добавлена!");

			NavigationService.GoBack();

		}
	}
}
