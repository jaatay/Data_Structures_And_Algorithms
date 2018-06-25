# Binary Tree and Binary Search Tree

## Challenge
This challenge was implementing both a binary tree and a binary search tree. A binary tree is a structure similar to a linked list, with the difference being that each node contains two values for a left and right child, as opposed to a next value. 

## Visuals
![Binary Tree 1](../../Assets/Tree1.jpg)
![Binary Tree 2](../../Assets/Tree2.jpg)
![Binary Tree 3](../../Assets/Tree3.jpg)
![Binary Tree 4](../../Assets/Tree4.jpg)

##Implementation
In order to implement a binary tree, a user has to create an instance of a new binary tree. Once this is done, new nodes can be established and added. Since I did not have a add function in the binary tree, I established the links between the left and right children, which then allowed the methods of sorting to be applied, or a node value to be searched. 

For the binary search tree, the implementation was in first creating an instance of a new binary search tree. The only node that needs to be directly injected is the root node, after which new nodes can be established and added using the in-built Add() method, which puts the node in the appropriate order. A node can also be found via a method similar to the search method for a binary tree, with the primary difference being evaluation of the current node directly, instead of evaluation of the node's left and right children.

##Where Trees are Used
A real world example of where a binary tree would be used is a search application. A binary search tree could be used in a video game 3d rendering, in determining which object models need to be rendered based on the "distance" the user is from them.

##Licensing
This project is MIT licensed.

##Acknowledgements
[jcqnly](https://github.com/jcqnly)
[steph](https://github.com/IndigoShock)

