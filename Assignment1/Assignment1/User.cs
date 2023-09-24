namespace Assignment1
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }


        public string Login()
        {
            if (string.IsNullOrWhiteSpace(Username) && string.IsNullOrWhiteSpace(Password))
            {
                return "Provide Username and Password";
            }
            else if (string.IsNullOrWhiteSpace(Username))
            {
                return "Provide Username";
            }
            else if (string.IsNullOrWhiteSpace(Password))
            {
                return "Provide Password";
            }
            else if (Username == "AishuDv" && Password == "Aishu_300")
            {
                return "Login Successful";
            }
            else
            {
                return "Login Failed";
            }
        }
    }
}
   
