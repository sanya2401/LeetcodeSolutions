# No-Zero integer is a positive integer that does not contain any 0 in its decimal representation.

# Given an integer n, return a list of two integers [a, b] where:

# a and b are No-Zero integers.
# a + b = n
The test cases are generated so that there is at least one valid solution. If there are many valid solutions, you can return any of them.

## Intuition
Detect No Zero using modulus.

## Approach
Take one number as a and other as b=n-a. Detect if both no Zero by using modulus.

## Complexity
- Time complexity:
O(N)

- Space complexity:
O(1)

## Code
```csharp []
public class Solution {
    public int[] GetNoZeroIntegers(int n) {
        int[] result=new int[2];
        for(int i=1;i<=n;i++)
        {
            int a=i;
            int b=n-a;
            if(isZero(a)==false && isZero(b)==false)
            {
                result[0]=a;
                result[1]=b;
                break;
            }
        }
        return result;
    }
    public bool isZero(int x) //return true if zero
    {
        while (x>0)
        {
            if(x%10 == 0)
            return true;
            x=x/10;
        }
        return false;
    }
}
```
