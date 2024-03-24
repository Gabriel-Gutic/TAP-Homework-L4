namespace Lab4Web.Services.Linq
{
    public class LinqService : ILinqService
    {
        public List<User> ExerciseC1(char initial)
        {
            IEnumerable<User> users = Database.Users.Where((User user) => user.Username.StartsWith(initial.ToString().ToUpper()));

            return users.ToList();
        }

        public List<string> ExerciseC2()
        {
            IEnumerable<string> emails = 
                from user in Database.Users
                select user.Email;
            return emails.ToList();
        }

        public int ExerciseC3()
        {
            int count = 
                (from user in Database.Users
                select user).Count();

            return count;
        }
        public string ExerciseD()
        {
            var userPost =
                (from user in Database.Users
                where user.Username.StartsWith('G')
                join post in Database.Posts on user equals post.User
                select new
                {
                    Username = user.Username,
                    IsAdmin = user.IsAdmin,
                    PostTitle = post.Title,
                }).GroupBy(item => item.IsAdmin);

            string result = "";
            foreach (var item in userPost)
            {
                result += $"GROUP: IsAdmin({item.Key}) \n";
                foreach (var set in item)
                {
                    result += $"{set}\n";
                }
            }

            return result;
        }

    }
}
