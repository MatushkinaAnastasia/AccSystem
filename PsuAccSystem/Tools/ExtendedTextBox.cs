using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace PsuAccSystem.Tools
{
	public class ExtendedTextBox : TextBox
	{
		private string placeholder = string.Empty;

		private bool isPlaceHolder = true;

		public ExtendedTextBox()
		{
			GotFocus += (s, e) => GFocus();
			LostFocus += (s, e) => LFocus();
			Loaded += (s, e) =>
			{
				Text = Placeholder;
				TextChanged += (s, e) => isPlaceHolder = false;
			};
			Foreground = Brushes.Gray;
		}


		private void GFocus()
		{
			if (Text == Placeholder && isPlaceHolder)
			{
				Text = string.Empty;
			}

			Foreground = Brushes.Black;
		}

		private void LFocus()
		{
			if (string.IsNullOrEmpty(Text))
			{
				Text = Placeholder;
				isPlaceHolder = true;
				Foreground = Brushes.Gray;
			}
		}

		public string Placeholder 
		{
			get => placeholder;
			set
			{
				placeholder = value;
				Text = value;
			} 
		}
	}
}
