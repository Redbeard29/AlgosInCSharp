/* Palindrome Check:
Write a function that takes in a non-empty string and that returns a boolean representing whether the string 
is a palindrome. A palindrome is defined as a string that's written the same forward and backward. Note that 
single character strings are palindromes. 
Ex: string='abcdcba'
output -> True 
*/

using System;

//Solution 1:
public class Program {
	public static bool IsPalindrome1(string str) {
		int left = 0;
		int right = str.Length - 1;
		while(left < right){
			if(str[left] == str[right]){
				left++;
				right--;
			}
			else{
				return false;
			}
		}
		return true;
	}
    //Solution 2:
    public static bool IsPalindrome2(string str) {
		string reverseString = "";
		for(int x = str.Length - 1; x >= 0; x--){
			reverseString += str[x];
		}
		return reverseString == str;
	}
}

