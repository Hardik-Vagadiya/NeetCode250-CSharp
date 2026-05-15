# Valid Anagram

**Difficulty:** Easy
**Category:** Arrays & Hashing
**NeetCode Link:** https://neetcode.io/problems/is-anagram
**LeetCode Link:** https://leetcode.com/problems/valid-anagram/

## Problem

Given two strings `s` and `t`, return `true` if the two strings are anagrams
of each other, otherwise return `false`.

An anagram is a string that contains the exact same characters as another
string, but the order of the characters can be different.

**Example 1:**
Input: s = "anagram", t = "nagaram"
Output: true

**Example 2:**
Input: s = "rat", t = "car"
Output: false

**Constraints:**
- 1 <= s.length, t.length <= 50,000
- s and t consist of lowercase English letters only

## Approach

First checked if both strings have the same length — if not, they cannot be
anagrams and we return false immediately.

Then used a HashMap to count the frequency of each character in `s`, and
decremented the count for each character in `t`. If the strings are anagrams,
every increment will be cancelled out by a corresponding decrement. At the end,
if all counts are zero, the strings are anagrams.

This avoids the brute force O(n log n) approach of sorting both strings and
comparing them character by character.

## Complexity

| | Complexity |
|---|---|
| Time | O(n) — single pass through both strings |
| Space | O(1) — HashMap holds at most 26 lowercase English letter entries |

## Key Insights:

- Early length check avoids unnecessary work when strings differ in size.
- Since the input is restricted to lowercase English letters, the HashMap never
  grows beyond 26 entries, making the space effectively O(1).
- Brute force approach is to sort both strings and compare them. This is
  O(n log n) time and simpler to implement, but not optimal.
- A fixed-size array of length 26 can replace the HashMap entirely, using
  `index = char - 'a'` to map each character to a slot. Slightly faster in
  practice due to no hashing overhead.