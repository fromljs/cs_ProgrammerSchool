
namespace ProgrammerSchool
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            lv1_13 sol = new lv1_13();

            int[] a = { 1, 5, 2, 6, 3, 4 };
            int[,] a2 = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
            int[] answer = sol.solution(a, a2);
            System.Console.WriteLine(answer);
        }
    }
}