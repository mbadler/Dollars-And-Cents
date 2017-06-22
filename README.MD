# Dollars And Cents

When I was much younger, (back in the IBM PC XT era.) someone gave me a challenge, make a program the prints out the number of possible combinations of coin types that can be used to make change of a dollar. 

Well , there are 100 pennies so that’s 1 and then there’s  4 Quarters so that’s 2 and then there’s 10 Dimes so that 3 etc… Turns out that manually counting them up and adding a Print statement for each was not very efficient and I indeed needed to come up with an algorithm to calculate it. The verdict: There are 242 ways to make change of a dollar using Quarters, Dimes, Nickels and Pennies.

The algorithm is a set of 4 for loops, starting with quarters then an inner loop for Dimes then another loop for nickels and finally the innermost loop for pennies. In the Pennies loop we check to see if the summed values of all of the counters are 100 and we increment the solution count if it is so.

I wrote the original version on a IBM PC XT (which ran at 4.77 MHz) in  BASICA. Calculating the number of results for $1 took about a minute and a half, but calculating the results for $2 took a whooping 15 minutes!
I remember trying to calculate $5 and I let it run overnight – it still had not finished by the time morning had rolled around.
I eventually upgraded to a PS/2 and got much better results, indeed for the $1 scenario, results were nearly instantaneous and the $2 scenario was also much quicker, but as I bumped up the dollar value once again the amount of time to completion grew exponentially. 

What I was witnessing was that this function had a Big O complexity of O( log N) – the higher the value  the more processing time grows exponentially. So turns out that this simple question really turns into a “Hard Problem” with hard to get at answers.

Therefore this little algorithm became my “Hello World” program to all subsequent languages I tried to learn. It allowed me to quickly learn the basic control flow features of the language, but also to gauge the languages execution speed. 

I remember jumping from BASICA to C , and being amazed at the speed at which it retuned results.  A compiled c program on the PS/2 would not even have to blink when asked to spit out the answer for $10, However as I pushed the dollar value higher the processing times started to slow down again and it eventually came to the point where the C program was also running for hours trying to calculate a value.

Upgrading to a 486 brought some relief and some of the dollar amounts that previously would spin forever , were now in reach, but then again as I raised the dollar amount higher even the mighty 486 would begin to stutter. There has to be a better way, We can’t just keep throwing faster compilers and cpu’s at this most important problem. There has to be a better way of writing the code to optimize for computation cycles to speed the results.  We need to be able to provide the answer to this (and other similar) problems as quick as possible, no matter the size of the input.

## The Goal ##

The goal of this repository is to house demonstrations on how to iteratively optimize calculation intensive algorithms in as many languages / platforms as possible using the Dollars and Cents algorithm as a common base problem.

##Requests##

The original commit contains my c# version. I am working currently working on a nodejs version. I have optimized the c# to the best of my ability. However there is certainly room for improvement. Additionally I would love to include as many platforms and languages as possible. So please - if you have the time and or ability (and the interest) , I would be more than happy to accept any pull request that improves / adds to the content

## The C# Version ##

The first commit contains a c# timing harness that runs several versions of the algorithms and prints comparisons.

The following Algorithms are included

| Algorithm Name | Description |
|---|---|
|_01_Base|Base algorithm|
|_02_EarlyExitCents|Exits the cents loop if we have already reached our target value|
|_03_TightLoops|All loops are tightened to never overflow the target amount|
|_04_NoCents|Removes the cents loop|
|_05_NoNickles|Removes the nickels|
|_06_Parallel|Runs the quarters loop in parallel|
|_07_Tasks|Resolves the quarters loop using queued tasks|
|_08_Dynamic|Uses a "Dynamic" recursive approach by ovelaying an array with values|
|_08_Polynomial|Uses a polynomial regression curve to predict the value (with a slight loose of accuracy)

