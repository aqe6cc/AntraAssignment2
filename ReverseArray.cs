using System;

class Program
{
    static void Main()
    {
        int[] numbers = GenerateNumbers(10);
        Reverse(numbers);
        PrintNumbers(numbers);
    }

    static int[] GenerateNumbers(int length)
    {
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
            arr[i] = i + 1;
        return arr;
    }

    static void Reverse(int[] arr)
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - i - 1];
            arr[arr.Length - i - 1] = temp;
        }
    }

    static void PrintNumbers(int[] arr)
    {
        foreach (int n in arr)
            Console.Write(n + " ");
    }
}