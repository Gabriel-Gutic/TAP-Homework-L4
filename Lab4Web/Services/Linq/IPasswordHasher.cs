namespace Lab4Web.Services.Linq
{
    public interface IPasswordHasher
    {
        public string Hash(string password);
    }
}
