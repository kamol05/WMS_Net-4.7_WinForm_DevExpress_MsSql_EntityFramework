namespace SKLAD.MODEL.Sys
{
    public class User : Identity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public override string ToString()
        {
            return "ID-" + Id + " " +
                    "Login-" + Login + " " +
                    "Password-" + Password + " " +
                    "Role-" + Role;
        }
    }
}
