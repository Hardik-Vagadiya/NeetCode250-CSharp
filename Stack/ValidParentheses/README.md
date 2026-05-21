# Valid Parentheses

**Difficulty:** Easy
**Category:** Stack
**NeetCode Link:** https://neetcode.io/problems/validate-parentheses/question?list=neetcode150
**LeetCode Link:** https://leetcode.com/problems/valid-parentheses/

## Problem

Given a string `s` containing only the characters `'('`, `')'`, `'{'`, `'}'`,
`'['` and `']'`, determine if the input string is valid.

A string is valid if:
- Every open bracket is closed by the same type of closing bracket.
- Open brackets are closed in the correct order.
- Every closing bracket has a corresponding open bracket of the same type.

**Example 1:**
Input: s = "()"
Output: true

**Example 2:**
Input: s = "()[]{}"
Output: true

**Example 3:**
Input: s = "(]"
Output: false

**Constraints:**
- 1 <= s.length <= 10,000
- s consists of parentheses only: '(){}[]'

## Approach

Used a stack to track unmatched opening brackets while iterating through the
string. For every opening bracket encountered, it is pushed onto the stack.
For every closing bracket, we check if the top of the stack holds the
corresponding opening bracket — if it does, we pop it; if not (or the stack
is empty), the string is invalid. After processing all characters, the string
is valid only if the stack is empty, meaning every opening bracket was matched
and closed correctly.

A HashMap is used to store the closing-to-opening bracket mappings, making
the matching check clean and easy to extend.

## Complexity

| | Complexity |
|---|---|
| Time | O(n) — each character is pushed or popped at most once |
| Space | O(n) — in the worst case, all characters are opening brackets and are stored on the stack |

## What I Learned

- Stack is the natural fit for problems that require Last-In, First-Out (LIFO)
  matching, such as bracket validation or expression parsing.
- The stack must be empty at the end for the string to be valid — a non-empty
  stack means there are unmatched opening brackets left over.
- Two failure conditions exist: a closing bracket with no matching opener at
  the top of the stack, and leftover unmatched openers after full traversal.