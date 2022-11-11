// See https://aka.ms/new-console-template for more information

Console.WriteLine(""); 
 
Console.WriteLine("Введите длинну массива"); 
int length = int.Parse(Console.ReadLine()!); 
 
int[] array = new int[length]; 
Random random = new Random(); 
 
void RandomArray(int[] array) // Функция заполнения массива в случайном порядке 
{ 
 for (int i = 0; i < length; i++) 
 { 
 array[i] = random.Next(0, 123); 
 } 
} 
 
void PrintArray(int[] array) // Функция вывода массива в консоль 
{ 
 for (int i = 0; i < length; i++) 
 { 
 
 Console.Write(array[i] + " "); 
 } 
} 
 
RandomArray(array); 
Console.Write("Массив в строку "); 
Console.WriteLine(); 
PrintArray(array); 
Console.WriteLine(); 

int count = 0;
for (int i = 0; i < length; i++)
{
    if (array[i] > 10 && array[i]< 100)
    count++;
} 
Console.WriteLine("Количество 2х значных чисел: " + count);