namespace PasswordManagerApi.Models;

public class PasswordModel
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public User User { get; set; }
}

public class User
{
    public Guid UserId { get; set; }

    public string UserName { get; set; }
}

