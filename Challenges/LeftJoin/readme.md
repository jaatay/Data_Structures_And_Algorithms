# Hash Set Left Join

## Challenge
This challenge was to take a input of two hash sets, and join them to the left. That means the key value pairs of the left set would remain intact, and the values from the right set are added to the key of the left set. For example:

Set 1.        Set2.
cat: bat,     cat: rat,
dog: fog      dog, frog

Result:
cat: bat, rat
dog: fog, frog

## Visuals

The pseudocode to do this is:

![whiteboard image](../../Assets/HashLeftJoin.jpg)

##How to use
To view the program, the user requires Visual Studio. Once in the solution, run the program.cs file to see the result. The program takes the input of two hash sets into an algorithm. The first set is added to a hash table. The second set is then added to the hash table. What happens is the same index values will hash to the same key, where the value for the second table will be "joined" by including the value with the key in table 1.

##Licensing
This project is MIT licensed.

##Acknowledgments 
jcnly for the pseudo pic.
