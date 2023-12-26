double[,] mas = new double[5, 5]; //// Т.к. ни одно значение не вводится с клавиатуры, то не буду страховаться 
Random rand = new Random();
Console.WriteLine("Исходная матрица: ");
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = (rand.Next(0, 256)) + (rand.NextDouble()); // Генерируем случайное число с плавающей точкой
        Console.Write($"|  {(mas[i, j]):F2}  |");
    }
    Console.WriteLine();

}
Console.WriteLine($"Среднее арифметическое число побочной диагонали равно {(ClassLibrary1.Library.Avg(mas)):F2}");
