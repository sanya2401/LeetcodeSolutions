## Given a string s consisting of words and spaces, return the length of the last word in the string.
## A word is a maximal substring consisting of non-space characters only.


# Intuition
Obtain the last word

# Approach
Trim the string and store into an array splitting th words on whitespace ' '. Calculate the Length of the last word.

# Complexity
- Time complexity:
O(N)

- Space complexity:
O(N)

# Code
```csharp []
public class Solution {
    public int LengthOfLastWord(string s)
    {
        string[] words=s.Trim().Split(' ');
        return words[words.Length-1].Length;
    }
}
```
