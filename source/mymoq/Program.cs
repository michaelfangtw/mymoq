// See https://aka.ms/new-console-template for more information
using mymoq.BLL;

Console.WriteLine("Hello, World!");

var users=new UserBLL().GetList();
foreach(var user in users)
{
    Console.WriteLine($"userID:{user.UserID},{user.UserName},{user.Email}");
}

