//Ввод дня недели и проверка является ли это день выходным
Console.Clear();
Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while ( n < 1 || n > 7)
{
 Console.Write("Вы ошибились!\nВведите день недели: ");
    n = Convert.ToInt32(Console.ReadLine());
}

if (n == 1)
Console.WriteLine("Нет. Это рабочий день недели");

else if (n == 2)
Console.WriteLine("Нет. Это рабочий день недели");

else if (n == 3)
Console.WriteLine("Нет. Это рабочий день недели");

else if (n == 4)
Console.WriteLine("Нет. Это рабочий день недели");

else if (n==5)     
Console.WriteLine("Нет. Это рабочий день недели");

else if (n==6)
Console.WriteLine("Да. Это Выходной");

else if (n==7)
Console.WriteLine("Да. Это Выходной");
