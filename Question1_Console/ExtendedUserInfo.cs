using System.Collections.Generic;

namespace Question1_Console
{
    class ExtendedUserInfo
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string MyRole { get; set; }


        List<ExtendedUserInfo> Extended_Users_Database = new List<ExtendedUserInfo>();

        public ExtendedUserInfo(string fname, string lname, string email, string myRole)
        {
            Firstname = fname;
            Lastname = lname;
            Email = email;
            MyRole = myRole;

        }

        public void AddUserInfoToListedUsers()
        {
            Extended_Users_Database.Add(new ExtendedUserInfo(Firstname, Lastname, Email, MyRole));
            Extended_Users_Database.Add(new ExtendedUserInfo("Jeff", "Kranenburg", "jeff.kranenburg@acme.com", "CEO"));
            Extended_Users_Database.Add(new ExtendedUserInfo("Esheel", "Anand", "esh.anand@gmail.com", "Manager"));
        }

        public string DisplayListedUsers()
        {
            AddUserInfoToListedUsers();
            string output = "";
            foreach (ExtendedUserInfo userDetails in Extended_Users_Database)
            {
                output += $"Firstname: {userDetails.Firstname} | Lastname: {userDetails.Lastname} | Email: {userDetails.Email} | MyRole: {userDetails.MyRole} \n";
            }

            return output;
        }
    }
}
