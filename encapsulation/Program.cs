using Encapsulation;



User[] users = new User[3];


for (int i = 0; i < 3; i++)
{
    
    Console.WriteLine("Entern name: ");
    string fullname = Console.ReadLine();
    Console.WriteLine("Entern email: ");
    string email = Console.ReadLine();
    string password;
    while (true)
    {
        Console.Write("Enter password: ");
        password = Console.ReadLine();

        if (User.PasswordChecker(password))
            break;
        else
            Console.WriteLine("Invalid password");
    }
    Console.WriteLine("Entern age: ");
    int age = int.Parse(Console.ReadLine());

    users[i] = new User(fullname, email, password, age);
}




while (true)
{
    Console.WriteLine("\n1. Show all users");
    Console.WriteLine("2. Get info by ID");
    Console.WriteLine("0. Quit");
    Console.Write("Choose: ");

    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 0)
        break;

    else if (choice == 1)
    {
        foreach (User user in users)
            user.GetInfo();
    }
    else if (choice == 2)
    {
        Console.Write("Enter user ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; id<=users.Length; i++)
        {
            if (users[i].Id == id)
            {
                users[i].GetInfo();
                break;
            }
            else
            {
                Console.WriteLine("User not found!");
            }
        }
    }
    else
        Console.WriteLine("Invalid choice!");
}

