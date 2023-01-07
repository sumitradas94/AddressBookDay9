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

            /* EditContact obj = new EditContact();
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
            */

            bool choice = true;
            DeletePerson ab = new DeletePerson();
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("\n Enter Contact Details {0}", i);
                ab.CreateUser();
            }
            ab.ShowAllPersonsInList();
            static void Userchoice()
            {
                Console.WriteLine("Choose one of the following options: ");
                Console.WriteLine("#1 Create new user");
                Console.WriteLine("#2 Edit user information");
                Console.WriteLine("#3 Delete existing user");
                Console.WriteLine("#4 Show all users in adressBook");
                Console.WriteLine("#5 Exit");
            }
            while (choice)
            {
                Userchoice();
                int Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        ab.CreateUser();
                        Console.WriteLine("\n ***Contact Added***");
                        ab.ShowAllPersonsInList();
                        break;
                    case 2:
                        ab.EditUserInformation();
                        Console.WriteLine("\n ***Contact Edited***");
                        ab.ShowAllPersonsInList();
                        break;
                    case 3:
                        ab.DeleteContact();
                        Console.WriteLine("\n ***Contact Deleted***");
                        ab.ShowAllPersonsInList();
                        break;
                    case 4:
                        ab.ShowAllPersonsInList();
                        break;
                    case 5:
                        choice = false;
                        break;
                }
            }
        }
    }
}
