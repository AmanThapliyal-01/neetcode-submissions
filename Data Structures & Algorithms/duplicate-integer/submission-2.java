class Solution {
    public boolean hasDuplicate(int[] nums) {
        Map<Integer,Integer> dict = new HashMap<>();
        for(int i=0; i<nums.length ;i++)
        {
            if(dict.containsKey(nums[i]))
            {
                if(dict.get(nums[i])>=1)
                    return true;
                else
                    dict.put(nums[i],dict.get(nums[i])+1);
            }
            else
                dict.put(nums[i],1);
        }
        return false;
    }
}