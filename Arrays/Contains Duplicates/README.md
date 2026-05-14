# Contains Duplicate

**Difficulty:** Easy
**Category:** Arrays & Hashing
**NeetCode Link:** https://neetcode.io/problems/duplicate-integer
**LeetCode Link:** https://leetcode.com/problems/contains-duplicate/

## Problem

Given an integer array `nums`, return `true` if any value appears more than
once in the array, otherwise return `false`.

**Example 1:**
Input: nums = [1, 2, 3, 1]
Output: true

**Example 2:**
Input: nums = [1, 2, 3, 4]
Output: false

**Constraints:**
- 1 <= nums.length <= 100,000
- -10^9 <= nums[i] <= 10^9

## Approach

Used a HashSet to track numbers seen so far while iterating through the array.
For each number, if it already exists in the set, a duplicate has been found
and we return true immediately. If the loop completes without a match,
all elements are distinct and we return false.

This avoids the brute force O(n²) approach of comparing every pair of elements.

## Complexity

| | Complexity |
|---|---|
| Time | O(n) — single pass through the array |
| Space | O(n) — HashSet stores up to n elements |

## What I Learned

- HashSet provides O(1) average-case lookup, making it ideal for duplicate detection.
- Early return on first duplicate found avoids unnecessary iterations.
- Brute force (nested loops) works but becomes too slow at 100,000 elements. It will take O(n^2) Time.
- Another solution is to sort the array in ascending order and look for duplicate element in a linear fashion.
  Better than brute force in a way that once first duplicate is found, it eliminates additional iterations.
  It will run in O(nlogn) time complexity.