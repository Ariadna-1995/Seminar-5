//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = Math.Round(new Random().NextDouble()*(maxValue - minValue) + minValue,2);
    }
    return res;
}
double GetDiff(double[] array)
{
    double min = array[0];
    double max = array[0];
    double diff = 0;    
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
        diff = max - min;
    }
    return diff;
}
double[] array = GetArray(4, 10, 20);
Console.WriteLine(String.Join(",", array));
double diff2 = GetDiff(array);
Console.WriteLine($"{diff2}");