public class Solution {
    public void SortColors(int[] nums) {
        int[] numbers = new int[3];
        for(int i=0;i<nums.Length;i++)
        {
            numbers[nums[i]]+=1;
        }
        
        nums[0..(numbers[0])].AsSpan().Fill(0);
        nums[(numbers[0])..(numbers[1])].AsSpan().Fill(1);
        nums[(numbers[1])..(numbers[2])].AsSpan().Fill(2);
    }
}