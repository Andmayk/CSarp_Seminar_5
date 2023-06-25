// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] FillArray(int size, int rangLeft, int rangRight)
{
    double[] tempArray = new double[size];  //выделение памяти для массива

    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = Math.Round(rand.Next(rangLeft, rangRight)+ rand.NextDouble(),2);
    }
    return tempArray;
}

void PrintArray(double[] arrayToOutput)
{
    System.Console.WriteLine("[" + string.Join("; ", arrayToOutput) + "]");
}

void FindMinMax(double[] arrayToProcessing, out double minVolue, out double maxVolue)
{
    minVolue = arrayToProcessing[0]; 
    maxVolue = arrayToProcessing[0];

    for (int i = 1; i < arrayToProcessing.Length; i++)  //пербор элементов массива
    {
        if (minVolue > arrayToProcessing[i]) // проверим если элемент < найденного минимума
        {
            minVolue = arrayToProcessing[i]; // запишим новый минимум
        }
        if (maxVolue < arrayToProcessing[i]) // проверим если элемент > найденного максимума
        {
            maxVolue = arrayToProcessing[i]; // запишим новый максимум
        }
    }
}

///=============================

double [] array = FillArray(5, 0, 100);
System.Console.Write("В массиве ");
PrintArray(array);

double minVol, maxVol, difference; //переменные для минимального максимального значения и разности

FindMinMax(array, out minVol, out maxVol);  // найдем минимум и максимум  используюя модификатор out

difference = Math.Round(maxVol-minVol,2);  // округляем чтобы избавится от погрешности типа 97,93 - 54,51 = 43,42000000000001

System.Console.WriteLine($"Разность между максимальным и минимальным \nэлементами массива  {maxVol} - {minVol} = {difference}");
