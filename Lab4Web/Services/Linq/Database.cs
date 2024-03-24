namespace Lab4Web.Services.Linq
{
    public static class Database
    {
        private static IPasswordHasher _passwordHasher = new PasswordHasher();

        private static List<User> _users = new List<User>()
        {
            new User("Gabi", "gabi@gmail.com", "gabi", DateTime.Now, true, _passwordHasher),
            new User("Maria", "maria@gmail.com", "maria", DateTime.Now, false, _passwordHasher),
            new User("George", "george@gmail.com", "george", DateTime.Now, false, _passwordHasher),
            new User("Garry", "garry@gmail.com", "garry", DateTime.Now, false, _passwordHasher),
            new User("Mario", "mario@gmail.com", "mario", DateTime.Now, false, _passwordHasher),
            new User("Andreea", "andreea@gmail.com", "andreea", DateTime.Now, false, _passwordHasher),
            new User("Ioana", "ioana@gmail.com", "ioana", DateTime.Now, false, _passwordHasher),
            new User("Marcel", "marcel@gmail.com", "marcel", DateTime.Now, false, _passwordHasher),
            new User("Sebi", "sebi@gmail.com", "sebi", DateTime.Now, false, _passwordHasher),
            new User("Ana", "ana@gmail.com", "ana", DateTime.Now, false, _passwordHasher),
        };

        private static List<Post> _posts = new List<Post>()
        {
            new Post(_users[0], "Postarea 1"),
            new Post(_users[0], "Postarea 2"),
            new Post(_users[0], "Postarea 3"),
            new Post(_users[1], "Postarea 4"),
            new Post(_users[1], "Postarea 5"),
            new Post(_users[1], "Postarea 6"),
            new Post(_users[1], "Postarea 7"),
            new Post(_users[2], "Postarea 8"),
            new Post(_users[2], "Postarea 9"),
            new Post(_users[2], "Postarea 10"),
            new Post(_users[2], "Postarea 11"),
            new Post(_users[3], "Postarea 12"),
            new Post(_users[3], "Postarea 13"),
            new Post(_users[4], "Postarea 14"),
            new Post(_users[4], "Postarea 15"),
            new Post(_users[4], "Postarea 16"),
            new Post(_users[6], "Postarea 17"),
            new Post(_users[6], "Postarea 18"),
            new Post(_users[6], "Postarea 19"),
            new Post(_users[6], "Postarea 20"),
            new Post(_users[7], "Postarea 21"),
            new Post(_users[7], "Postarea 22"),
            new Post(_users[8], "Postarea 23"),
            new Post(_users[8], "Postarea 24"),
            new Post(_users[8], "Postarea 25"),
        };

        public static List<User> Users
        {
            get { return _users; }
        }

        public static List<Post> Posts 
        { 
            get {  return _posts; } 
        }
    }
}
