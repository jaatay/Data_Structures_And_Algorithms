# Array Adjacent Product

## Challenge
AdjacentProduct is a method which takes a 2d array and returns the value of the highest product between 2 adjacent numbers.
ex: [
	[1, 2, 3]
	[4, 5, 6]
	[7, 8, 9]
	]

The highest product returned in the above array would be 72.
![Example image of console output](../../Assets/ArrayAdjacentProductScreenshot.jpg)

## Solution
![Array Adjacent Product](../../Assets/ArrayAdjacentProduct.jpg)

## Explanation
I interpreted the part of the challenge with "arbitrarily" sized arrays to mean any possible combination of arrays. I wanted to design an algorithm that would work in any situation, whether the arrays ended up being different numbers of indexes, invalid values, or uneven disribution. What is then occuring in this solution is a series of 8 calculations for every array index, skipping any out of range exceptions. A running temp score is kept for each index, and replaced with higher scores from any other index. The highest score remaining by the end of the iteration is returned as the final score.

