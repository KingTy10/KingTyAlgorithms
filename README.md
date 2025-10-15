# KingTyAlgorithms

Algo_Example is a bunch of algorithm methods, which in order are O(n), O(n^2), and O(1).
Going by method name, the reason GetPow is O(n) is because the Loop runs 'powNum' times, aka O(powNum).
Multiplication inside the loop is O(1), so total = O(powNum).
Has dup is O(n^2). Outer loop: O(n). Inner loop: O(n) in the worst case. Total worst-case time complexity: O(n * n) = O(n^2)
getFirstElement is O(1) /O(1). Getting a single element from an array does not depend on the array size, so it takes the same time regardless of how big it is. 



This C# console application demonstrates the Fisher–Yates Shuffle algorithm by reading a list of items from an external text file, shuffling them randomly, and displaying both the original and shuffled orders. The program first checks if the file exists, then reads each line into a list and prints the original order. It then performs the Fisher–Yates Shuffle by starting from the end of the list and moving backward, selecting a random index for each position and swapping the two elements. This process ensures that every item has an equal chance of ending up in any position, creating an unbiased and truly random shuffle. Finally, the shuffled order is displayed, showing the difference between the original and randomized lists. The program demonstrates concepts such as file input, loops, randomization, generic methods, and basic error handling while showing a clear understanding of how the Fisher–Yates algorithm works.
