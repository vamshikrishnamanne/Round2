isPrime():
In the first function to find whether the number is prime or not, we will test all divisors from 2 to n-1. 
If the number is divisible by any of the divisor, the function will return False, else True. 
Following are the steps followed in this method: 
-> If the integer is less than equal to 1, it returns False.
-> If the given number is divisible by any of the numbers from 2 to n, the function will return False
-> Else it will return True 
 isPrime() is a simple approach but takes a lot of time to execute.

isPrimeConsideringSqrt():
The approach used for this method is factorization below the line and factorization above the line in reverse order.
 The square root of the integer is the line that divides the elements into two half. We can shift the line by 1 if the number is a perfect square, and we can extract the integer value of the line that divides if the number is a perfect square.
W e calculate an integer, which is the square root of the number and get its floor value . In isprime() we iterate from 2 to n-1. But in this, we reduce the divisors by half. 
Following are the steps used in this method: 
-> If the integer is less than equal to 1, it returns False.
-> Check the squareroot of the given number.
-> If the given number is divisible by any of the numbers from 2 to the square root of the number, the function will return False
-> Else it will return True.
isPrimeConsideringSqrt() makes a huge difference in the runtime of the code execution when compared with that of isPrime()


isPrimeConsideringSqrtEliminatingEvenNumbers():
In this method, we eliminate all the even numbers except 2 to optimize the code and will check only the odd divisors.
Following are the steps used in this method: 
-> This method returns false, if the integer is than or equal to 1.
-> It will return True, if the number is equal to 2.
-> And if the number is greater than 2 and divisble by 2, it will return False.
->So far, we have checked all the even numbers. Now, lets look for the odd numbers.
->If the given number is divisible by any of the numbers from 3 to the square root of the number skipping all the even numbers, the function will return False
->Else it will return True.


