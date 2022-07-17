using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq
{
    public class User
    {
        static int id = 1;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NotRobotCode { get; set; }




        public enum RegistrationMonth { Yanvar, Fevral, Mart , Aprel, May, Iyun, Iyul, Avqust, Sentyabr, Oktyabr, Noyabr, Dekabr }
        public RegistrationMonth Month { get; set; }

        public User(string name, string surname, RegistrationMonth month, string notrobotcode)
        {
            NotRobotCode = notrobotcode;
            Name = name;
            Surname = surname;
            Id = id++;
        }

        public (int, string, string, RegistrationMonth) GetDetails()
        {

            if (Extension.CheckNotRobotCode(NotRobotCode))
            {
                return (Id, Name, Surname, Month);
            }
            else
            {
                Console.WriteLine("duzgun deyil");
                return (Id, Name, Surname, Month);
            }
        }

        






    }
}
