namespace Dojo
{
    public static class Solution
    {
        public static bool IsSetup => true;

        public static bool CanAddUp(int[] values, int searchedValue)
        {
            var lengthOfTheValues = values.Length;
            for (var i = 0; i < lengthOfTheValues - 1; i++)
            {
                for (var j = i + 1; j < lengthOfTheValues; j++)
                {
                    if (values[i] + values[j] == searchedValue)
                        return true;
                }
            }
            return false;
        }
    }
}
