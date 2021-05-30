using PsuAccSystem.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PsuAccSystem.Interfaces
{
	public interface IService
	{
		public string Name { get; set; }
		public Client Client { get; set; }
		public double GetCost();
		public void Clear();
	}
}
