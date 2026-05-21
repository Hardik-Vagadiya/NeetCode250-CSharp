# Reverse String

**Difficulty:** Easy
**Category:** Two Pointers
**NeetCode Link:** https://neetcode.io/problems/reverse-string/question?list=neetcode250
**LeetCode Link:** https://leetcode.com/problems/reverse-string/

## Problem

You are given an array of characters which represents a string `s`. Write a
function which reverses a string. You must do this by modifying the input array
in-place with O(1) extra memory.

**Example 1:**
Input: s = ['h', 'e', 'l', 'l', 'o']
Output: ['o', 'l', 'l', 'e', 'h']

**Example 2:**
Input: s = ['H', 'a', 'n', 'n', 'a', 'h']
Output: ['h', 'a', 'n', 'n', 'a', 'H']

**Constraints:**
- 1 <= s.length <= 100,000
- s[i] is a printable ASCII character.

## Approach

Used two pointers starting at opposite ends of the array, moving inward. At each
step, the characters at both pointers are swapped. The process continues until
the two pointers meet or cross, at which point every character has been swapped
exactly once and the array is fully reversed in-place.

This avoids the brute force approach of creating a reversed copy of the array,
which would require O(n) extra space.

## Complexity

| | Complexity |
|---|---|
| Time | O(n) — each element is visited at most once |
| Space | O(1) — swaps are done in-place, no extra allocation |

## What I Learned

- Two pointers from both ends is the natural fit for any in-place reversal problem.
- The loop condition must be `l < r`, not `l != r`, to correctly handle both
  even and odd length arrays without going out of bounds.
- Brute force (create a copy and reverse it) works but costs O(n) extra space,
  which violates the problem's constraint.