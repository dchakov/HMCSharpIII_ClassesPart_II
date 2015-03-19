using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixClass
{
   public class Matrix<T>
    {
        // https://msdn.microsoft.com/en-us/library/aa288467(v=vs.71).aspx
        // https://msdn.microsoft.com/en-us/library/2549tw02.aspx
        //https://msdn.microsoft.com/en-us/library/dd264736.aspx

       private T[,] matrix; 
       private int row;
       private int col;

       public int Row
       {
           get { return this.row; }
           set
           {
               if (value <= 0)
               {
                   throw new ArgumentOutOfRangeException("Invalid value");
               }
               this.row = value; 
           }
       }
       public int Col
       {
           get { return this.col; }
           set
           {
               if (value <= 0)
               {
                   throw new ArgumentOutOfRangeException("Invalid value");
               }
               this.col = value; 
           }
       }
       
       public Matrix(int row, int col)
       {
           this.Row = row;
           this.Col = col;
           this.matrix = new T[row, col];
       }
       public T this[int row,int col]
       {
           get
           {
               if (row < 0 || col < 0)
               {
                   throw new IndexOutOfRangeException();
               }
               return this.matrix[row, col]; 
           }
           set
           {
               if (row < 0 || col < 0)
               {
                   throw new IndexOutOfRangeException();
               }
               this.matrix[row, col] = value; 
           }
       }
       public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
       {
           if (first.Row != second.Row || first.Col != second.Col)
           {
               throw new IndexOutOfRangeException();
           }
           Matrix<T> result = new Matrix<T>(first.Row,first.Col);
           for (int i = 0; i < first.Row; i++)
           {
               for (int j = 0; j < first.Col; j++)
               {
                   result[i, j] = (dynamic)first[i, j] + second[i, j];
               }
           }
           return result;
       }

       public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
       {
           if (first.Row != second.Row || first.Col != second.Col)
           {
               throw new IndexOutOfRangeException();
           }
           Matrix<T> result = new Matrix<T>(first.Row, first.Col);
           for (int i = 0; i < first.Row; i++)
           {
               for (int j = 0; j < first.Col; j++)
               {
                   result[i, j] = (dynamic)first[i, j] - second[i, j];
               }
           }
           return result;
       }

       public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
       {
           if (first.Col != second.Row)
           {
               throw new Exception("Cannot multiply matrices");
           }
           Matrix<T> result = new Matrix<T>(first.Row, second.Col);

           for (int i = 0; i < first.Row; i++)
           {
               for (int j = 0; j < second.Col; j++)
               {
                   for (int k = 0; k < first.Col; k++)
                   {
                       result[i, j] += (dynamic)first[i, k] * (dynamic)second[k, j];
                   }
               }
           }
           return result;
       }
       public static bool operator true(Matrix<T> matrix)
       {
           for (int row = 0; row < matrix.Row; row++)
           {
               for (int col = 0; col < matrix.Col; col++)
               {
                   if (matrix[row,col] == (dynamic)0)
                   {
                       return false;
                   }
               }
           }
           return true;
       }
       public static bool operator false(Matrix<T> matrix)
       {
           for (int row = 0; row < matrix.Row; row++)
           {
               for (int col = 0; col < matrix.Col; col++)
               {
                   if (matrix[row, col] == (dynamic)0)
                   {
                       return false;
                   }
               }
           }
           return true;
       }
       public override string ToString()
       {
           StringBuilder result = new StringBuilder();

           for (int row = 0; row < matrix.GetLength(0); row++)
           {
               for (int col = 0; col < matrix.GetLength(1); col++)
               {
                   result.Append(this.matrix[row, col]);
                   result.Append(" ");
               }
               result.Append(Environment.NewLine);
           }
           return result.ToString();
       }

    }
}
