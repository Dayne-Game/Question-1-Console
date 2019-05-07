namespace Question1_Console
{
    class Validate
    {
        public bool PasswordsOK { get; set; }
        public bool CheckRequiredField(string input)
        {
            if(!string.IsNullOrWhiteSpace(input))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public string check_and_give_feedback(string input)
        {
            if(CheckRequiredField(input) == false) {
                return "You didn't enter anything";
            } else
            {
                return "OK";
            }
        }

        public string CheckPasswords(string password, string password2)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(password2))
            {
                PasswordsOK = false;
                return "Please enter ot Re-type your Password";
            }
            else
            {
                if (password == password2)
                {
                    PasswordsOK = true;
                    return "Passwords Match \n";
                }
                else
                {
                    PasswordsOK = false;
                    return "Passwords don't Match \n";
                }
            }
        }

        public bool Check_All_fields_And_Passwords(string fname, string lname, string email, string userrole)
        {
            if(CheckRequiredField(fname) && CheckRequiredField(lname) && CheckRequiredField(email) && CheckRequiredField(userrole) && PasswordsOK == true)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
