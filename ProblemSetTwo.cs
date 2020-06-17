using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace dailyinterviewpro_solutions
{
    public class ProblemSetTwo
    {
        /*
        11.
        [AirBNB]
        You are given a singly linked list and an integer k. 
        Return the linked list, removing the k-th last element from the list.
        Try to do it in a single pass and using constant space.
        */
        public LinkedList<int> remove(LinkedList<int> nums)
        {
            return nums;
        }

        /*
        12.
        [Google]
        There are n people lined up, and each have a height represented as an integer. 
        A murder has happened right in front of them, 
        and only people who are taller than everyone in front of them are able to see what has happened. 
        How many witnesses are there?
        Example:
        Input: [3, 6, 3, 4, 1]  
        Output: 3
        Explanation: Only [6, 4, 1] were able to see in front of them.
        */
        public int witnesses(int[] people)
        {
            return 0;
        }

        /*
        13.
        You are given a hash table where the key is a course code, 
        and the value is a list of all the course codes that are prerequisites for the key. 
        Return a valid ordering in which we can complete the courses. If no such ordering exists, return NULL.
        Example:
        {
          'CSC300': ['CSC100', 'CSC200'], 
          'CSC200': ['CSC100'], 
          'CSC100': []
        }

        This input should return the order that we need to take these courses:
         ['CSC100', 'CSC200', 'CSCS300']
        Here's your starting point:
        def courses_to_take(course_to_prereqs):
        */
        public List<string> courses_to_take(Hashtable courses)
        {
            return new List<string>(){ "CSC100", "CSC200", "CSCS300"};
        }
        /*

        14. 
        [Facebook]
        Given an array nums, write a function to move all 0's to the end of it 
        while maintaining the relative order of the non-zero elements.
        Example:
        Input: [0,1,0,3,12]
        Output: [1,3,12,0,0]
        You must do this in-place without making a copy of the array.
        Minimize the total number of operations.
        Here is a starting point:
        class Solution:
          def moveZeros(self, nums):
        */
        public int[] moveZeros(int[] nums)
        {
            return nums;
        }

        /*
        15.
        [Facebook]
        Given a list, find the k-th largest element in the list.
        Input: list = [3, 5, 2, 4, 6, 8], k = 3
        Output: 5
        Here is a starting point:
        def findKthLargest(nums, k):
        */
        public int findKthLargest(int[] nums)
        {
            return 0;
        }
        /*

        16.
        [Amazon]
        You are given a 2D array of integers. Print out the clockwise spiral traversal of the matrix.
        Example:
        grid = [[1,  2,  3,  4,  5],
                [6,  7,  8,  9,  10],
                [11, 12, 13, 14, 15],
                [16, 17, 18, 19, 20]]

        The clockwise spiral traversal of this array is:
        1, 2, 3, 4, 5, 10, 15, 20, 19, 18, 17, 16, 11, 6, 7, 8, 9, 14, 13, 12
        Here is a starting point:
        def matrix_spiral_print(M):
        */
        public int[] matrix_spiral_print(int[][] matrix)
        {
            return new int[] { 1 };
        }
        /*

        17.
        [Microsoft]
        You are given an array of integers. 
        Return the largest product that can be made by multiplying any 3 integers in the array.
        Example:
        [-4, -4, 2, 8] should return 128 as the largest product can be made by multiplying -4 * -4 * 8 = 128.
        Here's a starting point:
        def maximum_product_of_three(lst):
        */
        public int maximum_product_of_three(int[] nums)
        {
            return 1;
        }
        /*

        18.
        [Microsoft]
        You are given an array of intervals - that is, an array of tuples (start, end). 
        The array may not be sorted, and could contain overlapping intervals. 
        Return another array where the overlapping intervals are merged.
        For example:
        [(1, 3), (5, 8), (4, 10), (20, 25)]
        This input should return [(1, 3), (4, 10), (20, 25)] since (5, 8) and (4, 10) can be merged into (4, 10).
        Here's a starting point:
        def merge(intervals):
        */
        public List<Tuple<int,int>> merge(List<Tuple<int, int>> intervals)
        {
            return intervals;
        }

        /*
        19.
        [Apple]
        You are given an array. Each element represents the price of a stock on that particular day. 
        Calculate and return the maximum profit you can make from buying and selling that stock only once.
        For example: [9, 11, 8, 5, 7, 10]
        Here, the optimal trade is to buy when the price is 5, and sell when it is 10, so the return value should be 5 (profit = 10 - 5 = 5).
        Here's your starting point:
        def buy_and_sell(arr):
        */
        public int buy_and_sell(int[] arr)
        {
            return 0;
        }

        /*
        20.
        [Twitter]
        You are given an array of integers. 
        Find the maximum sum of all possible contiguous subarrays of the array.
        Example:
        [34, -50, 42, 14, -5, 86]
        Given this input array, the output should be 137. The contiguous subarray with the largest sum is [42, 14, -5, 86].
        Your solution should run in linear time.
        Here's a starting point:
        def max_subarray_sum(arr):
        */
        public int max_subarray_sum(int[] arr)
        {
            return 0;
        }
    }
}
