#Data Structures, Algorithms and Complexity Homework
**1.What is the expected running time of the following C# code?**

The Compute algarithm complexity is n*n.

  * The first loop is going from 0 to n. Inside the first loop we have a second loop.
  * The second loop is going from 0 to n. Which means that on every step from the first loop we have n steps from the second loop.
  * That makes n*n steps.
  * So we have quadratic complexity.

**2.What is the expected running time of the following C# code?**

The complexity of the CalcCount algorithm is n*m. 

  * The first loop is going from 0 to n. We have condition for going into the second loop, which in the worst case is going into it every time.
  * The second loop is going from 0 to m. Which means that  on every step from the first loop, we have m steps from the second loop.
  * That makes n*m steps.
  * So we have quadratic complexity.

**3.What is the expected running time of the following C# code?**

The complexity of CalcSum algorithm is n*m.

  * The loop is going from 0 to n.
  * If the row is 0 at the beginning, we have another m steps to run the 0 to n loop , because of the recursion.
  * So we have quadratic complexity.










