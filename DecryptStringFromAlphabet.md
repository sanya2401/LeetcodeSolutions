# You are given a string s formed by digits and '#'. We want to map s to English lowercase characters as follows:

Characters ('a' to 'i') are represented by ('1' to '9') respectively.
Characters ('j' to 'z') are represented by ('10#' to '26#') respectively.
## Return the string formed after mapping.

The test cases are generated so that a unique mapping will always exist.

## Intuition
Use Dictionary to map the alphabets to their respective numbers.

## Approach 
Parse string and check for # take the previous two along and map to the correct value, add to the string, else simple add the value to the string.

## Complexity
- Time complexity:
O(N)

- Space complexity:
O(1)

## Code
```csharp []
public class Solution {
    public string FreqAlphabets(string s) {
        Dictionary <string,string> map = new Dictionary <string,string>();
        
        for(int i=1;i<=9;i++)
        {
            map[i.ToString()]=((char)('a'+ i-1)).ToString();
        }
        for(int i=10;i<=26;i++)
        {
            map[i.ToString()+"#"]=((char)('a'+ i-1)).ToString();
        }
        StringBuilder result=new StringBuilder();
        int
