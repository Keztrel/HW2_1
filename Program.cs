using System;

class PascalTriangle
{
    static void Main()
    {
        int rowNumber;
        do
        {
            Console.Write("Enter the number of layer: ");
            if (!int.TryParse(Console.ReadLine(), out rowNumber))
            {
                Console.WriteLine("Invalid number.");
                continue;
            }

            if (rowNumber < 0)
            {
                Console.WriteLine("Invalid Pascal's triangle row number.");
                continue;
            }

            DisplayPascalTriangle(rowNumber);

        } while (true);
    }

    static void DisplayPascalTriangle(int numRows)
    {
        for (int i = 0; i <= numRows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(CalculatePascalValue(i, j) + " ");
            }
            Console.WriteLine();
        }
    }

    static int CalculatePascalValue(int row, int column)
    {
        if (column == 0 || column == row)
        {
            return 1;
        }
        else
        {
            return CalculatePascalValue(row - 1, column - 1) + CalculatePascalValue(row - 1, column);
        }
    }
}

