namespace AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {


            // Console.WriteLine("Welcome to Address Book Program");
            // Address_Contact obj = new Address_Contact("Ram", "Sharma", "JubliHills,pune", "Pune", "Maharashtra", "90200", "92xxxxxxxx", "ramsharma@gmail.com");
            // Contact obj1 = new Contact();
            // obj.Add();

            // AddContact obj = new AddContact();
            // obj.Add();

            EditContact obj = new EditContact();
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("\n Enter Contact Details {0}", i);
                obj.CreateUser();
            }
            obj.ShowAllPersonsInList();
            Console.WriteLine("\n Do you want to Edit Information: if yes=1, no=2");
            int A = Convert.ToInt32(Console.ReadLine());
            if (A == 1)
            {
                obj.EditUserInformation();
                Console.WriteLine("\n Contact Edited");
                obj.ShowAllPersonsInList();
            }



        }
    }
}