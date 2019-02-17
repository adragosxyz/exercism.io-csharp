using System;

public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int[,] matrix = new int[size,size];
        int offset = 0;
        int counter=1;
        while (offset <= size/2)
        {   
            for (int j=offset;j<size-offset;j++)
            {
                matrix[offset,j]=counter;
                counter++;
            }
            for (int i=offset+1;i<size-offset;i++)
            {
                matrix[i,size-offset-1]=counter;
                counter++;
            }
            for (int j=offset+1;j<size-offset;j++)
            {
                matrix[size-offset-1,size-j-1]=counter;
                counter++;
            }
            for (int i=offset+1;i<size-offset-1;i++)
            {
                matrix[size-i-1,offset]=counter;
                counter++;
            }
            offset++;
        }
        return matrix;
    }
}
