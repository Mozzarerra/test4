public class About
{
    public static string about;
    public static void GetAbout()
    {
        Console.WriteLine("О себе: ");
        about = Console.ReadLine();
    }
}