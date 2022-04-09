public class Preferences
{
    public static string preferences;
    public static void GetPreferences()
    {
        Console.WriteLine("Пидорас? ");
        preferences = Console.ReadLine();
    }
}