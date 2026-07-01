class Solution {
    public int[] sortArray(int[] nums) {
        for(int i=0;i<nums.length;i++)
        {
            int num = nums[i]; 
            for(int j=i+1;j<nums.length;j++)
            {
                if(num>nums[j])
                {
                    nums[i] = nums[i]+nums[j];
                    nums[j] = nums[i]-nums[j];
                    nums[i] = nums[i]-nums[j];
                }
                num=nums[i];
            }
        }
        return nums;
    }
}