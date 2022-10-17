// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// int[] GenerateArray(int length) {
//     var array = new int[length];
//     var random = new Random();
//     for (int i = 0; i < array.Length; i++){
//         array[i] = random.Next(100,1000);
//     }
//     return array;
// }

// void PrintArray(int[] array) {
//     for (int i = 0; i < array.Length; i++) {
//         Console.Write($"{array[i]} ");
//     }
// }

// int evenNumber(int[] arr) {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++) {
//         if ( arr[i] % 2 == 0 ){
//             sum = sum + 1;
//         }
//     }
//     return sum;
// }
// var array = GenerateArray(10);
// PrintArray(array);
// System.Console.WriteLine(" ");
// Console.WriteLine($"Количество четных чисел в массиве равно {evenNumber(array)}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// int[] GenerateArray(int length) {
//     var array = new int[length];
//     var random = new Random();
//     for (int i = 0; i < array.Length; i++){
//         array[i] = random.Next(0,10);
//     }
//     return array;
// }

// void PrintArray(int[] array) {
//     for (int i = 0; i < array.Length; i++) {
//         Console.Write($"{array[i]} ");
//     }
// }

// int sumUnevenPosition(int[] arr){
//     int sum = 0;
//     for (int i = 1; i < arr.Length; i++) {
//         if (i % 2 == 1){
//             sum = sum + arr[i];
//         }
//     }
//     return sum;
// }
// var array = GenerateArray(10);
// PrintArray(array);
// System.Console.WriteLine(" ");
// Console.WriteLine($"Сумма элементов стоящих на нечетных позициях равна {sumUnevenPosition(array)}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// float[] GenerateArray(float length) {
//     var array = new float[10];
//     var random = new Random();
//     for (int i = 0; i < array.Length; i++){
//         array[i] = random.NextSingle();
//     }
//     return array;
// }

// void PrintArray(float[] array) {
//     for (int i = 0; i < array.Length; i++) {
//         Console.Write($"{array[i]} ");
//     }
// }

// float max(float[] array){
//     float max = array[0];
//     for (int i = 0; i < array.Length; i++){
//         if( array[i] > max){
//             max = array[i];
//         }
//     }
//     return max;
// }
// float min(float[] array){
//     float min = array[0];
//     for (int i = 0; i < array.Length; i++){
//         if( array[i] < min){
//             min = array[i];
//         }
//     }
//     return min;
// }

// var array = GenerateArray(10);
// PrintArray(array);
// Console.WriteLine($" ");
// float sub = max(array) - min(array);
// Console.WriteLine($"Разница между максимальным {max(array)} и минимальным {min(array)} числами равна {sub}");
