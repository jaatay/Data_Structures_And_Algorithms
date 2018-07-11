# Graph weighted edges challenge

## Challenge
This challenge was to implement a graph in the layout of several cities with flight paths in between. Each route has a price. The goal was to determine, given a starting and ending point, whether the trip could be made, and if so what the overall cost would be to fly there. The graph does so by determining the neighbors of root list, and if the destination is not one of them, the trip cannot be made. Another way to approach the problem with multiple flights would be to input an array value and iterate whether each successive index is a neighbor.

## Visuals

The graph relationship and algorithm visualized in this program looks like the below image:

![Graph image](../Assets/GraphGetEdge.jpg)

##How to use
This is a console app. The only user input could be to adjust the root and destination node values. Currently the program doesn't run, since I tried to implement it using two lists instead of a dictionary, thereby discovering the hype behind dictionaries. If it did work, a user would just have to navigate to the project in Visual Studio and run the program.cs file. 

##Licensing
This project is MIT licensed.
