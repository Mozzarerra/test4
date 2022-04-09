public static class Anketa
{
	public static void LaunchApp()
    {
        string name, age, sex, about, preferences, hobbies;

        Console.WriteLine("Укажите ваши данные\n");

        Console.WriteLine("Имя: ");
        name = Console.ReadLine();

        Console.WriteLine("Возраст: ");
        age = Console.ReadLine();

        Console.WriteLine("Пол: ");
        sex = Console.ReadLine();

        Console.WriteLine("Хобби: ");
        hobbies = Console.ReadLine();

        Console.WriteLine("О себе: ");
        about = Console.ReadLine();

        Console.WriteLine("Пидорас? ");
        preferences = Console.ReadLine();

        Console.WriteLine($"Ваше Имя: {name}\nВаш Пол: {sex}\nВаши Хобби: {hobbies}\nО вас: {about}\nПидорас? {preferences}");

    }
}
