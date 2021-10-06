In this article, we introduce another paradigm called backtracking, which is also often implemented in the form of recursion.

Backtracking is a general algorithm for finding all (or some) solutions to some computational problems
(notably Constraint satisfaction problems or CSPs), which incrementally builds candidates to the solution and abandons a 
candidate ("backtracks") as soon as it determines that the candidate cannot lead to a valid solution.

Conceptually, one can imagine the procedure of backtracking as the tree traversal. Starting from the root node, one sets out 
to search for solutions that are located at the leaf nodes. Each intermediate node represents a partial candidate solution that 
could potentially lead us to a final valid solution. At each node, we would fan out to move one step further to the final solution,
i.e. we iterate the child nodes of the current node. Once we can determine if a certain node cannot possibly lead to a valid solution, 
we abandon the current node and backtrack to its parent node to explore other possibilities. It is due to this backtracking behaviour, 
the backtracking algorithms are often much faster than the brute-force search [2] algorithm, since it eliminates many unnecessary exploration.


Let's try to understand the concept of backtracking by a very basic example. We are given a set of words represented in the form of a tree.
The tree is formed such that every branch ends in a word.


																A

															N        I

														T    D     M     R

													ANT     AND  AIM    AIR


Our task is to find out if a given word is present in the tree. Let's say we have to search for the word AIM. A very brute way would be to 
go down all the paths, find out the word corresponding to a branch and compare it with what you are searching for. You will keep doing this 
unless you have found out the word you were looking for.

In the diagram above our brute approach made us go down the path for ANT and AND before it finally found the right branch for the word AIM.

The backtracking way of solving this problem would stop going down a path when the path doesn't seem right. When we say the path doesn't 
seem right we mean we come across a node which will never lead to the right result. As we come across such node we back-track. 
That is go back to the previous node and take the next step.


