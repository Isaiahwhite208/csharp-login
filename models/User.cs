namespace csharp_login.models
{
 public class User
 {
  public string Username { get; set; }
  private string password { get; set; }

  public bool ValidatePassword(string Password)
  {
   return password == Password;
  }
 }
}