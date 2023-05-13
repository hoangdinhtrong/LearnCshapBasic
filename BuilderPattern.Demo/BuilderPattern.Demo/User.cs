namespace BuilderPattern.Demo
{
    public interface IUser
    {
        string? Name { get; }
        int Age { get; }
        string? Address { get; }
    }
    public class User : IUser
    {
        private string? _name;
        public string? Name => _name;

        private int _age;
        public int Age => _age;

        private string? _address;
        public string? Address => _address;

        private User() { }

        public class UserBuilder
        {
            private readonly User _user;
            public UserBuilder()
            {
                _user = new User();
            }

            public UserBuilder WithName(string name)
            {
                _user._name = name;
                return this;
            }

            public UserBuilder WithAge(int age)
            {
                _user._age = age;
                return this;
            }

            public UserBuilder WithAddress(string address)
            {
                _user._address = address;
                return this;
            }

            public User Build()
            {
                return _user;
            }
        }
    }
}
