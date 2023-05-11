using System;

class KadaneAlgo
{
    static int[] a={-1,-2,-3,-4};
    static int n= a.Length;

    public long maxSubArraySum()
    {
        long maxValue = int.MinValue;
        long maxEnding = 0;

        for (int i = 0; i < n; i++)
        {
            maxEnding += a[i];

            if (maxEnding > maxValue) maxValue = maxEnding;
            if (maxEnding < 0) maxEnding=0;
        }

        return maxValue;
    }
}