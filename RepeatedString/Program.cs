class Result
{

    /*
     * Complete the 'repeatedString' function below.
     *
     * The function is expected to return 
     *  a LONG_INTEGER of letter 'a' quantity in the repeated String.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. LONG_INTEGER n
     */

    public static long repeatedString(string s, long n)
    {
        int a = 0;
        // Get total letter 'a' in string
        foreach(char c in s)
            if(c.Equals('a'))
                a+=1;
        
        long result = a*(n/s.Length); // Calculated how many times S is repeated
        long l = n-s.Length*(n/s.Length); // Calculate leftover character
        for(int i = 0; i < l; i++)
            if(s[i].Equals('a'))
                result+=1;
        
        return result;
    }

}
