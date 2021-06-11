using PsuAccSystem.Model;
using System;
using System.Collections.Generic;
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
	/// Логика взаимодействия для DeletionReason.xaml
	/// </summary>
	public partial class DeletionReason : Window
	{
		public string Reason { get; set; }
		public DeletionReason()
		{
			InitializeComponent();
			DataContext = this;
		}

		private void SendMessage(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(Reason))
			{
				MessageBox.Show("Уважаемый(-ая), " + Data.Instance.CurrentWorker.Name + " " + Data.Instance.CurrentWorker.ThirdName + "! Укажите, пожалуйста, причину удаления в текстовом поле!");
			} else if (Reason.Length < 10)
			{
				MessageBox.Show("Уважаемый(-ая), " + Data.Instance.CurrentWorker.Name + " " + Data.Instance.CurrentWorker.ThirdName + "! Опишите, пожалуйста, причину более подробно.");
			} else
			{
				MessageBox.Show("Причина сохранена! Спасибо.");
				DialogResult = true;
				Close();
			}
		}

		private void Cancel(object sender, RoutedEventArgs e)
		{
			Close();
		}
	}
}
