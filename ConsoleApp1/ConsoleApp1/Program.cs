using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string username="";
            string password;
            Users user = new Users(username);
            do
            {
                Console.Write("Istifadeci adini daxil edin: ");
                username = Console.ReadLine();
                user.UserName = username;
                if(user.UserName == null)
                    Console.WriteLine("Istifadeci adi uzunluqu 6 den kicik 25 boyuk ola bilmez ");
            } while (user.UserName == null);
            do
            {
                Console.Write("Sifreni Daxil edin: ");
                password = Console.ReadLine();
                user.Password = password;
                if (user.Password == null)
                    Console.WriteLine("Sifrenin uzunluqu 8 den kicik 25 boyuk ola bilmez ve daxilinde en az 1 boyuk, 1 kicik herf ve 1 reqem olmalidir");
            } while (user.Password == null);
        }
    }
}
