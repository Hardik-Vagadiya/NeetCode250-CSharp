# Valid Palindrome

**Difficulty:** Easy
**Category:** Two Pointers
**NeetCode Link:** https://neetcode.io/problems/is-palindrome/question?list=neetcode150
**LeetCode Link:** https://leetcode.com/problems/valid-palindrome/

## Problem

Given a string `s`, return `true` if it is a **palindrome**, otherwise return `false`.

A palindrome is a string that reads the same forward and backward. It is also
case-insensitive and ignores all non-alphanumeric characters.

**Example 1:**
Input: s = "Was it a car or a cat I saw?"
Output: true

**Example 2:**
Input: s = "tab a cat"
Output: false

**Constraints:**
- 1 <= s.length <= 1000
- s consists only of printable ASCII characters.

## Approach

Used two pointers starting at each end of the string, moving inward. Non-alphanumeric
characters are skipped on both sides. At each step, the characters at both pointers
are compared in a case-insensitive manner. If any pair doesn't match, return false
immediately. If the pointers meet without a mismatch, the string is a palindrome.

This avoids the brute force approach of creating a filtered copy of the string and
reversing it, which costs O(n) extra space.

## Complexity

| | Complexity |
|---|---|
| Time | O(n) — single pass through the string |
| Space | O(1) — no extra space used |

## What I Learned

- Two pointers are effective for in-place string comparisons without extra allocation.
- Skipping non-alphanumeric characters inline keeps space at O(1).
- Brute force (filter + reverse) is O(n) time but O(n) space due to the filtered copy.
- Another approach is to clean the string first using regex or `isalnum()`, then compare
  with its reverse. Simpler to write but uses O(n) space for the cleaned string.