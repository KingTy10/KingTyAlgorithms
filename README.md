# KingTyAlgorithms

Algo_Example is a bunch of algorithm methods, which in order are O(n), O(n^2), and O(1).
Going by method name, the reason GetPow is O(n) is because the Loop runs 'powNum' times, aka O(powNum).
Multiplication inside the loop is O(1), so total = O(powNum).
Has dup is O(n^2). Outer loop: O(n). Inner loop: O(n) in the worst case. Total worst-case time complexity: O(n * n) = O(n^2)
getFirstElement is O(1) /O(1). Getting a single element from an array does not depend on the array size, so it takes the same time regardless of how big it is. 



This C# console application demonstrates the Fisher–Yates Shuffle algorithm by reading a list of items from an external text file, shuffling them randomly, and displaying both the original and shuffled orders. The program first checks if the file exists, then reads each line into a list and prints the original order. It then performs the Fisher–Yates Shuffle by starting from the end of the list and moving backward, selecting a random index for each position and swapping the two elements. This process ensures that every item has an equal chance of ending up in any position, creating an unbiased and truly random shuffle. Finally, the shuffled order is displayed, showing the difference between the original and randomized lists. The program demonstrates concepts such as file input, loops, randomization, generic methods, and basic error handling while showing a clear understanding of how the Fisher–Yates algorithm works.




This project is a console-based implementation of the Tower of Hanoi in C#, called Tower of Despair. It allows users to play the classic puzzle manually or watch it being solved automatically using two different solvers. The puzzle consists of three towers and a number of rings of different sizes, initially stacked on the first tower. The player or solver must move all rings to the last tower, one at a time, following the rules: only the top ring can be moved, and a larger ring cannot be placed on top of a smaller one.

The project demonstrates key data structures and algorithms. A generic linked list serves as the foundation for both the stack and queue implementations. The StackOfAnguish<T> class models the towers, enforcing the rule that only the top ring can be moved, while the QueueOfDOOM<T> class is used for a queue-based auto-solver that processes precomputed moves. A recursive, smart auto-solver also solves the puzzle in the minimal number of moves, updating the towers at each step. This project provides a hands-on exploration of linked lists, stacks, queues, and recursion in C# while offering a visual and interactive way to experience the Tower of Hanoi.
