using System;
using System.Collections.Generic;
using System.Text;

namespace PsuAccSystem.Model
{
	public class Client
	{
		public Client(int id, string name, string surName, string thirdName, string email, string phoneNumber)
		{
			Id = id;
			Name = name;
			SurName = surName;
			ThirdName = thirdName;
			Email = email;
			PhoneNumber = phoneNumber;
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string SurName { get; set; }
		public string ThirdName { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public string FIO => $"{Name} {SurName} {ThirdName}";
	}
}
