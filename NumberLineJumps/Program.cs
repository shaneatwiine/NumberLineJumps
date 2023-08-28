namespace NumberLineJumps
{
    internal class Program
    {
        static void Main()
        {

            int[] numbers = UserInterface.GetNumbersFromUser();
            bool isMultiple = NumberProcessor.CanKangaroosMeet(numbers);
            UserInterface.DisplayResult(isMultiple);
        }
    }

}