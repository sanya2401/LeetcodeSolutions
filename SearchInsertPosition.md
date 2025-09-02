## Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

## You must write an algorithm with O(log n) runtime complexity.


# Intuition
Use Binary Search for log n complexity.

# Approach
Recursively apply Binary Search till you reach the terget or the nearest index to insert, thats when the value of low becomes greater than high.

# Complexity
- Time complexity:
O(log n)

- Space complexity:
O(1)

# Code
```csharp []
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        return BinarySearch(nums,target,0,nums.Length-1 );
    }
    public int BinarySearch(int[] nums,int target, int low,int high)
    {
        if(low>high)
        return low;
        /*if(low==high)
        {
            if(nums[low]==target)
            return low;
            else if (target< nums[low]) return low;
            else return low+1;
        }
        */
        else
        {
            int mid=(low+high)/2;
            if(nums[mid]==target)
            return mid;
            else if (target<nums[mid])
            return BinarySearch(nums,target,low,mid-1);
            else
            return BinarySearch(nums,target,mid+1,high);
        }
        return -1;
       
    }
}
```
