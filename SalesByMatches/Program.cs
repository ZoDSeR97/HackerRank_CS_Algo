class Result
{

    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return 
     *  an INTEGER of total pair of sock.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        Dictionary<int, int> mem = new Dictionary<int, int>();
        foreach(int num in ar)
            if (!mem.ContainsKey(num))
                mem[num] = 1;
            else
                mem[num] += 1;
        int pairs = 0;
        foreach(KeyValuePair<int, int> t in mem)
            pairs += t.Value/2;
        return pairs;
    }

}