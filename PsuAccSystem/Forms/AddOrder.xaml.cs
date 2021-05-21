using PsuAccSystem.Interfaces;
using PsuAccSystem.Model;
using PsuAccSystem.UserControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PsuAccSystem.Forms
{
	/// <summary>
	/// Логика взаимодействия для AddOrder.xaml
	/// </summary>
	public partial class AddOrder : Window, INotifyPropertyChanged
	{
		private IService selectedService;
		public AddOrder()
		{
			InitializeComponent();
			DataContext = this;


			Services = new ObservableCollection<IService>
			{
				new PrintService(),
				new InternetPayService(),
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
				else
				{
					throw new NotImplementedException();
				}
			}
		}

		private void CalcCostClick(object sender, RoutedEventArgs e)
		{
			if (SelectedService != null)
			{
				MessageBox.Show(SelectedService.GetCost().ToString());
			}
		}
	}
}
