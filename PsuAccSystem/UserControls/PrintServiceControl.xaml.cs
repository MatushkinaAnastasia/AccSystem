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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PsuAccSystem.UserControls
{
	/// <summary>
	/// Логика взаимодействия для PrintServiceControl.xaml
	/// </summary>
	public partial class PrintServiceControl : UserControl
	{
		public PrintServiceControl(PrintService printService )
		{
			InitializeComponent();
			DataContext = printService;
		}
	}
}
