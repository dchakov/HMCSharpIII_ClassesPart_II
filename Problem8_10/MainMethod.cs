using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixClass
{
    class MainMethod
    {
        static void Main()
        {

            Matrix<int> test1 = new Matrix<int>(4, 5);
            for (int i = 0; i < test1.Row; i++)
            {
                for (int j = 0; j < test1.Col; j++)
                {
                    test1[i, j] = i + j;
                }
            }
            Console.WriteLine(test1);
            Matrix<double> test2 = new Matrix<double>(2, 3);
            double m = 0.5;
            for (int i = 0; i < test2.Row; i++)
            {
                for (int j = 0; j < test2.Col; j++)
                {
                    test2[i, j] = m;
                    m++;
                }
            }
            Console.WriteLine(test2);
            Matrix<int> test3 = test1 + test1;
            Console.WriteLine(test3);
            
            Matrix<int> test4 = test1 - test3;
            Console.WriteLine(test4);
            Matrix<int> matrix1 = new Matrix<int>(3, 2);
            int temp = 1;
            for (int i = 0; i < 3; i++)
            {
                temp = i + 1;
                for (int j = 0; j < 2; j++)
                {
                    matrix1[i, j] = temp;
                    temp += 3;
                }
            }
            Console.WriteLine(matrix1);
            Matrix<int> matrix2 = new Matrix<int>(2, 3);
            int t = 7;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix2[i, j] = t;
                    t++;
                }
            }
            Console.WriteLine(matrix2);
            
            Matrix<int> matrix3 = matrix1 * matrix2;
            Console.WriteLine(matrix3);

            if (matrix3)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            if (test1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
