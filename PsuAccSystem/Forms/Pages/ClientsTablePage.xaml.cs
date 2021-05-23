using PsuAccSystem.Interfaces;
using PsuAccSystem.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

namespace PsuAccSystem.Forms.Pages
{
	/// <summary>
	/// Логика взаимодействия для ClientsTable.xaml
	/// </summary>
	public partial class ClientsTablePage : Page
	{
		public ClientsTablePage()
		{
			InitializeComponent();

			DataContext = this;
		}

		public ObservableCollection<Client> Clients { get => Data.Instance.Clients; }
		public Client SelectedClient { get; set; }
	}
}
