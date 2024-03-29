A Trie is a special form of a Nary tree. Typically, a trie is used to store strings. 
Each Trie node represents a string (a prefix). Each node might have several children nodes while the paths to 
different children nodes represent different characters. And the strings the child nodes represent will be the 
origin string represented by the node itself plus the character on the path.



                                                        EmptyNode


                                        Node 'a'         Node 'b'          Node 's'
                                         
                                   Node 'am'         Node 'be'                 Node 'se'

                                                  Node 'bee'                          Node 'see'


It is worth noting that the root node is associated with the empty string.

One important property of Trie is that all the descendants of a node have a common prefix of the string 
associated with that node. That's why Trie is also called prefix tree.

here are several other data structures, like balanced trees and hash tables, which give us the possibility to search
for a word in a dataset of strings. Then why do we need trie? Although hash table has O(1)O(1) time complexity for
looking for a key, it is not efficient in the following operations :

Finding all keys with a common prefix.
Enumerating a dataset of strings in lexicographical order.
Another reason why trie outperforms hash table, is that as hash table increases in size, there are lots of hash 
collisions and the search time complexity could deteriorate to O(n)O(n), where nn is the number of keys inserted.
Trie could use less space compared to Hash Table when storing many keys with the same prefix. In this case using
trie has only O(m)O(m) time complexity, where mm is the key length. Searching for a key in a balanced tree
costs O(m \log n)O(mlogn) time complexity.