using System.Text.RegularExpressions;

namespace ContactList
{
    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }

    class Program : Methods
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();
            while (methods.input != 4)
            {


                methods.ShowMenu();
            }
        }
    }
}