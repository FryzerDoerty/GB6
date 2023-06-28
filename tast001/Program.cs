//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
void main()
{
    int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    int sum = 0;
    Sum(array, out sum);
    System.Console.WriteLine(sum);
}
void Sum(int[] array, out int sum)
{
    sum = 0;
    int i = 0;
    while (i < array.Length)
    {
        if (array[i] > 0)
        {
            sum += 1;
        }
        i++;
    }
}
main();
