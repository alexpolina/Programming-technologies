using System;
using MatrixLib;



namespace Lab10
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Matrix MatrixA = new Matrix();
            Matrix MatrixB = new Matrix();
            Matrix MatrixC = new Matrix();


            MatrixA.GenerateMatrix(10, 5);
            MatrixA.SaveMatrix("FileForFirstMatrix.txt");
            MatrixB.GenerateMatrix(10, 5);
            MatrixB.SaveMatrix("FileForSecondMatrix.txt");



            if (MatrixA.LoadMatrix("FileForFirstMatrix.txt"))
                MatrixA.PrintMatrix();
            Console.WriteLine("\n\n");
            if (MatrixB.LoadMatrix("FileForSecondMatrix.txt"))
                MatrixB.PrintMatrix();
            Console.WriteLine("\n\n");

            var result = MatrixC.MatrixMultiplication(MatrixA.matrix, MatrixB.matrix);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
