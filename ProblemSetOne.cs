using System;
using System.Collections.Generic;
using System.Text;

namespace dailyinterviewpro_solutions
{
    public class ProblemSetOne
    {
        /*
        1.
        [Uber]
        Given a list of numbers, find if there exists a pythagorean triplet in that list. 
        A pythagorean triplet is 3 variables a, b, c where a2 + b2 = c2
        Example:
        Input: [3, 5, 12, 5, 13]
        Output: True
        def findPythagoreanTriplets(nums):
         */
        public bool findPythagoreanTriplets(int[] nums)
        {
            bool tripletExists = false;

            return tripletExists; 
        }

        /*
        2.
        [AirBNB]
        "Levenshtein Distance"
        Given two strings, determine the edit distance between them. 
        The edit distance is defined as the minimum number of edits (insertion, deletion, or substitution) 
        needed to change one string to the other.
        For example, "biting" and "sitting" have an edit distance of 2 (substitute b for s, and insert a t).
        Here's the signature:
        def distance(s1, s2):
        */
        public int LevenshteinDistance(string s1, string s2)
        {
            return 0;
        }

        /*
        3.
        [Google]

        Given a mathematical expression with just single digits, plus signs, negative signs, and brackets, 
        evaluate the expression. Assume the expression is properly formed.
        Example:
        Input: - ( 3 + ( 2 - 1 ) )
        Output: -4
        Here's the function signature:
        def eval(expression):         
        */
        public int Evaluate(string expression)
        {
            return 0;
        }

        /*
        4.
        [Facebook]
        Given an undirected graph, determine if a cycle exists in the graph.
        Refer the problem again. 
        */
        public bool CycleCheck(int[][] graph)
        {
            return false;
        }

        /*
         5.
        [Amazon]

        You are given a 2D array of characters, and a target string. 
        Return whether or not the word target word exists in the matrix. 
        Unlike a standard word search, the word must be either going left-to-right, or top-to-bottom in the matrix.
        Example:
        [['F', 'A', 'C', 'I'],
        ['O', 'B', 'Q', 'P'],
        ['A', 'N', 'O', 'B'],
        ['M', 'A', 'S', 'S']]
        Given this matrix, and the target word FOAM, you should return true, as it can be found going up-to-down 
        in the first column.
        Here's the function signature:
        def word_search(matrix, word):
         */
        public bool WordSearch(int[][] matrix, string word)
        {
            return false;
        }

        /*
         6.
        [Amazon]
        Given an array of n positive integers and a positive integer s, 
        find the minimal length of a contiguous subarray of which the sum ≥ s. 
        If there isn't one, return 0 instead.
        Example:
        Input: s = 7, nums = [2,3,1,2,4,3]
        Output: 2
        Explanation: the subarray [4,3] has the minimal length under the problem constraint.
        Here is the method signature:

        class Solution:
            def minSubArrayLen(self, nums, s):
         */
        public int MinSubArrayLength(int[] nums, int sum)
        {
            return 0;
        }
        /*
        7.
        [Microsoft]
        You have 2 integers n and m representing an n by m grid, 
        determine the number of ways you can get from the top-left to the bottom-right 
        of the matrix y going only right or down.
        Example:
        n = 2, m = 2
        This should return 2, since the only possible routes are:
        Right, down
        Down, right.
        Here's the signature:
        def num_ways(n, m):
        */
        public int TotalPaths(int n, int m)
        {
            // shouldn't it be m-1 * n-1 * 2 ??
            return 0;
        }

        /*
         8. 
        [Apple]
        You are given two singly linked lists. The lists intersect at some node. Find, and return the node. 
        Note: the lists are non-cyclical.
        Example:
        A = 1 -> 2 -> 3 -> 4
        B = 6 -> 3 -> 4
        This should return 3 (you may assume that any nodes with the same value are the same node).
        Here is a starting point:
        def intersection(a, b):
         */
        public class Node
        {
            Node next;
            int value;

            public Node(int value)
            {
                value = value;
            }
        }
        public Node intersection(Node a, Node b)
        {
            return new Node(1);
        }
        /*
        9.
        [Twitter]
        Given a string with the initial condition of dominoes, where:
        . represents that the domino is standing still
        L represents that the domino is falling to the left side
        R represents that the domino is falling to the right side
        Figure out the final position of the dominoes. 
        If there are dominoes that get pushed on both ends, 
        the force cancels out and that domino remains upright.
        Example:
        Input:  ..R...L..R.
        Output: ..RR.LL..RR
        Here is your starting point:

        class Solution(object):
            def pushDominoes(self, dominoes):
        */
        public char[] PushDominoes(char[] dominoes)
        {
            return new char[]{ '.','L'};
        }

        /*
         10.
        [Uber]

        Given a linked list of integers, remove all consecutive nodes that sum up to 0.
        Example:
        Input: 10 -> 5 -> -3 -> -3 -> 1 -> 4 -> -4
        Output: 10
        The consecutive nodes 5 -> -3 -> -3 -> 1 sums up to 0 so that sequence should be removed. 
        4 -> -4 also sums up to 0 too so that sequence should also be removed. 
         */
         public void RemoveNodes(LinkedList<int> list)
         {
            LinkedList<LinkedListNode<int>> list1 = new LinkedList<LinkedListNode<int>>();
            list.AddFirst(new LinkedListNode<int>(1));
            LinkedListNode<int> nodde = new LinkedListNode<int>(1);
         }
    }
}
