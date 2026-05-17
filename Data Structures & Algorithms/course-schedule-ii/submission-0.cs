public class Solution {
    private Dictionary<int, List<int>> preMap = new Dictionary<int, List<int>>();
    private HashSet<int> visited = new HashSet<int>();
    private HashSet<int> cycle = new HashSet<int>();
    private List<int> output = new List<int>();

    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        
        for (int i = 0; i < numCourses; i++){
            preMap[i] = new List<int>();
        }

        foreach (var prereq in prerequisites)
        {
            preMap[prereq[0]].Add(prereq[1]); 
        }

        for (int c = 0; c < numCourses; c++)
        {
            if (!Dfs(c)) return new int[0];
        }

        return output.ToArray();
    }

    private bool Dfs(int crs)
    {
        if (cycle.Contains(crs)) return false;
        if (visited.Contains(crs)) return true;

        cycle.Add(crs);
        foreach (var pre in preMap[crs])
        {
            if (!Dfs(pre)) return false;
        }

        visited.Add(crs);
        cycle.Remove(crs);
        output.Add(crs);
        return true;       
    }
}
