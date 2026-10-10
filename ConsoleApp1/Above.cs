namespace ConsoleApp1;

public class above
{
    public static int[] Above(int[][] matrix, int target)
    {
        int count = 0;
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] > target)
                {
                    count++;
                }
            }
        }
        var result = new int[count];
        int counter = 0;
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] > target)
                {
                    result[counter] = matrix[i][j];
                    counter++;
                }
            }
        }
return result;
    }
}