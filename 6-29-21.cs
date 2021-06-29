/*Two Number Sum:
Write a function that takes in a non-empty array of distinct integers and an integer representing a target
sum. If any two number in the input array sum up to the target sum, the function should return them in an 
array, in any order. If no two numbers sum up to the target sum, the function should return an empty array.
Note that the target sum has to be obtained by summing two different integers in the array; you can't add 
a single integer to itself in order to obtain the target sum. You can assume that there will be at most
one pair of numbers summing up to the target sum.
Ex: arr = [3, 5, -4, 8, 11, 1, -1, 6], targetSum = 10
output: [-1, 11]
*/

//Solution 1:

using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Program {
	public static int[] TwoNumberSum1(int[] array, int targetSum) {
		Array.Sort(array);
		int left = 0;
		int right = array.Length - 1;
		while(left < right){
			int currentSum = array[left] + array[right];
			if (currentSum == targetSum){
				return new int[] {array[left], array[right]};
			}
			else if (currentSum < targetSum){
				left++;
			}
			else if (currentSum > targetSum){
				right--;
			}
		}
		return new int[0];
	}
    	public static int[] TwoNumberSum2(int[] array, int targetSum) {
		HashSet<int> nums = new HashSet<int>();
		foreach (int num in array){
			int remainder = targetSum - num;
			if (nums.Contains(remainder)){
				return new int[] {remainder, num};
			}
			else{
				nums.Add(num);
			}
		}
		return new int[0];
	}
}

