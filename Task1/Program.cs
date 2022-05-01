// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Для анализа введите числа через пробел");
string line = Console.ReadLine();
string[] massLine = line.Split(' ');

int[] array = new int[massLine.Length];
for (int i = 0; i < massLine.Length; i++)
{
    array[i] = Convert.ToInt32(massLine[i]);
}

int Count(int[] mass)
{
    int a = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > 0) 
        a++;
    }
    return a;
}

Console.WriteLine(Count(array) + " Чисел больше 0");
