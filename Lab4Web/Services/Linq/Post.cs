namespace Lab4Web.Services.Linq
{
    public class Post
    {
        public User User;

        public string Title;

        public Post(User user, string title) 
        { 
            User = user;
            Title = title;
        }
    }
}
