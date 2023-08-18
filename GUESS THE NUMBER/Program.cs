using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        int number, lower, highter, answer, count;
        Random rand = new Random();
        count = 5;
        number = rand.Next(0,101);
        highter = rand.Next(number+1,number+11);
        lower = rand.Next(number-11,number-1);
        System.Console.WriteLine($"Загадано число от 0 до 100, оно больше {lower}, но меньше, чем {highter}");
        while (count>0)
        {
            System.Console.Write($"Осталось попыток: {count} Введите число: ");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == number)
            {
                System.Console.WriteLine("Ура, победа!");
                break;
            }
            count--;
            System.Console.WriteLine("Вы ошиблись!");
            if (count == 0)
            {
                System.Console.WriteLine($"Вы проиграли! Лох, аххаахззвазхва число то было {number}");
            }
        }
    }
}