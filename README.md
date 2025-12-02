# KingTyAlgorithms

Algo_Example is a bunch of algorithm methods, which in order are O(n), O(n^2), and O(1).
Going by method name, the reason GetPow is O(n) is because the Loop runs 'powNum' times, aka O(powNum).
Multiplication inside the loop is O(1), so total = O(powNum).
Has dup is O(n^2). Outer loop: O(n). Inner loop: O(n) in the worst case. Total worst-case time complexity: O(n * n) = O(n^2)
getFirstElement is O(1) /O(1). Getting a single element from an array does not depend on the array size, so it takes the same time regardless of how big it is. 



This C# console application demonstrates the Fisher–Yates Shuffle algorithm by reading a list of items from an external text file, shuffling them randomly, and displaying both the original and shuffled orders. The program first checks if the file exists, then reads each line into a list and prints the original order. It then performs the Fisher–Yates Shuffle by starting from the end of the list and moving backward, selecting a random index for each position and swapping the two elements. This process ensures that every item has an equal chance of ending up in any position, creating an unbiased and truly random shuffle. Finally, the shuffled order is displayed, showing the difference between the original and randomized lists. The program demonstrates concepts such as file input, loops, randomization, generic methods, and basic error handling while showing a clear understanding of how the Fisher–Yates algorithm works.




This project is a console-based implementation of the Tower of Hanoi in C#, called Tower of Despair. It allows users to play the classic puzzle manually or watch it being solved automatically using two different solvers. The puzzle consists of three towers and a number of rings of different sizes, initially stacked on the first tower. The player or solver must move all rings to the last tower, one at a time, following the rules: only the top ring can be moved, and a larger ring cannot be placed on top of a smaller one.

The project demonstrates key data structures and algorithms. A generic linked list serves as the foundation for both the stack and queue implementations. The StackOfAnguish<T> class models the towers, enforcing the rule that only the top ring can be moved, while the QueueOfDOOM<T> class is used for a queue-based auto-solver that processes precomputed moves. A recursive, smart auto-solver also solves the puzzle in the minimal number of moves, updating the towers at each step. This project provides a hands-on exploration of linked lists, stacks, queues, and recursion in C# while offering a visual and interactive way to experience the Tower of Hanoi.

This project demonstrates the use of several fundamental data structures in C#, including arrays, dictionaries (maps), stacks, and queues, using a dataset read from an external text file. The program stores the same data in an array and a dictionary to compare sequential indexed access versus key-based lookups, highlighting how arrays are efficient for fixed-size, ordered collections while dictionaries excel at fast searches by unique keys. The data is also added to a stack and a queue to show different processing orders: stacks use Last-In-First-Out (LIFO), making them useful for undo operations or parsing tasks, while queues use First-In-First-Out (FIFO), which is ideal for task scheduling or processing items in the order they arrive. By implementing and comparing these structures, the project illustrates how different data storage and retrieval methods affect efficiency and functionality, helping to understand when to use each structure in practical programming scenarios.


Sorting is a bunch of well sort algorithms ranging from quick to merge sorts i tried to be more effeicnet while coding since i made more class so i will probably update this soemtime soon to make it more neater espeicaly with the Ulitily class etc and the interface which i tried to implement in the last second here is an explaination of all the sorts etc etc. 

" Bubble Sort"
Bubble Sort repeatedly compares adjacent elements and swaps them if they’re in the wrong order, “bubbling” the largest values to the end each pass. It’s simple to implement but inefficient for large arrays with O(n²) time complexity. Use it mainly for small or nearly sorted datasets, or when learning the basics of sorting.

" Selection Sort"
Selection Sort repeatedly finds the smallest (or largest) element in the unsorted part of the array and moves it to its correct position. It performs fewer swaps than Bubble Sort but still has O(n²) time complexity. It’s useful when memory writes are expensive, and the dataset is small.

"Insertion Sort"
Insertion Sort builds a sorted section of the array one element at a time by inserting each new element into its correct position. It’s efficient for small or nearly sorted arrays, with O(n²) worst-case time but O(n) best-case time. It’s simple and adaptive, often used in hybrid sorting algorithms.

"Merge Sort"
Merge Sort is a divide-and-conquer algorithm that recursively splits the array in half, sorts each half, and merges them. It guarantees O(n log n) time and is stable, but requires extra memory for merging. It’s good for large datasets or when stability is needed.

"Heap Sort"
Heap Sort uses a binary heap to repeatedly extract the largest element and move it to the end, maintaining a max-heap. It sorts in-place with O(n log n) guaranteed, but is not stable. It’s useful for large datasets when you need predictable performance and minimal extra memory.

"Quick Sort"
Quick Sort is a divide-and-conquer algorithm that selects a pivot, partitions the array around it, and recursively sorts the partitions. It’s very fast on average (O(n log n)) and in-place, but worst-case is O(n²) if pivot choices are poor. It’s widely used in practice for large datasets where memory efficiency matters.

A prioty queue is a queue where each element is associated with a priority. Unlike a traditional queue where it first in first out, elements are dequeued (removed) based on their priority, not their order of arrival.

This is what is in the SearchingAlgo folder YIPPEEEE 
1.Linear Search 
What it is:
Linear search checks each element one-by-one from start to finish until it finds the target.
How it works:
It loops through the list and compares the current element to the target.
When to use it:
Use linear search with unsorted data, very small lists, or when you don’t care about speed.
It’s the simplest and most reliable when the data is not sorted.

2. Binary Search
What it is:
Binary search repeatedly cuts the sorted list in half and decides whether to search left or right.
How it works:
It checks the middle element; if the target is smaller, it searches the left half, otherwise the right half.
When to use it:
Use binary search when the list is sorted and you need fast performance — it’s very efficient for large datasets.

3. Interpolation Search
What it is:
Interpolation search is like binary search but estimates where the value might be based on its range, instead of always checking the middle.
How it works:
It uses the data’s numeric distribution to “guess” a closer position to the target, making it faster for evenly spaced numbers.
When to use it:
Use interpolation search on sorted lists with evenly distributed values, like IDs, test scores, or ranges without large gaps.
