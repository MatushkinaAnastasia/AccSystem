using PsuAccSystem.Forms.Pages;
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
	/// Логика взаимодействия для PhotocopyServiceControl.xaml
	/// </summary>
	public partial class PhotocopyServiceControl : UserControl
	{
		public PhotocopyServiceControl(PhotocopyService photocopyService)
		{
			InitializeComponent();
			DataContext = photocopyService;
		}
	}
}
