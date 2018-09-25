using System;
using System.Collections.Generic;
using csharp_login.models;

namespace csharp_login
{
 class Program
 {
  static void Main(string[] args)
  {
   Dictionary<string, User> users = new Dictionary<string, User>()
   {
    {"mark", new User("mark", "IHeartCode")},
    {"jake", new User("jake", "MarkRocks")},
   };


   Console.Clear();
   Console.WriteLine("Welcome user, Login to continue");
   Console.Write("Username: ");
   string username = Console.ReadLine();
   Console.Write("Password: ");
   string password = Console.ReadLine();
   if (users.ContainsKey(username) && (users[username].ValidatePassword(password))
    {
    System.Console.WriteLine("Success!");
   }
   else
   {
    System.Console.WriteLine("Invalid Username/Password!");
   }
  }
 }
}
