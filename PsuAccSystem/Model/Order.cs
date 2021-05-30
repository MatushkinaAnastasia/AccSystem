using System;
using System.Collections.Generic;
using System.Text;

namespace PsuAccSystem.Model
{
	public class Order
	{
		public Order(long id, string service, Client customer, Worker worker, string price, DateTime date, DateTime time, string status)
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
		public DateTime Date { get; set; }
		public DateTime Time { get; set; }
		public string Status { get; set; }
		public string FullOrder => $"{Service} {Customer.FIO} {Worker.FIO} {Price} {Date.ToString()} {Time.ToString()} {Status}";
	}
}
