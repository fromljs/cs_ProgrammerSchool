
namespace ProgrammerSchool
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            lv1_03 q03 = new lv1_03();
            int a03 = q03.solution(12);
            System.Console.WriteLine(a03);

            lv1_09 q09 = new lv1_09();
            int[] a09 = q09.solution(3, 12);
            int[] a09_1 = q09.solution(2, 5);
            //System.Console.WriteLine("{0}  {1}  ", a09[0], a09[1]);

            lv1_13 sol = new lv1_13();

            int[] a = { 1, 5, 2, 6, 3, 4 };
            int[,] a2 = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
            int[] answer = sol.solution(a, a2);
            System.Console.WriteLine(answer);
        }
    }
}