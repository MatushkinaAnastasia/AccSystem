using PsuAccSystem.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PsuAccSystem.Tools
{
	public static class Extensions
	{
		public static Order DeepClone(this Order o)
		{
			return new Order(o.Id, o.Service, o.Customer, o.Worker, o.Price, o.Date, o.Time);
		}
	}
}
