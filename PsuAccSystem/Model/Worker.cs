namespace PsuAccSystem.Model
{
	public class Worker : User
	{
		public Worker(int id, string name, string surName, string thirdName, string login, string password, string usertype)
		{
			Name = name;
			SurName = surName;
			ThirdName = thirdName;
			Id = id;
			Login = login;
			Password = password;
			UserType = usertype;
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string SurName { get; set; }
		public string ThirdName { get; set; }
		public string FIO => $"{SurName} {Name} {ThirdName}";
	}
}
