namespace AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Welcome to Address Book Program");
            Address_Contact obj = new Address_Contact("Ram", "Sharma", "JubliHills,pune", "Pune", "Maharashtra", "90200", "92xxxxxxxx", "ramsharma@gmail.com");
            // Contact obj1 = new Contact();
            obj.Add();



        }
    }
}