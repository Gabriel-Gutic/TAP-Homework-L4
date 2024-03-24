namespace Lab4Web.Services.Linq
{
    public class PasswordHasher : IPasswordHasher
    {
        private int _key;

        public PasswordHasher()
        {
            _key = 3;
        }

        // This is not a real hash function for passwords.
        // It is just for an example.
        // I used the simplest hash function, through translation
        public string Hash(string password)
        {
            string result = "";
            foreach (char c in password)
            {
                result += (char)(((int)(c - 'a') + _key) % 26 + 'a');
            }
            return result;
        }
    }
}
