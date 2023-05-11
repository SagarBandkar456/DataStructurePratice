using System;

class TrappingRain
{
    static int[] a = { 3, 0, 0, 2, 0, 4 };
    static int n = a.Length;

    public long trappingWater()
    {
        long res = 0;
        int l = 0;
        int r = n - 1;
        int lMax = 0, rMax = 0;

        while (l <= r)
        {
            if (a[l] <= a[r])
            {
                if (a[l] >= lMax) lMax = a[l];
                else res += lMax - a[l];
                l++;
            }
            else
            {
                if (a[r] >= rMax) rMax = a[r];
                else res += rMax - a[r];
                r--;
            }

            //(taking time complexity of o(n2))
            // for(int i=1;i<n-1;i++)
            // {
            //     int left=a[i];
            //     for(int j=0;j<i;j++) left=Math.Max(left,a[j]);

            //     int right=a[i];
            //     for(int j=i+1;j<n;j++) right=Math.Max(right,a[j]);

            //     res+=Math.Min(left,right)-a[i];
            // }

        }
        return res;
    }
}