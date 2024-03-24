namespace Lab4Web.Services.Linq
{
    public class User
    {
        public Guid Id { get; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsAdmin { get; set; }

        private IPasswordHasher _passwordHasher;

        public User(string username, string email, string password, DateTime createdDate, bool isAdmin, IPasswordHasher passwordHasher) 
        {
            Id = Guid.NewGuid();
            Username = username;
            Email = email;

            _passwordHasher = passwordHasher;
            Password = _passwordHasher.Hash(password);

            CreatedDate = createdDate;
            IsAdmin = isAdmin;
        }

        public override string ToString()
        {
            string result = "";
            result += $"Student: {Id}";
            result += $"    Username: {Username}";
            result += $"    Email: {Email}";
            result += $"    Password: {Password}";
            result += $"    CreatedDate: {CreatedDate}";
            result += $"    IsAdmin: {IsAdmin}";
            return result;
        }
    }
}
