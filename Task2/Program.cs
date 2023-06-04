/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
class Program {
  public static void Main(string[] args) {
    int size = Prompt("Введите размер массива: ");
    int minValue = Prompt("Введите нижнюю границу массива: ");
    int maxValue = Prompt("Введите верхнюю границу массива: ");
    int[] array = GetArray(size, minValue, maxValue);
    Console.WriteLine($"Сумма нечетных элементов массива [{String.Join(", ", array)}] равна {ElementsSum(array)}");
  }

  static int Prompt(string message) {
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
  }

  static int[] GetArray(int dim, int down, int up) {
    int[] arr = new int[dim];
    FillArray(arr, down, up);
    return arr;
  }

  static void FillArray(int[] arr, int down, int up) {
      Random rand = new Random();
      for (int i = 0; i < arr.Length; i++)
      {
         arr[i] = rand.Next(down, up); 
      }
  }

  static int ElementsSum(int[] arr) {
    int oddElemensSum = 0;
    for (int i = 0; i < arr.Length; i++) {
      oddElemensSum += i % 2 == 0 ? 0 : arr[i];
    }
    return oddElemensSum;
  }
}
