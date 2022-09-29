/*
 *
 * K번째수
문제 설명
배열 array의 i번째 숫자부터 j번째 숫자까지 자르고 정렬했을 때, k번째에 있는 수를 구하려 합니다.

예를 들어 array가 [1, 5, 2, 6, 3, 7, 4], i = 2, j = 5, k = 3이라면

array의 2번째부터 5번째까지 자르면 [5, 2, 6, 3]입니다.
1에서 나온 배열을 정렬하면 [2, 3, 5, 6]입니다.
2에서 나온 배열의 3번째 숫자는 5입니다.
배열 array, [i, j, k]를 원소로 가진 2차원 배열 commands가 매개변수로 주어질 때,
commands의 모든 원소에 대해 앞서 설명한 연산을 적용했을 때
나온 결과를 배열에 담아 return 하도록 solution 함수를 작성해주세요.

제한사항
array의 길이는 1 이상 100 이하입니다.
array의 각 원소는 1 이상 100 이하입니다.
commands의 길이는 1 이상 50 이하입니다.
commands의 각 원소는 길이가 3입니다.
입출력 예
array	commands	return
[1, 5, 2, 6, 3, 7, 4]	[[2, 5, 3], [4, 4, 1], [1, 7, 3]]	[5, 6, 3]
입출력 예 설명
[1, 5, 2, 6, 3, 7, 4]를 2번째부터 5번째까지 자른 후 정렬합니다. [2, 3, 5, 6]의 세 번째 숫자는 5입니다.
[1, 5, 2, 6, 3, 7, 4]를 4번째부터 4번째까지 자른 후 정렬합니다. [6]의 첫 번째 숫자는 6입니다.
[1, 5, 2, 6, 3, 7, 4]를 1번째부터 7번째까지 자릅니다. [1, 2, 3, 4, 5, 6, 7]의 세 번째 숫자는 3입니다.
*/

using System;
using System.Collections.Generic;

namespace ProgrammerSchool
{
    internal class lv1_13
    {
        public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];   // 결과값 반환할 배열의 크기
            for (int x = 0; x < commands.GetLength(0); x++)  // 2차원 배열 순회
            {
                int i = commands[x, 0];
                int j = commands[x, 1];
                int k = commands[x, 2];

                int[] list = new int[j - i + 1];
                int cnt = 0;

                // 배열 i~j를 list 에 넣음.
                for (int y = i; y <= j; y++)
                {
                    list[cnt++] = array[y - 1];
                }

                // 정렬
                System.Array.Sort(list);

                // list에서 k번째 수 결과값으로 출력
                answer[x] = list[k - 1];
            }

            return answer;
        }

        public int[] solution2(int[] array, int[,] commands)
        {
            List<int> answer = new List<int>();

            for (int com = 0; com < commands.GetLength(0); com++)
            {
                int i = commands[com, 0];
                int j = commands[com, 1];
                int k = commands[com, 2];

                int cnt = j - i + 1;
                int[] target = new int[cnt];
                Array.Copy(array, i - 1, target, 0, cnt);
                //List<int> dest = new List<int>(target);
                //dest.Sort();
                Array.Sort(target);
                answer.Add(target[k - 1]);
            }

            return answer.ToArray();
        }
    }
}