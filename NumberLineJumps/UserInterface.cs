

namespace NumberLineJumps
{
    public class UserInterface
    {
        public static int[] GetNumbersFromUser()
        {
            int[] numbers = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            return numbers;
        }

        public static void DisplayResult(bool isMultiple)
        {
            if (isMultiple)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }

}
