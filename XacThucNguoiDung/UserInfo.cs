using System;

public class UserInfo
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }

    public UserInfo(string username, string email, string role)
    {
        Username = username;
        Email = email;
        Role = role;
    }
}
