namespace NumberLineJumps
{
    public class NumberProcessor
    {
        public static bool CanKangaroosMeet(int[] numbers)
        {
            int startingPosition1 = numbers[0];
            int jumpRate1 = numbers[1];
            int startingPosition2 = numbers[2];
            int jumpRate2 = numbers[3];

            if (jumpRate1 == jumpRate2)
            {
                if (startingPosition1 == startingPosition2)
                    return true;
                else
                    return false;
            }

            int relativeStartPosition = startingPosition2 - startingPosition1;
            int relativeJumpRate = jumpRate1 - jumpRate2;

            if (relativeStartPosition % relativeJumpRate == 0 && relativeStartPosition / relativeJumpRate >= 0)
                return true;
            else
                return false;
        }
    }


}
