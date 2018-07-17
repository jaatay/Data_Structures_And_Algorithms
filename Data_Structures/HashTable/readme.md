# Hash Table

## Challenge
This challenge was implementing a Hash Table. A hash table is essentially an array with linked lists of key value pairs. The main difference is that the keys get hashed before storage through an algorithm.

Example algorithm: 

index = (Unicode(key)*599)/60)

The purpose of this is to set the index value for each key/value pair. This helps to ensure that each index is set to a unique key, but not in a linear way. 

## Visuals

Hash table key value pairs:

x: 1, assigned to index 1190
y: 4, assigned to array value 1207
z: 10, assigned to array value 1217


##Implementation
To implement a hash table, one first has to instantiate an instance of the table. Key-value pairs are contained inside of a node class. The hash table operates as a combination of an array and linked list. The first thing that needs to happen is an array needs to be initialized with a certain size.

New nodes can then be added, with the index corresponding to the key when put through the hashing algorithm. Once a node arrives at the index, conditionals can check to see if there is a node already there. If there is, a linked list can be created with the node being added to the head of the list. In this way collisions can be handled, since on a infinite timeline every possibility will occur. No matter how intricate the hashing algorithm, eventually there will be two indexes that hash to the same value. By using a linked list, a hash table can create buckets, or the ability to store multiple nodes at the same index. 

Once the table is created, nodes can then be found by iterating through the array until a index value matches, then iterating through multiple possible indexes until the value searched for is found.

##Where Hash Tables are Used

We used hash tables in our current ECommerce project. C# has a default hashing system, and Identity uses it in storing passwords. You can tell by looking at the data tables in the database, when a user password shows up as a long random combination of strings and integers.

Other uses could just be general data storage. Particularly in an enterprise level operation, where you are receiving lots of input and need a storage system that can handle potential infinite nodes without knowing the overall size. This also includes the condition that the nodes are not necessarily related. A graph would be a better choice if all the data had to be interconnected somehow, but if the data is storing information as objects or key-value pairs, then a hash table is an ideal choice, since it will allow infinite entries as long as collisions are handled properly. This could be something like a user database, or some kind of dynamically gathered analytics data that adds values as soon as some action occurs.

##Licensing
This project is MIT licensed.