# Exercises in F
**Full Documentation can be found under the ReflectingPortfolio.pdf**

# Towers of Hanoi1

White a function in F# that works out the minimum amount of moves needed to solve the towers of Hanoi (given ‘n’ amount of disks). This should make use of 2 n -1

# Towers of Hanoi2

Write a recursive function in F# that attempts to solve the puzzle by stating the list of moves required. For example:

    Move disc from peg x to peg y
    Move disc from peg x to peg z
    e.t.c.

# Euclid’s Algorithm

Given the solution to Euclid’s algorithm for finding the greatest common divisor.

    Function euclidAlgorithm
    Inputs x and y
    If y is 0 then
    Return x
    Else
    Return euclidAlgorithm (y, the remainder when x/y)

Define a recursive function that uses the algorithm to find the greatest common divisor between two numbers of type int. Using your recursively defined function, find the greatest common divisor between 270 and 192.

# Merge Sort
Create a program that sorts the lines of a given textfile(provided via a program argument) using the Merge sort algorithm.
