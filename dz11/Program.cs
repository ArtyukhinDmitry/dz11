// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] GetArray(int size,int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// int[] resultArray = GetArray(4, 100, 999);
// Console.WriteLine(String.Join("; ", resultArray));

// int chetNumber = 0; 
// for (int i = 0; i < resultArray.Length; i++)
// {
//     if (resultArray[i] % 2 == 0) chetNumber++;
// }
// Console.WriteLine($"Количество чётных чисел в массиве: {chetNumber}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// int[] resultArray = GetArray(4, 1, 9);
// Console.WriteLine(String.Join("; ", resultArray));

// int nechetNumber = 0; 
// for (int i = 0; i < resultArray.Length; i++)
// {
//     if (i % 2 != 1)
//     {
//         nechetNumber += resultArray[i];
//     }
// }
// Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в массиве: {nechetNumber}");



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] GetArray(int size, double minValue, double maxValue)
// {
//     double[] array = new double[size];
//     Random rand = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rand.Next(-100, 100) + rand.NextDouble();
//     }
//     return array;
// }
// double[] resultArray = GetArray(4, 100, 999);
// Console.WriteLine(String.Join("; ", resultArray));

// double sumNumber = 0; 
// double maxNumber = 0; 
// double minNumber = 0; 
// for (int i = 0; i < resultArray.Length; i++)
// {
//     if (resultArray[i] > maxNumber)
//     {
//         maxNumber = resultArray[i];
//     }
//     else if (resultArray[i] < minNumber)
//     minNumber = resultArray[i];
// }
// sumNumber = maxNumber - minNumber * (-1);
// Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {sumNumber}");