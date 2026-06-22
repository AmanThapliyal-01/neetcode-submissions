public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var len = nums.Length;
        int[] num = new int[len*2];
        for(int i=0; i<len; i++ )
        {
            num[i]=nums[i];
            num[len+i]=nums[i];
        }
        return num;
    }
}