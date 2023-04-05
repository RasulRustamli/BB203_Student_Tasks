using C__Class;
using C__Class.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Universitet idsi daxil edin");
        int uniId=int.Parse(Console.ReadLine());
        Console.WriteLine("Universitet adi daxil edin");
        string uniName=Console.ReadLine();
        University university = new University(uniId,uniName);

        string input="";
        int id=0;
        bool result;
        string name="";
        string surname="";
        Student student = new Student(id, name, surname);
        Console.WriteLine("  1. Creat Student");
        Console.WriteLine("  2. Get Student");
        Console.WriteLine("  3. Exit");
        Console.WriteLine("----------------------------------");
        while (input != "3")
        {
            Console.Write("command: ");
            Console.WriteLine();
            input = Console.ReadLine();
            if (input == "1")
            {
                Console.Write("Id: ");
                Int32.TryParse(Console.ReadLine(), out id);
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Surname: ");
                surname = Console.ReadLine();
                student = new Student(id, name, surname);
                university.AddStudent(student);

            }
            else if (input == "2")
            {
                foreach (var item in university.Students)
                {
                    Console.WriteLine(item.Name);
                }
            }
            Console.WriteLine();
            Console.WriteLine("--------");
        }
    }
}