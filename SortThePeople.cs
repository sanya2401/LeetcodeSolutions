/*You are given an array of strings names, and an array heights that consists of distinct positive integers. Both arrays are of length n.

For each index i, names[i] and heights[i] denote the name and height of the ith person.

Return names sorted in descending order by the people's heights.
*/

public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        int temp;
        String temp1;
        for (int i=0;i<heights.Length;i++)
        {
            for(int j=i+1;j<heights.Length;j++)
            {
                if (heights[j]>heights[i])
                {
                    temp=heights[i];
                    heights[i]=heights[j];
                    heights[j]=temp;
                    temp1=names[i];
                    names[i]=names[j];
                    names[j]=temp1;
                }
            }
        }
        return names;
    }
    
}
