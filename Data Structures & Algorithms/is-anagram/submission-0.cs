public class Solution {
    public bool IsAnagram(string s, string t) {
        int [] sArr = new int[26];
        int [] tArr = new int [26];
        if(s.Length != t.Length){
            return false;
        }
        for(int i=0; i<s.Length; i++ )
        {
            sArr[(s[i]-97)] += 1;
        }
        for(int j=0; j<t.Length; j++)
        {
            tArr[(t[j]-97)] += 1;
        }

        for(int k=0;k<26;k++)
        {
            if(sArr[k]!=tArr[k])
                return false;
        }

        return true;
    }
}