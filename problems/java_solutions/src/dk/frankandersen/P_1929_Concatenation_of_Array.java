package dk.frankandersen;

import java.util.stream.IntStream;
import java.util.Arrays;

class Solution {

    public int[] getConcatenation(int[] nums) {
        return IntStream.concat(Arrays.stream(nums), Arrays.stream(nums)).toArray();
    }
}


public class P_1929_Concatenation_of_Array {

    public void run() {
        Solution solution = new Solution();
        int[] nums = new int[] {1,2,1};
        int[] result = solution.getConcatenation(nums);
        System.out.println("Expectations:");
        System.out.println("Input: nums = [1,2,1]");
        System.out.println("Output: [1,2,1,1,2,1]");

        System.out.println("Results:");
        System.out.println(Arrays.toString(result));
    }
}

