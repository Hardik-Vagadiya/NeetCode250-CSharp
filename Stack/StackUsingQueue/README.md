# Implement Stack Using Queues

**Difficulty:** Easy
**Category:** Stack
**NeetCode Link:** https://neetcode.io/problems/implement-stack-using-queues/question?list=neetcode250
**LeetCode Link:** https://leetcode.com/problems/implement-stack-using-queues/

## Problem

Implement a last-in-first-out (LIFO) stack using only two queues. The implemented
stack should support all the functions of a normal stack:

- `push(x)`: Pushes element x to the top of the stack.
- `pop()`: Removes the element on the top of the stack and returns it.
- `top()`: Returns the element on the top of the stack.
- `empty()`: Returns true if the stack is empty, false otherwise.

You must use only standard queue operations — push to back, peek/pop from front,
size, and is empty.

**Example 1:**
Input: ["MyStack", "push", "push", "top", "pop", "empty"]
        [[], [1], [2], [], [], []]
Output: [null, null, null, 2, 2, false]

**Constraints:**
- 1 <= x <= 9
- At most 100 calls will be made to push, pop, top, and empty.
- All calls to pop and top are valid (stack will not be empty).

## Approach

Used a single queue to simulate stack behavior. On every `push`, the new element
is enqueued at the back. Then all previously existing elements (queue size minus
one) are dequeued from the front and re-enqueued to the back. This rotates the
queue so that the most recently added element ends up at the front, making it the
first to be dequeued — exactly matching LIFO behavior.

`pop` and `top` then simply dequeue or peek from the front of the queue, and
`empty` checks if the queue has no elements.

The key insight is to do the extra work at `push` time so that `pop` and `top`
remain O(1).

## Complexity

| Operation | Time | Space |
|---|---|---|
| push | O(n) — rotates all existing elements | O(1) |
| pop | O(1) | O(1) |
| top | O(1) | O(1) |
| empty | O(1) | O(1) |
| Overall Space | — | O(n) |

## What I Learned

- A queue is FIFO and a stack is LIFO — to bridge them, the ordering of elements
  must be reversed on every push so the newest element is always at the front.
- The rotation trick (re-enqueue all old elements after pushing the new one)
  achieves this with a single queue, eliminating the need for a second queue.
- Two-queue approach is also valid: push the new element into the empty second
  queue, move all elements from the first queue into it, then swap. Both
  approaches result in O(n) push and O(1) pop.