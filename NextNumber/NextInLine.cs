namespace NextNumber
{
    internal class NextInLine
    {
        public static int NextNum(int a)        // Expects and outputs interger
        {
            return a + 1;       // Returns num + 1
        }

        static void Main()
        {
            int resultOne = NextNum(5);     // Result - 6 
            Console.WriteLine(resultOne);
            Console.WriteLine();

            int resultTwo = NextNum(9);     // Result - 10 
            Console.WriteLine(resultTwo);
            Console.WriteLine();

            int resultThree = NextNum(30);     // Result - 31 
            Console.WriteLine(resultThree);
            Console.WriteLine();

        }
    }
}