# Two Sum

**Difficulty:** Easy
**Category:** Arrays & Hashing
**NeetCode Link:** https://neetcode.io/problems/two-integer-sum
**LeetCode Link:** https://leetcode.com/problems/two-sum/

## Problem

Given an array of integers `nums` and an integer `target`, return the indices
`i` and `j` such that `nums[i] + nums[j] == target` and `i != j`.

You may assume that every input has exactly one pair of indices `i` and `j`
that satisfy the condition. Return the answer with the smaller index first.

**Example 1:**
Input: nums = [3, 4, 5, 6], target = 7
Output: [0, 1]

**Example 2:**
Input: nums = [4, 5, 6], target = 10
Output: [0, 2]

**Example 3:**
Input: nums = [5, 5], target = 10
Output: [0, 1]

**Constraints:**
- 2 <= nums.length <= 1000
- -10,000,000 <= nums[i] <= 10,000,000
- -10,000,000 <= target <= 10,000,000
- Only one valid answer exists.

## Approach

Used a HashMap to store each number and its index as we iterate through the array.
For each element, we compute `difference = target - nums[i]`. If `difference`
already exists in the map, we have found our pair and return both indices immediately.
Otherwise, we store the current number and its index in the map and continue.

This avoids the brute force O(n²) approach of checking every pair of elements.

## Complexity

| | Complexity |
|---|---|
| Time | O(n) — single pass through the array |
| Space | O(n) — HashMap stores up to n elements |

## What I Learned

- HashMap provides O(1) average-case lookup, making it ideal for complement-search problems.
- Computing `difference = target - nums[i]` reframes the problem: instead of finding a pair,
  we just check if the required complement has already been seen.
- Early return on first match avoids unnecessary iterations.
- Brute force (nested loops) works but becomes slow at large inputs — O(n²) time.
- Sorting-based approaches do not apply here since we need to return original indices,
  which would be lost after sorting.