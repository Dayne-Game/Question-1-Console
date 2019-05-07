namespace Question1_Console
{
    class Generate
    {
        public string GenerateUsername(string fname, string lname)
        {
            string fnameToUpper = fname.ToUpper();
            string lnameToUpper = lname.ToUpper();
            return $"Username: {fnameToUpper.Substring(0, 1)}{lnameToUpper} \n";
        }
    }
}
