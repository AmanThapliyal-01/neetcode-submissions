class Solution {
    public boolean isAnagram(String s, String t) {
        int [] sArr = new int[26];
        int [] tArr = new int [26];
        int sl = s.length();
        if(sl != t.length())
            return false;
        for(int i=0; i<sl; i++ )
        {
            sArr[(s.charAt(i)-97)] += 1;
        }
        for(int j=0; j<sl; j++)
        {
            tArr[(t.charAt(j)-97)] += 1;
        }

        for(int k=0;k<26;k++)
        {
            if(sArr[k]!=tArr[k])
                return false;
        }
        return true;
    }
}
