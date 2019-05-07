using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages messages = new StandardMessages();
            Generate username = new Generate();
            Validate check = new Validate();
            Console.WriteLine(messages.Title);

            string fname = "";
            string lname = "";
            string email = "";
            string userrole = "";
            string password = "";
            string password2 = "";

            do
            {
                Console.Write(messages.AskForFirstname);
                fname = Console.ReadLine();
                Console.WriteLine(check.check_and_give_feedback(fname));

                Console.Write(messages.AskForLastname);
                lname = Console.ReadLine();
                Console.WriteLine(check.check_and_give_feedback(lname));

                Console.Write(messages.AskForEmail);
                email = Console.ReadLine();
                Console.WriteLine(check.check_and_give_feedback(email));

                Console.Write(messages.AskForUserrole);
                userrole = Console.ReadLine();
                Console.WriteLine(check.check_and_give_feedback(userrole));

                Console.Write(messages.AskForFirstPassword);
                password = Console.ReadLine();
                Console.WriteLine(check.check_and_give_feedback(password));

                Console.Write(messages.AskForSecondPassword);
                password2 = Console.ReadLine();
                Console.WriteLine(check.check_and_give_feedback(password2));

                Console.WriteLine(check.CheckPasswords(password, password2));

            } while (!check.Check_All_fields_And_Passwords(fname, lname, email, userrole));
            
            ExtendedUserInfo user = new ExtendedUserInfo(fname, lname, email, "CEO");
            Console.WriteLine(username.GenerateUsername(fname, lname));
            Console.WriteLine(user.DisplayListedUsers());

            Console.ReadLine();
        }
    }
}
