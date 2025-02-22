﻿using PsuAccSystem.Forms.Pages;
using PsuAccSystem.Interfaces;
using PsuAccSystem.Model;
using PsuAccSystem.Tools;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PsuAccSystem.Forms
{
	/// <summary>
	/// Логика взаимодействия для ViewOrder.xaml
	/// </summary>
	public partial class MainForm : Window, INotifyPropertyChanged, IPageHandler
	{
		public MainForm()
		{
			InitializeComponent();

			MainPage = new ViewOrderPage(this);
			ExitCommand = new RelayCommand(Exit);
			OpenClientsTableCommand = new RelayCommand(OpenClientsTable);
			OpenOrdersTableCommand = new RelayCommand(OpenOrdersTable);
			DataContext = this;
		}

		private void OpenOrdersTable()
		{
			MainPage = new ViewOrderPage(this);
		}

		public Page MainPage { get; set; }
		public ICommand ExitCommand { get; private set; }
		public ICommand OpenClientsTableCommand { get; private set; }
		public ICommand OpenOrdersTableCommand { get; private set; }

		public string FilterText 
		{ 
			get => Data.Instance.Filter; 
			set => Data.Instance.Filter = value; 
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OpenClientsTable()
		{
			MainPage = new ClientsTablePage(this);
		}

		private void Exit()
		{
			Data.Instance.CurrentWorker = null;
			var auth = new Auth();
			auth.Show();
			Close();
		}
	}
}
