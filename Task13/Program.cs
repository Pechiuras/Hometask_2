//Вывод третьей цифры заданного числа или вывод сообщения, что 3 цифры нет
Console.Clear();
Console.Write ("Введите числож ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
Console.WriteLine("Третьей цифры нет");
else
{
    while (n >= 999)
    {
         n = n / 10;
    }
     Console.WriteLine(n);
     Console.WriteLine(n % 10);
}



