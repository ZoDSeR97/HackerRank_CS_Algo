class Result
{

    /*
     * Complete the 'jumpingOnClouds' function below.
     *
     * The function is expected to return 
     *  an INTEGER of minimum jumps.
     * The function accepts INTEGER_ARRAY c as parameter.
     */

    public static int jumpingOnClouds(List<int> c)
    {
        int jumps = 0;
        for(int i = 0; i < c.Count; jumps++)
            if(i+2 < c.Count && c[i+2] != 1)
                i+=2;
            else
                i+=1;
        return jumps-1;
    }

}