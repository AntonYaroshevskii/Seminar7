// //Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// double[,] array = GetArray(rows, columns, -10, 10);
// PrintArray(array);


// // -------------Метод----------------------------
// double[,] GetArray(int m, int n, int minValue, int maxValue){
//     double[,] result = new double[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//            result[i,j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]:F1}  ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 50. Напишите программу, которая на вход принимает число, 
// проверяя есть ли такое число в двумерном массиве и возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// if(findNum(array, num)){
//     Console.WriteLine($"Данное число {num} есть в массиве ");
// }
// else{
//     Console.WriteLine($"Данное число {num} нету в массиве ");
// }

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// double[] result = ArithmeticMean(array);
// PrintArrayResult(result);


// // -------------Метод----------------------------
// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// bool findNum(int[,] array, int a){ 
//     foreach (int el in array){ 
//     if(el == a){ 
//         return true; 
//     } 
// } 
// return false;
// }

// double[] ArithmeticMean(int[,] array){
//     double[] result = new double[array.GetLength(1)];
//     double sum;   
//     for(int i = 0; i < array.GetLength(1); i++){
//         sum = 0;
//         for(int j = 0; j < array.GetLength(0); j++){
//             sum += array[j,i];
//         }
//         result[i] = sum / array.GetLength(0);
//     }
//     return result;
// }
// void PrintArrayResult(double[] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//             Console.Write($"{array[i]:F1} ");
//         }
//         Console.WriteLine();
// }
