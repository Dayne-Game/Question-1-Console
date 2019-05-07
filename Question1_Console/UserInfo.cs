using System.Collections.Generic;

namespace Question1_Console
{
    class UserInfo
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public List<UserInfo> User_Database { get; set; }


        public UserInfo(string fname, string lname, string email)
        {
            Firstname = fname;
            Lastname = lname;
            Email = email;
        }

        public void Add_Users_to_User_Database()
        {
            User_Database.Add(new UserInfo(Firstname, Lastname, Email));
            User_Database.Add(new UserInfo("Jeff", "Kranenburg", "jeff.kranenburg@acme.com"));
            User_Database.Add(new UserInfo("Esheel", "Anand", "esh.anand@gmail.com"));
        }

        public string DisplayListedUsers()
        {
            Add_Users_to_User_Database();
            string output = "";
            foreach (UserInfo userDetails in User_Database)
            {
                output += $"Firstname: {userDetails.Firstname} | Lastname: {userDetails.Lastname} | Email: {userDetails.Email} \n";
            }

            return output;
        }
    }
}
