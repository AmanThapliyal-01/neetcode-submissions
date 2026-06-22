public class Solution {
    public int MajorityElement(int[] nums) {
        var dict = new Dictionary<int,int>();
        foreach(var number in nums)
        {
            if(dict.ContainsKey(number))
            {
                dict[number]+=1;
            }
            else
            {
                dict.Add(number,1);
            }
            if(dict[number]>(nums.Length/2))
                return number;
        }
        return 0;
    }
}