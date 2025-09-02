### 3021. Alice and Bob Playing Flower Game
The game proceeds as follows:

Alice takes the first turn.
In each turn, a player must choose either one of the lane and pick one flower from that side.
At the end of the turn, if there are no flowers left at all in either lane, the current player captures their opponent and wins the game.
Given two integers, n and m, the task is to compute the number of possible pairs (x, y) that satisfy the conditions:

Alice must win the game according to the described rules.
The number of flowers x in the first lane must be in the range [1,n].
The number of flowers y in the second lane must be in the range [1,m].
Return the number of possible pairs (x, y) that satisfy the conditions mentioned in the statement.

# Intuition
Find the condition when Alice wins

# Approach
If Alice takes the first turn, she only whens when the total number of flowers x+y is odd.

# Complexity
Time complexity:
O(1)

Space complexity:
O(1)

# Code

```C#
public class Solution {
    public long FlowerGame(int n, int m) {
        long OddN=(n+1)/2;
        long EvenM=(m/2);
        long EvenN=n/2;
        long OddM=(m+1)/2;
        return(OddN*EvenM)+(EvenN*OddM);
    }
}
```
