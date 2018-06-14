# Linked List Merge

## Challenge
This challenge was to merge 2 linked lists together, in alternating order. The method inputs 2 seperate lists as arguments. 2 reference nodes are established to hold the Current.Next values, and the Current values then alternate between list 1 and list 2. In the event either list is shorter, whichever list is longer will be appended to the shorter list. At the end the return type is a Node, pointing to the list 1 head.
Example:
Linked List 1
	Head 10 --> 8 --> 6 --> 4 --> 2 --> null
Linked List 2
	Head 9--> 7 --> 5 --> 3 --> 1 --> null

Merged List Result
Head 10-->9-->8-->7-->6-->5-->4-->3-->2-->1-->null


## Solution
![List merge whiteboard 1](../../Assets/LLMerge1.jpg)
![List merge whiteboard 2](../../Assets/LLMerge2.jpg)
