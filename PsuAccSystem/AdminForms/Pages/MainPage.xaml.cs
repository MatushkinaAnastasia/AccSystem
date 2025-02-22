﻿using PsuAccSystem.Interfaces;
using PsuAccSystem.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PsuAccSystem.AdminForms.Pages
{
	/// <summary>
	/// Логика взаимодействия для MainPage.xaml
	/// </summary>
	public partial class MainPage : Page, INotifyPropertyChanged
	{
		private readonly IPageHandler pageHandler;
		public MainPage(IPageHandler pageHandler)
		{
			InitializeComponent();

			OpenWorkersAddFormCommand = new RelayCommand(OpenAddForm);

			DataContext = this;
			this.pageHandler = pageHandler;
		}

		public ICommand OpenWorkersAddFormCommand { get; private set; }

		public event PropertyChangedEventHandler PropertyChanged;

		private void OpenAddForm()
		{
			pageHandler.MainPage = new AddWorkersForm();
		}

	}
}
