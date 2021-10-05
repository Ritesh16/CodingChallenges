One of the classic examples of the divide-and-conquer algorithm is the merge sort algorithm [1]. Merge sort is an efficient and general-purpose sorting algorithm. 

 
Intuition
There are two approaches to implement the merge sort algorithm: top down or bottom up. Here, we will explain the top down approach as it can be implemented naturally using recursion.

The merge sort algorithm can be divided into three steps, like all divide-and-conquer algorithms:

Divide the given unsorted list into several sublists.  (Divide)
 
Sort each of the sublists recursively.  (Conquer)
 
Merge the sorted sublists to produce new sorted list.  (Combine)
 
Top-down Approach
Let us look at a concrete example to see how the top-down merge sort algorithm works. As shown in the figure below,
we are given an unordered list with 8 elements. The task is to sort the list in ascending order. 



Fig.1  Top-down Merge Sort

 

In the first step, we divide the list into two sublists.  (Divide)
 
Then in the next step, we recursively sort the sublists in the previous step.  (Conquer)
 
Finally we merge the sorted sublists in the above step repeatedly to obtain the final list of sorted elements.  (Combine)
 

The recursion in step (2) would reach the base case where the input list is either empty or contains a single element 
(see the nodes in blue from the above figure).

Now, we have reduced the problem down to a merge problem, which is much simpler to solve. Merging two sorted lists can be done
in linear time complexity {O(N)}O(N), where {N}N is the total lengths of the two lists to merge.

Bottom-up Approach
In the bottom up approach, we divide the list into sublists of a single element at the beginning. Each of the sublists is then sorted already. 
Then from this point on, we merge the sublists two at a time until a single list remains.

We illustrate how the bottom up approach works in the below figure. The bottom up approach can be implemented iteratively. 
Try to implement it yourself! We have an exercise that you can practice following this article.