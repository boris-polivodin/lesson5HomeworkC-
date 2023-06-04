/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
class Program {
  public static void Main(string[] args) {
    int size = Prompt("Введите размер массива: ");
    int minValue = Prompt("Введите нижнюю границу массива: ");
    int maxValue = Prompt("Введите верхнюю границу массива: ");
    double[] array = GetArray(size, minValue, maxValue);
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива [{String.Join(", ", array)}] равна {DifferenceMinMax(array)}");
  }
  
  static int Prompt(string message) {
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
  }

  static double[] GetArray(int dim, int down, int up) {
    double[] arr = new double[dim];
    FillArray(arr, down, up);
    return arr;
  }
    
  static void FillArray(double[] arr, int down, int up) {
      Random rand = new Random();
      for (int i = 0; i < arr.Length; i++)
      {
         arr[i] = Math.Round(rand.NextDouble() * (up - down) + down, 2);
      }
  }

  static double DifferenceMinMax(double[] arr) {
    double minValue = arr[0];
    double maxValue = arr[0];
    for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i] < minValue) minValue = arr[i];
        if (arr[i] > maxValue) maxValue = arr[i];
      }
    return Math.Round(maxValue - minValue, 2);
  }
}
