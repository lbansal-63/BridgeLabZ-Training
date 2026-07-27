using System;

public class MatrixOperations
{
    // Method to create random matrix
    public static double[,] CreateRandomMatrix(int rows, int columns)
    {
        double[,] matrix = new double[rows, columns];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = random.Next(1, 10);
            }
        }

        return matrix;
    }


    // Matrix Addition
    public static double[,] AddMatrix(double[,] a, double[,] b)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);

        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = a[i, j] + b[i, j];
            }
        }

        return result;
    }


    // Matrix Subtraction
    public static double[,] SubtractMatrix(double[,] a, double[,] b)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);

        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = a[i, j] - b[i, j];
            }
        }

        return result;
    }


    // Matrix Multiplication
    public static double[,] MultiplyMatrix(double[,] a, double[,] b)
    {
        int rows = a.GetLength(0);
        int cols = b.GetLength(1);

        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                for (int k = 0; k < a.GetLength(1); k++)
                {
                    result[i, j] += a[i, k] * b[k, j];
                }
            }
        }

        return result;
    }


    // Transpose of Matrix
    public static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        double[,] transpose = new double[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transpose[j, i] = matrix[i, j];
            }
        }

        return transpose;
    }


    // Determinant of 2x2 matrix
    public static double Determinant2x2(double[,] matrix)
    {
        return (matrix[0, 0] * matrix[1, 1]) -
               (matrix[0, 1] * matrix[1, 0]);
    }


    // Determinant of 3x3 matrix
    public static double Determinant3x3(double[,] m)
    {
        return m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1])
             - m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0])
             + m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);
    }


    // Inverse of 2x2 matrix
    public static double[,] Inverse2x2(double[,] m)
    {
        double det = Determinant2x2(m);

        if (det == 0)
            return null;

        double[,] inverse = new double[2, 2];

        inverse[0, 0] = m[1, 1] / det;
        inverse[0, 1] = -m[0, 1] / det;
        inverse[1, 0] = -m[1, 0] / det;
        inverse[1, 1] = m[0, 0] / det;

        return inverse;
    }


    // Inverse of 3x3 matrix
    public static double[,] Inverse3x3(double[,] m)
    {
        double det = Determinant3x3(m);

        if (det == 0)
            return null;

        double[,] inverse = new double[3, 3];

        inverse[0, 0] = (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) / det;
        inverse[0, 1] = (m[0, 2] * m[2, 1] - m[0, 1] * m[2, 2]) / det;
        inverse[0, 2] = (m[0, 1] * m[1, 2] - m[0, 2] * m[1, 1]) / det;

        inverse[1, 0] = (m[1, 2] * m[2, 0] - m[1, 0] * m[2, 2]) / det;
        inverse[1, 1] = (m[0, 0] * m[2, 2] - m[0, 2] * m[2, 0]) / det;
        inverse[1, 2] = (m[0, 2] * m[1, 0] - m[0, 0] * m[1, 2]) / det;

        inverse[2, 0] = (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]) / det;
        inverse[2, 1] = (m[0, 1] * m[2, 0] - m[0, 0] * m[2, 1]) / det;
        inverse[2, 2] = (m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0]) / det;

        return inverse;
    }


    // Display Matrix
    public static void DisplayMatrix(double[,] matrix)
    {
        if (matrix == null)
        {
            Console.WriteLine("Inverse does not exist");
            return;
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(Math.Round(matrix[i, j], 2) + "\t");
            }

            Console.WriteLine();
        }
    }


    public static void Main()
    {
        double[,] matrix1 = CreateRandomMatrix(3, 3);
        double[,] matrix2 = CreateRandomMatrix(3, 3);

        Console.WriteLine("Matrix A:");
        DisplayMatrix(matrix1);

        Console.WriteLine("\nMatrix B:");
        DisplayMatrix(matrix2);


        Console.WriteLine("\nAddition:");
        DisplayMatrix(AddMatrix(matrix1, matrix2));


        Console.WriteLine("\nSubtraction:");
        DisplayMatrix(SubtractMatrix(matrix1, matrix2));


        Console.WriteLine("\nMultiplication:");
        DisplayMatrix(MultiplyMatrix(matrix1, matrix2));


        Console.WriteLine("\nTranspose of Matrix A:");
        DisplayMatrix(Transpose(matrix1));


        Console.WriteLine("\nDeterminant of Matrix A:");
        Console.WriteLine(Determinant3x3(matrix1));


        Console.WriteLine("\nInverse of Matrix A:");
        DisplayMatrix(Inverse3x3(matrix1));
    }
}
