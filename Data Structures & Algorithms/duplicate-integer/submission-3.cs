public class Solution {
    public bool hasDuplicate(int[] nums) {
        var dict = new Dictionary<int,int>();
        for(int i =0;i<nums.Length;i++)
        {
            if(dict.ContainsKey(nums[i]))
            {
                if(dict[nums[i]]>=1)
                    return true;
                else
                    dict[nums[i]] +=1;
            }
            else
                dict.Add(nums[i],1);
        }
        return false;
    }
}