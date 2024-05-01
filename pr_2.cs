using System;
namespace ConsoleApp9
{
    /* ===== Task 1
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[3];
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("Enter number: ");
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nResult: ");
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= 1 && nums[i] <= 14)
                {
                    Console.Write(nums[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
    ===== Task 1 */
    /* ===== Task 2
    class Program
      {
          static void Main(string[] args)
          {
              Console.Write("Enter side 1: ");
              double side1 = double.Parse(Console.ReadLine());
              Console.Write("Enter side 2: ");
              double side2 = double.Parse(Console.ReadLine());
              Console.Write("Enter side 3: ");
              double side3 = double.Parse(Console.ReadLine());
              if ((side1 <= 0 || side2 <= 0 || side3 <= 0) || !(side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1))
              {
                  Console.WriteLine("\nIncorrect input or triangle does not exist.");
                  Console.ReadKey();
                  System.Environment.Exit(1);
              }
              double P = side1 + side2 + side3;
              double p = P / 2;
              double S = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
              Console.WriteLine($"Perimeter: {Math.Round(P,2)}, Area: {Math.Round(S,2)}");
              if (side1 == side2 && side2 == side3)
              {
                  Console.WriteLine("Тип: рівносторонній");
              }
              else if (side1 == side2 || side2 == side3 || side1 == side3)
              {
                  Console.WriteLine("Тип: рівнобедрений");
              }
              else
              {
                  Console.WriteLine("Тип: різносторонній");
              }
              Console.ReadKey();
          }
      }
    ===== Task 2 */
    /* ===== Task 3
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[14];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100, 100);
            }
            int min = arr[0], max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Array:");
            foreach(int j in arr)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine($"\nMin: {min}; Max: {max}");
            Console.ReadKey();
        }
    }
    ===== Task 3 */
    /* ===== Task 4
    class Program
    {
        static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] X = new int[14];
            int[] Y = new int[0];
            Random random = new Random();
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = random.Next(-100, 100);
            }
            X[8] = 0;
            Console.Write("Array X: ");
            PrintArray(X);
            Console.Write("Enter M: ");
            int M = int.Parse(Console.ReadLine());
            foreach (int value in X)
            {
                if (Math.Abs(value) > M)
                {
                    Array.Resize(ref Y, Y.Length + 1);
                    Y[Y.Length - 1] = value;
                }
            }
            Console.WriteLine("M = " + M);
            Console.Write("Array Y: ");
            PrintArray(Y);
            Console.ReadKey();
        }
    }
    ===== Task 4 */
}
