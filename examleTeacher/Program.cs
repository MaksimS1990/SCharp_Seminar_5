// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отридцательных и положительных элементов массива.
// [3, 9,-8, 1, 0,-7, 2,-1, 8,-3,-1, 6] сумма положительных 29, отридцательных -20.

Console.WriteLine("Программа находит сумму положительных и отридцательных элементов массива");

int[] CreateArrayWithRandomNumbers(int numbers = 12, int startInterval = -9, int endInterval = 9) {      //функция создания рандомного массива
    var result = new int[numbers];

    Random random = new Random();

    for (int i = 0; i < numbers; i++) {
        result[i] = random.Next(startInterval, endInterval + 1);
    }

    return result;
}

void PrintArray(int[] input) {

    for (int i = 0; i < input.Length; i++) { 
        Console.Write(input[i]);

        if (i != input.Length - 1)
        Console.Write(", ");
    }

    Console.WriteLine();
}


int SumPositivNumbers(int[] input) {             // функция подсчета всех положительных чисел в промежутке
    int result = 0;
for (int i = 0; i < input.Length; i++) {
        if (input[i] > 0)
        result += input[i];
}
return result;
}

int SumNegativNumbers(int[] input) {             // функция подсчета всех отридцательных чисел в промежутке
    int result = 0;
for (int i = 0; i < input.Length; i++) {
        if (input[i] < 0)
        result += input[i];
}
return result;
}

var array = CreateArrayWithRandomNumbers();
PrintArray(array);

var positivSum = SumPositivNumbers(array);
Console.WriteLine("Сумма положительных числел: " + positivSum);

var negativeSum = SumNegativNumbers(array);
Console.WriteLine("Сумма отридцательных числел: " + negativeSum);
