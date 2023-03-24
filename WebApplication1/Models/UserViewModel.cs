namespace WebApplication1.Models;

public class UserViewModel
{
    public string Name { get; set; } = string.Empty;

    public string GetWelcome()
    {
        return !string.IsNullOrWhiteSpace(this.Name)
            ? $"Hello, {this.Name}!"
            : "I don't know you!";
    }
}