using System;
using System.Collections.Generic;
using System.Text;

namespace PsuAccSystem.Model
{
	public class Order
	{
		public Order(long id, string service, Client customer, Worker worker, string price, string date, string time, string status)
		{
			Id = id;
			Service = service;
			Customer = customer;
			Price = price;
			Worker = worker;
			Date = date;
			Time = time;
			Status = status;
		}

		public long Id { get; set; }
		public string Service { get; set; }
		public Client Customer { get; set; }
		public Worker Worker { get; set; }
		public string Price { get; set; }
		public string Date { get; set; }
		public string Time { get; set; }
		public string Status { get; set; }
	}
}
