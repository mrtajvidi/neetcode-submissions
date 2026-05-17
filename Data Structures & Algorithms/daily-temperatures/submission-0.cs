public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        //temps: [30, 38, 30, 36, 35, 40, 28]
        // idx    0 ,  1,  2,  3,  4,  5,  6

        //res:   [ 1,  4,  1,  2,  1,  0,  0]
        
        // i:  0,  1,  2,  3,  4,  5,  6
        // t: 30, 38, 30, 36, 35, 40, 28
         
        // stack: [40, 5], 
        // pair:  [30, 0], [30, 2], [35, 4], [36, 3]
        // Exres[ 1,  4,  1,  2,  1,  0,  0]
        // res: [ 1,  4,  1,  2,  1,  0,  0]
        // idx:  0 , 1 , 2 , 3 , 4 , 5 , 6  

        int[] res = new int[temperatures.Length];
        Stack<int[]> stack = new Stack<int[]>(); // pair: [temp, index]

        for (int i = 0; i < temperatures.Length; i++) {
            int t = temperatures[i];
            while (stack.Count > 0 && t > stack.Peek()[0]) {
                int[] pair = stack.Pop();
                res[pair[1]] = i - pair[1];
            }
            stack.Push(new int[] { t, i });
        }
        return res;
    }
}
