namespace PsuAccSystem.Model
{
	public class Worker
	{
		public Worker(int id, string name, string surName, string thirdName, string login, string password)
		{
			Name = name;
			SurName = surName;
			ThirdName = thirdName;
			Id = id;
			Login = login;
			Password = password;
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string SurName { get; set; }
		public string ThirdName { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public string FIO => $"{SurName} {Name} {ThirdName}";
	}
}
