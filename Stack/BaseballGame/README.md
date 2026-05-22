# Baseball Game

**Difficulty:** Easy
**Category:** Stack
**NeetCode Link:** https://neetcode.io/problems/baseball-game/question?list=neetcode250
**LeetCode Link:** https://leetcode.com/problems/baseball-game/

## Problem

You are keeping scores for a baseball game with strange rules. At the beginning
of the game, you start with an empty record. Given a list of strings
`operations`, where `operations[i]` is the ith operation to apply, and is one
of the following:

- An integer `x`: Record a new score of x.
- `'+'`: Record a new score that is the sum of the previous two scores.
- `'D'`: Record a new score that is double the previous score.
- `'C'`: Invalidate the previous score, removing it from the record.

Return the sum of all scores on the record after applying all the operations.

**Example 1:**
Input: ops = ["5", "2", "C", "D", "+"]
Output: 30

**Example 2:**
Input: ops = ["1", "2", "+", "C", "5", "D"]
Output: 18

**Constraints:**
- 1 <= operations.length <= 1000
- operations[i] is "C", "D", "+", or a string representing an integer in the
  range [-30,000, 30,000].
- For "+" there will always be at least two previous scores on the record.
- For "D" and "C" there will always be at least one previous score on the record.

## Approach

Used a stack to maintain the history of valid scores. Iterated through each
operation and handled four cases: for a number, convert and push it onto the
stack; for `'D'`, peek at the top of the stack, double it, and push; for `'+'`,
peek at the top two elements, sum them, and push; for `'C'`, pop the top element
to invalidate it. After all operations are processed, the answer is the sum of
all remaining elements on the stack.

The stack naturally models the game record because each operation depends on
the most recently recorded scores, which are always accessible at the top.

## Complexity

| | Complexity |
|---|---|
| Time | O(n) — each operation is processed exactly once |
| Space | O(n) — in the worst case, all operations are integers and are stored on the stack |

## What I Learned

- A stack is ideal when operations depend on the most recent elements, since
  the top always gives instant access to the latest values.
- For the `'+'` operation, both top elements are needed simultaneously — this
  requires either temporarily popping and re-pushing, or indexing from the top
  using negative indices (e.g. `stack[-1]` and `stack[-2]` in Python).
- All input values are strings, so numeric entries must be explicitly converted
  to integers before being pushed onto the stack.
- The final answer is just the sum of whatever remains on the stack — no
  separate accumulator is needed if you sum at the end.