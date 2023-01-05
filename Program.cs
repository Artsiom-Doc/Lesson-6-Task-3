/*Задача 3*. Найдите сумму произведений пар чисел в одномерном целочисленном массиве.
 Парой считаем первый и последний элемент, второй и предпоследний и т.д.
  Если кол-во элементов нечетное, то элемент посередине не учитывать.
Результат сложения вывести на экран.
1, 3, 8, 3, 2 -> 11
8, 3, 4, 2 -> 28*/

int[]FillArray (int length)
{
    int[]arr = new int [length];
    Random rnd = new Random();
    Console.Write("[");
    for(int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(1, 10);
        Console.Write(arr[i]+" ");
    }
    return arr;
}
Console.WriteLine("Введите количество чисел в массиве: ");
int M = Convert.ToInt32(Console.ReadLine());
int [] myArray = FillArray(M);
5
int result = 0;
int sum = 0;
for(int i = 0, j = M - 1; i < M/2; i++, j--)
{
    result = myArray[i] * myArray[j];
    sum += result;
}
    
Console.Write("]-> " + sum);
