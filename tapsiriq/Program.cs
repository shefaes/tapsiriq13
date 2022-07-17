using System;

namespace tapsiriq
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Ali", "Qaibov",User.RegistrationMonth.Iyun, "AQSS");
            User user1 = new User("Aysel", "Qaibova",User.RegistrationMonth.Avqust,"AQ22");
            User user2= new User("Aydin", "Eliyev", User.RegistrationMonth.May,"AE23");
            User user3 = new User("Sefa", "Sadiqova",User.RegistrationMonth.Yanvar, "SS35");
            User user4 = new User("Tural", "Mamedov",User.RegistrationMonth.Aprel, "TM42");

            Console.Write(user.GetDetails());
            Console.WriteLine(user1.GetDetails());
            Console.WriteLine(user2.GetDetails());
            Console.WriteLine(user3.GetDetails());
            Console.WriteLine(user4.GetDetails());


        }

        
    }
   
   

}
