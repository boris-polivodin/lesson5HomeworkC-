/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
class Program {
  public static void Main(string[] args) {
    int size = Prompt("Введите размер массива: ");
    int[] array = new int[size];
    FillArray(array);
    Console.WriteLine($"В массиве [{String.Join(", ", array)}] количество четных чисел: {CountingEvenNumber(array)}");
  }
  
  static int Prompt(string message) {
    Console.Write(message);
    string readInput = Console.ReadLine() ?? "Значение Null";
    int result = int.Parse(readInput);
    return result;
  }
  
  static void FillArray(int[] arr) {
      Random rand = new Random();
      for (int i = 0; i < arr.Length; i++)
      {
         arr[i] = rand.Next(100, 1000); 
      }
  }

  static int CountingEvenNumber(int[] arr) {
    int count = 0;
    for (int i = 0; i < arr.Length; i++){
      count += arr[i] % 2 == 0 ? 1 : 0;
    }
    return count;
  }
}
