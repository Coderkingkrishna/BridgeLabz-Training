# 📘 C# Collections, Advanced Concepts & Testing – Practice 

This branch focuses on **C# Collections, Advanced Language Features, and Testing** using
**hands-on, scenario-based problem solving**.
Each day builds practical understanding through real-world inspired programs.

---

## 📅 Day 1 – Project Structure & Setup

### 🎯 Topics Covered
- Repository initialization
- Project and folder structuring
- Codebase organization

### 🧠 What I Learned
- Importance of clean project structure
- Separating concerns across modules

### 🏆 Achievement
- Initialized repository with proper folder hierarchy

### 📌 Conclusion
A strong structure is essential for scalable development.

---

## 📅 Day 2 – Smart Checkout System (Collections – Scenario Based)

### 🎯 Topics Covered
- Queue
- Map (HashMap)
- Interface-based design

---

### 🏗️ Scenario-Based Project  
## 🛒 Smart Checkout System (Array-Based)

### Features Implemented
- Customer queue management
- Item catalog using hash map
- Checkout flow simulation
- Menu-driven console UI

### Technical Highlights
- FIFO customer processing
- Interface-driven checkout logic
- Real-world checkout simulation

### 🧠 What I Learned
- Combining Queue and Map effectively
- Managing application state using collections

### 🏆 Achievement
- Built a complete checkout system using collections

### 📌 Conclusion
Collections enable efficient handling of real-world workflows.

---

## 📅 Day 3 – List, Queue, Map & Set Problem Solving

### 🎯 Topics Covered
- List interface
- Queue interface
- Map interface
- Set interface

---

### 🧪 Problems Implemented
- Reverse list (ArrayList & LinkedList)
- Remove duplicates from list
- Rotate list
- Nth element from end
- Reverse queue
- Binary number generation using queue
- Hospital triage system
- Word frequency using map
- Set operations (Union, Intersection, Subset, Symmetric Difference)

### 🧠 What I Learned
- Choosing the right collection based on use case
- Set-based logic for uniqueness
- Queue for real-time processing

### 🏆 Achievement
- Solved multiple collection-based problems

### 📌 Conclusion
Mastery of collections simplifies complex data handling.

---

## 📅 Day 4 – File Handling in C#

### 🎯 Topics Covered
- File I/O operations
- Buffered vs unbuffered streams
- Serialization and deserialization

---

### 🧪 Programs Implemented
- File copy using FileStream
- Buffered vs unbuffered comparison
- Read large files
- Word count from file
- Save user input to file
- Employee serialization (binary & JSON)
- Image byte array handling
- Pipe communication

### 🧠 What I Learned
- File performance considerations
- Safe resource handling
- Data persistence techniques

### 🏆 Achievement
- Built multiple real-world file handling utilities

### 📌 Conclusion
File handling is critical for persistence and data processing.

---

## 📅 Day 5 – Exception Handling

### 🎯 Topics Covered
- Exception hierarchy
- Custom exceptions
- Exception propagation

---

### 🧪 Problems Implemented
- Bank transaction exception handling
- Division error handling
- Custom exception creation
- Multiple catch blocks
- Nested try-catch
- Finally block
- Using statement

### 🧠 What I Learned
- Writing fault-tolerant code
- Graceful error handling
- Preventing application crashes

### 🏆 Achievement
- Implemented robust exception handling logic

### 📌 Conclusion
Exception handling improves reliability and user experience.

---

## 📅 Day 6 – Regular Expressions (Regex)

### 🎯 Topics Covered
- Pattern matching
- Validation
- Extraction using Regex

---

### 🧪 Problems Implemented
- Email validation
- Username validation
- IP address validation
- Credit card validation
- SSN validation
- Extract dates, links, prices, languages
- Censor sensitive words
- Replace multiple spaces
- Detect repeating words

### 🧠 What I Learned
- Powerful text processing using Regex
- Validation without complex logic

### 🏆 Achievement
- Solved multiple real-world string problems using Regex

### 📌 Conclusion
Regex simplifies complex string operations efficiently.

---

## 📅 Day 7 – Reflection in C#

### 🎯 Topics Covered
- Runtime type inspection
- Dynamic method invocation

---

### 🧪 Problems Implemented
- Class metadata inspection
- Access private fields and methods
- Dynamic object creation
- Method execution timing
- JSON generation using reflection
- Object mapping

### 🧠 What I Learned
- How C# inspects types at runtime
- Dynamic behavior without compile-time knowledge

### 🏆 Achievement
- Built reflection-based utilities

### 📌 Conclusion
Reflection enables powerful runtime flexibility.

---

## 📅 Day 8 – Annotations (Attributes)

### 🎯 Topics Covered
- Custom attributes
- Metadata-driven behavior

---

### 🧪 Problems Implemented
- Custom attribute creation
- Logging execution time
- Caching method results
- Role-based access
- Obsolete methods
- Validation using attributes

### 🧠 What I Learned
- Declarative programming using attributes
- Cleaner separation of logic and metadata

### 🏆 Achievement
- Implemented attribute-driven systems

### 📌 Conclusion
Annotations improve code readability and maintainability.

---

## 📅 Day 9 – Unit Testing with NUnit

### 🎯 Topics Covered
- Unit testing fundamentals
- Test-driven validation

---

### 🧪 Tests Implemented
- Calculator tests
- Exception testing
- File handling tests
- List manager tests
- Parameterized tests
- Setup and teardown
- Timeout and performance tests

### 🧠 What I Learned
- Writing reliable and testable code
- Automating validation
- Preventing regressions

### 🏆 Achievement
- Built a complete NUnit test suite

### 📌 Conclusion
Unit testing ensures correctness, stability, and confidence in code.

---
# Day 01 – C# Basics

## 📌 Overview
This day focuses on building a strong foundation in **C# programming** by practicing basic programs and understanding important theoretical concepts such as the history of C#, IL (Intermediate Language), compiler vs interpreter, and differences between Java and C#.

---

## 🧪 Programs Implemented
The following C# programs were implemented to understand basic syntax, data types, and mathematical operations:

1. **Average of Numbers**
2. **Add Two Numbers**
3. **Celsius to Fahrenheit Conversion**
4. **Kilometers to Miles Conversion**
5. **Perimeter of a Rectangle**
6. **Area of a Circle**
7. **Power of a Number**
8. **Simple Interest Calculation**
9. **Volume of a Cylinder**

Each program helps in understanding:
- Input and output handling
- Arithmetic operations
- Use of variables and data types
- Basic formulas in C#

---

## 📘 Theoretical Concepts Learned

### 🔹 History and Evolution of C#
- C# was developed by **Microsoft** in the early 2000s.
- Designed by **Anders Hejlsberg**.
- Part of the **.NET Framework**.
- Object-oriented, modern, and type-safe language.
- Evolved continuously with new features like LINQ, async/await, records, etc.

---

### 🔹 IL (Intermediate Language)
- C# code is not compiled directly into machine code.
- It is first compiled into **IL (Intermediate Language)**.
- IL is executed by the **CLR (Common Language Runtime)**.
- Enables platform independence within the .NET ecosystem.

---

### 🔹 Compiler vs Interpreter

| Compiler | Interpreter |
|--------|-------------|
| Translates entire code at once | Translates code line by line |
| Faster execution | Slower execution |
| Errors shown after compilation | Errors shown one by one |
| Example: C#, C, C++ | Example: Python, JavaScript |

---

### 🔹 Difference Between Java and C#

| Java | C# |
|-----|----|
| Platform-independent via JVM | Platform-independent via CLR |
| Uses JVM | Uses CLR |
| No pointers | Supports pointers (unsafe mode) |
| Checked exceptions | No checked exceptions |
| Slower GUI | Faster Windows-based applications |

---

## 🎯 Key Takeaways
- Learned basic C# syntax and programs
- Understood how C# code is compiled and executed
- Gained clarity on IL, compiler vs interpreter
- Compared Java and C# for better conceptual understanding

---

## ✅ Conclusion
Day 01 helped in building a strong base for C# programming by combining **hands-on coding** with **important theoretical concepts**, setting the stage for advanced topics in upcoming days.

---

# Day 02 – C# Operators & Data Types

## Overview
Day 02 focused on understanding **C# data types**, **operators**, and the purpose of the `static void Main` method, which serves as the entry point of a C# application.

---

## Concepts Covered
- **Data Types**
  - Value types and reference types
  - Common built-in data types (int, float, double, char, bool, string)

- **Operators**
  - Arithmetic operators
  - Relational operators
  - Logical operators
  - Assignment operators

- **static void Main**
  - Entry point of a C# program
  - `static` allows execution without creating an object
  - `void` indicates no return value
  - `Main` is invoked by the CLR at runtime

---

## Tools & Technologies
- Language: C#  
- Framework: .NET  
- Environment: Visual Studio / `csc`

---

## Learning Outcomes
- Gained understanding of C# data types and operators
- Learned how expressions are evaluated
- Understood the role of `static void Main` in program execution

---

## Conclusion
Day 02 strengthened core C# fundamentals by explaining how data is stored, manipulated, and how program execution begins.

---

# Day 03 – Control Flow in C#

## 📌 Overview
This day focuses on mastering **control flow statements** in C#, including conditional statements (if-else, switch), loops (for, while, do-while), and advanced logic for solving mathematical and algorithmic problems.

---

## 🧪 Programs Implemented
The following C# programs were implemented across three levels to understand control flow concepts:

### Level 1: Basic Control Flow
1. **Bonus Calculation** - Calculates employee bonus based on salary and years of service.
2. **Age Checker** - Checks if a person is eligible to vote based on age.
3. **Number Checker** - Determines if a number is positive, negative, or zero.
4. **Countdown** - Prints a countdown from a given number using while loop.
5. **Divisible by Five** - Checks if a number is divisible by 5.
6. **Factorial** - Calculates factorial using while loop.
7. **Factorial with For** - Calculates factorial using for loop.
8. **Largest Number** - Finds the largest among three numbers.
9. **Natural Number Sum** - Sums natural numbers using while loop.
10. **Natural Number Sum with For** - Sums natural numbers using for loop.
11. **Odd or Even** - Checks if a number is odd or even.
12. **Smallest Number** - Finds the smallest among three numbers.
13. **Spring Season** - Checks if a given month is in spring season.
14. **Sum of Numbers** - Sums numbers until a condition is met.
15. **Sum Until Zero** - Sums numbers until zero is entered.
16. **Table** - Prints multiplication table of a number.
17. **For Countdown** - Prints countdown using for loop.

### Level 2: Intermediate Control Flow
1. **Average Marks** - Calculates average of student marks and determines grade.
2. **BMI Calculator** - Calculates Body Mass Index and categorizes health status.
3. **Factors of a Number** - Finds all factors of a given number.
4. **FizzBuzz** - Implements FizzBuzz logic using for loop.
5. **FizzBuzz with While** - Implements FizzBuzz logic using while loop.
6. **Greatest Factor** - Finds the greatest factor of a number.
7. **Leap Year** - Checks if a year is a leap year.
8. **Number Division** - Performs division and handles exceptions.
9. **Power Calculation** - Calculates power of a number.
10. **Prime Number** - Checks if a number is prime.

### Level 3: Advanced Control Flow
1. **Abundant Number** - Checks if a number is abundant (sum of proper divisors > number).
2. **Armstrong Number** - Checks if a number is an Armstrong number.
3. **Calculator** - Implements a simple calculator with switch statement.
4. **Count Digits** - Counts the number of digits in a number.
5. **Day of the Week** - Determines the day of the week based on number input.
6. **Harshad Number** - Checks if a number is a Harshad number (divisible by sum of digits).

Each program demonstrates:
- Use of if-else statements for decision making
- Loops (for, while, do-while) for iteration
- Switch statements for multiple choices
- Nested conditions and loops
- Mathematical logic and algorithms

---

## 📘 Theoretical Concepts Learned

### 🔹 Control Flow Statements
- **Conditional Statements**: if, if-else, nested if, switch
- **Loops**: for, while, do-while, break, continue
- **Decision Making**: Based on conditions and user input

### 🔹 Loop Control
- **Initialization**: Setting initial values
- **Condition**: When to continue the loop
- **Increment/Decrement**: Updating loop variables

### 🔹 Switch Statement
- Alternative to multiple if-else
- Uses cases and default
- Efficient for fixed value comparisons

---

## 🎯 Key Takeaways
- Mastered conditional logic for decision-making in programs
- Understood different types of loops and their applications
- Learned to implement algorithms using control flow
- Gained experience in debugging loop-based programs
- Applied mathematical concepts through programming

---

## ✅ Conclusion
Day 03 enhanced understanding of control flow in C# by implementing a variety of programs that utilize conditional statements and loops, preparing for more complex programming challenges in upcoming days.

---

# Day 04 – Arrays in C#

## 📌 Overview
This day focuses on understanding **arrays** in C#, including single-dimensional arrays, multi-dimensional arrays, array operations, and their applications in solving real-world problems.

---

## 🧪 Programs Implemented
The following C# programs were implemented across two levels to understand array concepts:

### Level 1: Basic Arrays
1. **Array Age** - Stores and displays ages of multiple persons using an array.
2. **Array Check Number** - Checks if a number exists in an array.
3. **Array Table** - Generates multiplication table for a number using an array.
4. **Average of Heights** - Calculates average height from an array of heights.
5. **FizzBuzz Array** - Implements FizzBuzz logic and stores results in an array.
6. **Odd Even Array** - Separates odd and even numbers from an array.
7. **Store Values** - Demonstrates storing and retrieving values from an array.
8. **Table Six to Nine** - Generates multiplication tables for numbers 6 to 9 using arrays.
9. **2D to 1D Array** - Converts a 2D array to a 1D array.

### Level 2: Advanced Arrays
1. **Frequency** - Counts frequency of each element in an array.
2. **Grade Calculation** - Calculates grades based on marks stored in arrays.
3. **Max Elements** - Finds maximum elements in an array.
4. **Max Elements with Loop** - Finds maximum elements using loops.
5. **Multi Persons BMI** - Calculates BMI for multiple persons using arrays.
6. **Persons BMI** - Calculates BMI for persons and stores in arrays.
7. **Reverse Number** - Reverses the digits of a number using arrays.
8. **Salary Calculation** - Calculates salaries and bonuses using arrays.

Each program demonstrates:
- Declaration and initialization of arrays
- Accessing array elements
- Array traversal using loops
- Multi-dimensional arrays
- Array operations (search, sort, manipulate)
- Real-world applications of arrays

---

## 📘 Theoretical Concepts Learned

### 🔹 Arrays in C#
- **Single-dimensional Arrays**: Fixed-size collection of elements of the same type.
- **Multi-dimensional Arrays**: Arrays with multiple dimensions (2D, 3D, etc.).
- **Jagged Arrays**: Arrays of arrays with different sizes.

### 🔹 Array Operations
- **Declaration**: `int[] arr;`
- **Initialization**: `int[] arr = new int[5];`
- **Accessing Elements**: `arr[0]`
- **Length**: `arr.Length`

### 🔹 Array Methods
- **Sort()**: Sorts array elements
- **Reverse()**: Reverses array elements
- **Copy()**: Copies elements from one array to another

---

## 🎯 Key Takeaways
- Learned to declare, initialize, and manipulate arrays
- Understood single and multi-dimensional arrays
- Gained experience in array traversal and operations
- Applied arrays in solving practical problems
- Learned memory management for arrays

---

## ✅ Conclusion
Day 04 built a solid foundation in array handling in C# by implementing programs that cover basic to advanced array operations, setting the stage for data structures and algorithms in upcoming days.

---

# Day 05 – Methods in C#

## 📌 Overview
This day focuses on understanding **methods** in C#, including method declaration, parameters, return types, method overloading, and recursion, along with their applications in modular programming.

---

## 🧪 Programs Implemented
The following C# programs were implemented across three levels to understand method concepts:

### Level 1: Basic Methods
1. **Athlete** - Calculates athlete performance metrics using methods.
2. **Calculate Trigonometric Functions** - Computes trigonometric values using methods.
3. **Chocolate Distribution** - Distributes chocolates using method-based calculations.
4. **Combination of Handshake** - Calculates handshake combinations with methods.
5. **Number Check** - Checks number properties using methods.
6. **Number of Handshake** - Calculates handshake possibilities with methods.
7. **Quotient and Remainder** - Computes quotient and remainder using methods.
8. **Simple Interest Function** - Calculates simple interest using methods.
9. **Smallest and Largest** - Finds smallest and largest numbers using methods.
10. **Spring Season** - Checks spring season using methods.
11. **Sum of Loop** - Calculates sum using loop-based methods.
12. **Wind Chill** - Calculates wind chill factor using methods.

### Level 2: Intermediate Methods
1. **BMI Calculator** - Calculates BMI using methods with parameters.
2. **Factors of Number** - Finds factors using method-based approach.
3. **Info** - Displays information using methods.
4. **Leap Year Check** - Checks leap year using methods.
5. **Number Analysis** - Analyzes numbers using methods.
6. **Quadratic** - Solves quadratic equations using methods.
7. **Random Number Analysis** - Analyzes random numbers with methods.
8. **Student Vote Checker** - Checks voting eligibility using methods.
9. **Sum of Natural Numbers** - Calculates sum using recursive methods.
10. **Unit Convert** - Performs unit conversions using methods.
11. **Unit Converter** - Advanced unit conversion with methods.

### Level 3: Advanced Methods
1. **Collinear Points** - Checks if points are collinear using methods.
2. **Employee Bonus** - Calculates employee bonuses using methods.
3. **Football Team Height** - Analyzes team heights with methods.
4. **Line and Distance** - Calculates line distances using methods.
5. **Number Checker** - Advanced number checking with methods.
6. **Number Checker 2** - Extended number checking functionality.
7. **Number Checker 3** - Further number checking methods.
8. **Number Checker 4** - Comprehensive number checking.
9. **OTP Generator** - Generates OTP using methods.
10. **Student Score Card** - Manages student scores with methods.

Each program demonstrates:
- Method declaration and definition
- Parameter passing (value and reference)
- Return types and void methods
- Method overloading
- Recursive methods
- Modular code organization
- Code reusability

---

## 📘 Theoretical Concepts Learned

### 🔹 Methods in C#
- **Method Declaration**: `returnType MethodName(parameters)`
- **Parameters**: Value parameters, reference parameters, output parameters
- **Return Types**: void, int, string, etc.
- **Method Overloading**: Same name, different signatures
- **Recursion**: Method calling itself

### 🔹 Method Types
- **Static Methods**: Called without object creation
- **Instance Methods**: Called on object instances
- **Void Methods**: No return value
- **Parameterized Methods**: Accept input parameters

### 🔹 Best Practices
- Use meaningful method names
- Keep methods focused on single responsibility
- Use parameters for input, return for output
- Document methods with comments

---

## 🎯 Key Takeaways
- Learned to create and use methods for code organization
- Understood parameter passing and return values
- Gained experience in method overloading and recursion
- Applied methods in solving complex problems
- Learned modular programming principles

---

## ✅ Conclusion
Day 05 enhanced understanding of methods in C# by implementing programs that demonstrate method declaration, parameters, return types, and recursion, preparing for object-oriented programming concepts in upcoming days.

---
# 📅 Day 06 – C# Strings & Built-in Functions

## 📌 Overview
Day 06 focused on working with **C# string operations**, **exception handling basics**, and **built-in functions**, along with practical problem-solving using recursion and utility-based programs.  
This day strengthened understanding of string manipulation, error handling, and reusable logic development.

---

## 🧪 Programs & Modules Implemented

### 🔹 1. String Operations
- String comparison  
- Convert string to uppercase and lowercase  
- Substring creation  
- Splitting words from a string  
- Character extraction from strings  

---

### 🔹 2. Exception Handling Demonstrations
The following runtime exceptions were demonstrated with examples:
- `ArgumentOutOfRangeException`
- `ArrayIndexOutOfRangeException`
- `IndexOutOfRangeException`
- `NullReferenceException`
- `FormatException`

---

### 🔹 3. Date & Time Built-in Functions
- Date formatting  
- Date comparison  
- Date arithmetic (add / subtract days, months, years)  
- Time zone handling  

---

### 🔹 4. Utility & Logic Programs
- Basic Calculator  
- GCD and LCM Calculator  
- Factorial using Recursion  
- Fibonacci Series Generator  
- Prime Number Checker  
- Palindrome Checker  
- Maximum of Three Numbers  
- Number Guessing Game  

---

## 📘 Concepts Covered
- `String` class and string manipulation methods  
- Common runtime exceptions in C#  
- Built-in `DateTime` functions  
- Recursion fundamentals  
- Modular and reusable method design  

---

## 🛠️ Tools & Technologies
- **Language:** C#  
- **Framework:** .NET  
- **Environment:** Visual Studio / `csc` Compiler  
- **Version Control:** Git & GitHub  

---

## 🎯 Learning Outcomes
- Gained hands-on experience with C# string operations  
- Learned how to handle and debug common runtime exceptions  
- Used built-in date and time utilities effectively  
- Strengthened logical thinking using recursion  
- Improved understanding of modular programming  

---

## ✅ Conclusion
Day 06 enhanced practical **C# programming skills** by combining string processing, exception handling, and built-in functions.  
This day prepared a strong base for upcoming **advanced object-oriented and real-world applications**.

---

# 📅 Day 07 – Scenario Based Problem Solving in C#

## 📌 Overview
Day 07 focuses on **scenario-based problem solving** using core **C# fundamentals**.  
The problems are designed to simulate **real-world applications** and strengthen logical thinking, modular programming, and clean coding practices using arrays, strings, loops, conditions, and methods.

---

## 🧪 Scenarios & Programs Implemented

---

## 🎲 1. Snake & Ladder Game (Multi-Player | .NET 6+)

### 🎯 Objective
Build a **console-based Snake & Ladder game** using **.NET 6 or above**, applying fundamental C# concepts such as variables, conditions, loops, collections, and methods.  
The project follows proper programming hygiene and uses **Git/GitHub** for version control.

---

### 🕹️ Game Description
- Board contains **100 cells (1–100)**
- Fixed set of **snakes and ladders**
- Players start at **position 0**
- Dice generates a random number between **1 and 6**
- Player must reach **exactly 100** to win
- If dice roll exceeds 100 → **turn is skipped**

---

### 👥 Multi-Player Rules
- Supports **minimum 2** and **maximum 4 players**
- Players take turns in sequence
- Landing on:
  - 🪜 **Ladder** → moves player upward
  - 🐍 **Snake** → slides player downward
- Each turn displays:
  - Player name
  - Dice value
  - Old position → New position
  - Snake / Ladder message (if applicable)

---

### ⚙️ Technical Requirements

#### ✔ .NET Fundamentals Used
- **Variables & Data Types**  
  (`int`, `string`, `bool`, etc.)

- **Operators**  
  Arithmetic, Assignment, Comparison, Logical

- **Logical Constructs**
  - `if–else`
  - `switch`
  - Ternary operator `(?:)` *(used at least once)*

- **Loops**
  - `for`
  - `while`
  - `do-while`
  - `foreach`  
  *(At least two types implemented)*

- **Jump Statements**
  - `break`
  - `continue`

---

### 🔧 Modular Functions Implemented
- `RollDice()`
- `MovePlayer()`
- `ApplySnakeOrLadder()`

---

## 🌡️ 2. Arrays – Temperature Analyzer

### 🧠 Scenario
You are analyzing a **week’s worth of hourly temperature data**, stored in a **2D array**:


Each row represents a day and each column represents hourly temperature data.

---

### 📌 Problem Requirements
Create methods to:
- Find the **hottest day**
- Find the **coldest day**
- Calculate and return **average temperature for each day**

---

### 💡 Concepts Applied
- 2D Arrays
- Nested loops
- Method-based computation
- Aggregation logic

---

## ✍️ 3. Strings – Sentence Formatter

### 🧠 Scenario
A text editing tool receives **poorly formatted input** from users.  
Your task is to automatically correct the formatting.

---

### 📌 Problem Requirements
Write a method that takes a **paragraph as input** and returns a corrected version with:
- ✔ Exactly **one space after punctuation**
- ✔ **Capital letter** after `.`, `?`, `!`
- ✔ **Trimmed extra spaces**

---

### 💡 Concepts Applied
- `String` class methods
- Character manipulation
- Loop-based parsing
- String formatting logic

---

## 📘 Key Concepts Covered
- Scenario-based problem solving
- Arrays and 2D arrays
- String manipulation techniques
- Game logic implementation
- Conditional statements and loops
- Modular programming with methods
- Clean and readable console output

---

## 🛠️ Tools & Technologies
- **Language:** C#
- **Framework:** .NET 6+
- **Environment:** Visual Studio / `dotnet` CLI
- **Version Control:** Git & GitHub

---

## 🎯 Learning Outcomes
- Built a real-world **multi-player console game**
- Strengthened array and string manipulation skills
- Applied core C# fundamentals in practical scenarios
- Improved problem decomposition using methods
- Gained experience writing clean, modular code

---

## ✅ Conclusion
Day 07 emphasized **real-world scenario-based programming** using C#.  
By building a Snake & Ladder game and solving array and string problems, this day strengthened logical thinking, modular design, and confidence in applying C# fundamentals to practical applications.

---

# 📅 Day 08 – Scenario-Based Problem Solving in C#

## 📌 Overview
Day 08 focused on solving **real-world scenario problems** using C# arrays, string operations, and modular method design.  
The day emphasized building small systems like a **Library Management System** and an **EduQuiz Grader**, strengthening skills in data handling, searching, and feedback generation.

---

## 🧪 Programs & Modules Implemented

### 🔹 1. Library Management System – Book Search & Checkout
**Scenario:** A small library system to manage books and track checkouts.  

**Problem Requirements:**
- Store book details (title, author, status) in an array.  
- Allow searching by partial title using string operations.  
- Methods for:
  - Searching books  
  - Displaying book details  
  - Updating book status (Checked Out / Available)  

---

### 🔹 2. EduQuiz – Student Quiz Grader
**Story:** A grading module for a quiz app where a student answers a 10-question quiz.  

**Problem Requirements:**
- Use two `String[]` arrays: `correctAnswers[]` and `studentAnswers[]`.  
- Implement `calculateScore(String[] correct, String[] student)` to return a score.  
- Case-insensitive comparison using `.EqualsIgnoreCase()`.  
- Print detailed feedback:  
  - Example → `Question 1: Correct / Incorrect`.  
- Bonus: Show percentage score.  

---

## 📘 Concepts Covered
- Arrays for storing structured data  
- String operations for partial search and case-insensitive comparison  
- Modular methods for searching, updating, and grading  
- Feedback generation and score calculation  
- Real-world application of string and array handling  

---

## 🛠️ Tools & Technologies
- **Language:** C#  
- **Framework:** .NET  
- **Environment:** Visual Studio / `csc` Compiler  
- **Version Control:** Git & GitHub  

---

## 🎯 Learning Outcomes
- Learned how to design small systems using arrays and methods  
- Practiced partial string search and case-insensitive comparison  
- Built reusable methods for book management and quiz grading  
- Strengthened logical thinking with structured problem-solving  
- Enhanced ability to provide user feedback in applications  

---

## ✅ Conclusion
Day 08 applied **C# programming concepts** to **real-world scenarios** like library management and quiz grading.  
This day improved skills in **array handling, string operations, and modular design**, preparing for larger **application development projects**.

---
