public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return "";

        string shortest = strs[0];
        foreach (var s in strs)
        {
            if (s.Length < shortest.Length)
                shortest = s;
        }

        for (int i = 0; i < shortest.Length; i++)
        {
            char c = shortest[i];
            for (int k = 0; k < strs.Length; k++)
            {
                if (strs[k][i] != c)
                    return shortest.Substring(0, i);
            }
        }

        return shortest;
    }
}