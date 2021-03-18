using System;
using System.Collections.Generic;

namespace AlgoritmsLesson7Praktic
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetVal = 16;
            int startVal = 1;

            int result = Task(startVal, targetVal);
            Console.WriteLine($"Результат рекурсивного метода {result}");

            result = Task2(startVal, targetVal);
            Console.WriteLine($"Результат рекурсивного метода {result}");
        }
        static int Task(int startVal, int targetVal)
        {
            if (startVal > targetVal) return 0;

            if (startVal == targetVal) return 1;

            return Task(startVal * 2, targetVal) + Task(startVal + 1, targetVal);

        }
        static int Task2(int startVal, int targetVal)
        {
            Node startNode = new Node { leftNode = null, rightNode = null, Value = 16 };

            int rTargetVal = targetVal;

            while (rTargetVal > startVal)
            {
                rTargetVal /= 2;


            }
            return 0;
        }

        public class Node
        {
            public Node leftNode;
            public Node rightNode;
            public int Value;
        }
    }
}

/*P(1) = 1
 * P(N) = P(N-1)+P(N/2), при N > 1, если N кратно 2;
 * P(N) = P(N-1), при N > 1, если N не кратно 2 
 * 
 * Прибавь 1
 * Умножь на 2
 * 
 * */