class Result
{

    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return 
     *  an INTEGER of valleys quantity.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        int seaLv = 0;
        int valleys = 0;
        foreach(char c in path){
            if(seaLv == 0 && c.Equals('D'))
                valleys+=1;
            if(c.Equals('U'))
                seaLv += 1;
            else
                seaLv -= 1;
        }
        return valleys;
    }

}