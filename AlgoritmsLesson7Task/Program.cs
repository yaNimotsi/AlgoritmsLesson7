using System;

namespace AlgoritmsLesson7Task
{
    public class Program
    {
        static void Main(string[] args)
        {
            var countWay = GetCountWay(10,10);
        }
        public static int GetCountWay(int N, int M)
        {
            int[,] A = new int[N, M];
            int i, j;
            for (j = 0; j < M; j++)
                A[0, j] = 1;

            for (i = 1; i < N; i++)
            {
                A[i, 0] = 1;
                for (j = 1; j < M; j++)
                {
                    A[i, j] = A[i, j - 1] + A[i - 1, j];
                }
            }
            return A[N - 1, M - 1];
        }
    }
}
