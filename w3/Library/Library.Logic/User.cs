namespace Library.Logic
{
    public class User
    {
        // Fields
        public int CardNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // Constructors
        public User(){}

        public User(int cardNum, string firstName, string lastName, string email)
        {
            CardNum = cardNum;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        // Methods

    }
}