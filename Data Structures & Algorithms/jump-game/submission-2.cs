public class Solution {
    public bool CanJump(int[] nums) {        
        var l = nums.Length;

        if (l == 1 || l == 0) return true;

        var goal = l - 1;
        Console.WriteLine($"initial goal is: {goal}");


        for (int j = l - 1; j >= 0; j--)
        {
            Console.WriteLine($"j is: {j}");
            if (j + nums[j] >= goal)
            {
                goal = j;
            }
            Console.WriteLine($"goal is: {goal}");
        }

        return goal == 0;
    }
}
