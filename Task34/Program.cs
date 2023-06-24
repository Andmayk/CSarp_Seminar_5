// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.  
// [345, 897, 568, 234] -> 2

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

int CountEvenNumbers(int[] arrayToProcessing)
{
    int count = 0;  // счетчик
    for (int i = 0; i < arrayToProcessing.Length; i++)  //пербор элементов массива
    {
        if (arrayToProcessing[i] % 2 == 0) // проверим четность i-того элемента 
        {
            count++; // увеличим счетчик
        }
    }
    return count;
}

///=============================

int[] array = FillArray(5, 100, 1000);
System.Console.Write("В массиве ");
PrintArray(array);
System.Console.WriteLine("четных чисел: "+CountEvenNumbers(array));
