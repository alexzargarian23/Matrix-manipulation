namespace ConsoleApp1;

public class bestAttempt
{
    public struct Attempt
    {
        public int Score;
        public int Day;
    }
    public static Attempt[] BestAttempt(Attempt[][] matrix)
    {
        var list = new List<Attempt>();
        for (int i = 0; i < matrix.Length; i++)
        {
            var max = matrix[i][0];
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j].Score > max.Score)
                {
                    max = matrix[i][j];
                }
            }
            list.Add(max);
        }
        return list.ToArray();
    }
}