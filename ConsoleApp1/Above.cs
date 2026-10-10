namespace ConsoleApp1;

public class above
{
    public static int[] Above(int[][] matrix, int target)
    {
        var list = new List<int>();
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] > target)
                {
                    list.Add(matrix[i][j]);
                }
            }
        }
        return list.ToArray();
    }
}