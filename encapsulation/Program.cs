using encapsulation;

int id;

User[] users = new User[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Entern name: ");
    string fullname = Console.ReadLine();
    Console.WriteLine("Entern email: ");
    string email = Console.ReadLine();
    Console.WriteLine("Entern age: ");
    int age = int.Parse(Console.ReadLine());

    users[i] = new User(string fullname, string email, int age);
}






Console.WriteLine("1. Show all users \n 2. Get info by id \n 0. Quit");

int choice = Convert.ToInt32(Console.ReadLine());

