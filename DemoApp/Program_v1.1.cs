using System.Text;

// щоб українські літери коректно виводились у консолі
Console.OutputEncoding = Encoding.UTF8;

Console.Write("Введіть ваше ім'я: ");
string? userName = Console.ReadLine()?.Trim();

if (string.IsNullOrEmpty(userName))
{
    userName = "незнайомцю";
}

Console.WriteLine($"Вітаю {userName}!");

// v1.1: запитуємо вік, поки не введуть коректне число
int age;
while (true)
{
    Console.Write("Введіть ваш вік: ");
    if (int.TryParse(Console.ReadLine(), out age) && age >= 0 && age <= 150)
    {
        break;
    }
    Console.WriteLine("Вік має бути цілим числом від 0 до 150. Спробуйте ще раз.");
}

string status = age >= 18 ? "повнолітній" : "неповнолітній";
Console.WriteLine($"Користувач: {userName}, вік: {age} ({status})");
