namespace ConsoleApp1;

public class colderThan
{
    public static Hit[] ColderThan(Reading[][] matrix, int limit)
    {
        var list = new List<Hit>();
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j].Temperature < limit && matrix[i][j].Fault == false)
                {
                    Hit hit = new Hit
                    {
                        Temperature = matrix[i][j].Temperature,
                        Row = i,
                        Col = j

                    };
                    list.Add(hit);
                }
            }
        }
        return list.ToArray();
    }
}