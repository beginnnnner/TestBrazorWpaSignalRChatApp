namespace TestDLL
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }



    public class Users
    {
        private Dictionary<string, User> dic = new Dictionary<string, User>();

        public User this[string name]
        {
            set { dic[name] = value; }
            get { return dic.ContainsKey(name) ? dic[name] : null; }
        }

        public void Add(string name, string mail)
        {
            dic.Add(name, new User(name, mail));
        }
    }

    public class User
    {
        public string Name;
        public string Mail;
        public User(string name, string mail) 
        {
            Name = name;
            Mail = mail;
        }
        public string? ToString() 
        {
            return $"{Name}:{Mail}"; 
        }
    }
}