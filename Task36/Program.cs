// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size, int rangLeft, int rangRight)
{
    int[] tempArray = new int[size];  //выделение памяти для массива

    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(rangLeft, rangRight + 1);
    }
    return tempArray;
}

void PrintArray(int[] arrayToOutput)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayToOutput) + "]");
}

int SumOddIndexNumbers(int[] arrayToProcessing)
{
    int sum = 0;  // сумма
    for (int i = 1; i < arrayToProcessing.Length; i= i+2)  //пербор элементов массива
    {
           sum += arrayToProcessing[i]; // увеличим счетчик
    }
    return sum;
}

///==========================

int[] array = FillArray(4, -10, 100);

PrintArray(array);

System.Console.WriteLine("Сумма чисел массива с нечетными индексами: "+SumOddIndexNumbers(array));
