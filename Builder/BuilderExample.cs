internal class BuilderExample
{
        public void CreateUser()
        {
                var user = new User.UserBuilder()
                    .SetFirstName("John")
                    .SetLastName("Doe")
                    .SetAge(30)
                    .SetAddress("123 Main St")
                    .Build();
        }
}

