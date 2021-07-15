//Three Number Sum:
//Write a function that takes in a non-empty array of distinct integers and an integer
//representing a target sum. The function should find all triplets in the array that sum
//up to the target sum and return a two-dimensional array of all these triplets. The numbers
//in each triplet should be ordered in ascending order, and the triplets themselves should
//be ordered in ascending order with respect to the numbers they hold. If no three numbers
//sum up to the target sum, the function should return an empty array.
//Ex: array = [12, 3, 1, 2, -6, 5, -8, 6], targetSum = 0
//Output -> [[-8, 2, 6], [-8, 3, 5], [-6, 1, 5]]

using System;
using System.Collections.Generic;

public class Program {
	public static List<int[]> ThreeNumberSum(int[] array, int targetSum) {
		Array.Sort(array);
		List<int[]> triplets = new List<int[]>();
		for(int x = 0; x < array.Length - 2; x++){
			int left = x + 1;
			int right = array.Length - 1;
			while(left < right){
				int sum = array[x] + array[left] + array[right];
				if(sum == targetSum){
					int [] triplet = {array[x], array[left], array[right]};
					triplets.Add(triplet);
					left++;
					right--;
				}
				else if(sum < targetSum){
					left ++;
				}
				else if(sum > targetSum){
					right --;
				}
			}
		}
		return triplets;
	}
}
public class Program {

	public int FirstDuplicateValue(int[] array) {
		HashSet<int> frequencyCounter = new HashSet<int>();
		
		foreach(var num in array){
			if(frequencyCounter.Contains(num)) return num;
			frequencyCounter.Add(num);
		}
		return -1;
	}
}

