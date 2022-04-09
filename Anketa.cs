public static class Anketa
{
	public static void LaunchApp()
    {
        Console.WriteLine("Укажите ваши данные\n");
        Name.GetName();
        Age.GetAge();
        Sex.GetSex();
        Hobbies.GetHobbies();
        About.GetAbout();
        Preferences.GetPreferences();
        Console.WriteLine($"Ваше Имя: {Name.name}\nВаш Пол: {Sex.sex}\nВаши Хобби: {Hobbies.hobbies}\nО вас: {About.about}\nПидорас? {Preferences.preferences}");
    }
}
