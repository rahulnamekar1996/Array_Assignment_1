using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  int[] num=new int[5] {1,2,3,4,5};

              foreach (int i in num)
              { 
                  Console.WriteLine(i);
              }
              Console.WriteLine(" ");


              string[] name = new string[5] { "rahul", "rohan","akash" ,"sita", "ram" };
              Console.WriteLine(" after sort");

              Array.Sort(name);
              foreach( string i in name)
              {
                  Console.WriteLine(i);
                  Console.WriteLine(" "); 


              } 

            Console.WriteLine(" Enter the no of rows in jagged array");

            int rows= Convert.ToInt32(Console.ReadLine());
            int[][] jaggedArray= new int[rows][];

            for( int i=0; i<rows; i++ )
            {
                Console.Write($"Enter the size of row{i + 1} ");
                int rowSize= Convert.ToInt32(Console.ReadLine());

                jaggedArray[i]= new int[rowSize];

                for(int j=0; j<rowSize; j++)
                {
                    Console.Write($" Enter the value for row{i+1} and colum{j+1}");

                    jaggedArray[i][j]= Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine(" jagged array details");
            for(int i=0; i<rows;i++ )
            {
                Console.Write($"Row{i+1}");
                 for(int j=0; j < jaggedArray[i].Length; j++ )
                
                {
                    Console.Write($"{jaggedArray[i][j]}");

                }
               Console.WriteLine();
            }

            int[,] mat = new int[3, 3];
            {
                Console.WriteLine("_____for first matrix_____");
                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    for (int j = 0; j < mat.GetLength(1); j++)
                    {
                        Console.WriteLine($"Enter value for array{i},{j}");
                        mat[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    for (int j = 0; j < mat.GetLength(1); j++)
                    {
                        Console.WriteLine(mat[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("____second matrix_____");

                for(int i=0; i < mat.GetLength(0); i++)
                {
                    for( int j=0; j < mat.GetLength(1); j++)
                    {
                        Console.WriteLine($"Enter the value for array[{i},{j}]");
                        mat[i,j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                 
                for(int i=0; i<mat.GetLength(0); i++)
               
                {
                    for( int j=0; j < mat.GetLength(1); j++)
                    {
                        Console.WriteLine(mat[i,j] + " ");

                    }
                   Console.WriteLine();
               
                }

                Console.WriteLine("____Addition_____");

                for(int i=0;i<mat.GetLength(0); i++)
                {
                    for(int j=0; j < mat.GetLength(1); j++)
                    {
                        Console.Write(mat[i, j] + mat[i, j] + " ");
                    }
                  Console.WriteLine() ;
                
                }

            }*/
        

        }
    }
}
