namespace ProgrammerSchool
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("### Sol13 ###");
            lv1_13 q13 = new lv1_13();

            int[] q13_1 = { 1, 5, 2, 6, 3, 7, 4 };
            int[,] q13_2 = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
            int[] answer = q13.solution(q13_1, q13_2);

            foreach (var item in answer)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("### Sol 14 ###");
            lv1_14 q14 = new lv1_14();
            int a14 = q14.solution(10);
            System.Console.WriteLine(a14);
            a14 = q14.solution(5);
            System.Console.WriteLine(a14);
        }
    }
}