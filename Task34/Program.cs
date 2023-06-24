// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.  evenNumber
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

///=============================

int[] array = FillArray(5, 100, 1000);
PrintArray(array);
