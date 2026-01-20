# 📅 Day 1 – Linked List (C#)

## 🚀 Topic Start
Linked List is a linear data structure where elements (nodes) are stored in non-contiguous memory locations.
Each node contains:
- Data
- Reference (pointer) to the next or previous node

This topic focuses on understanding different types of linked lists and their real-world applications.

---

## 📚 Theory Learned
- Difference between arrays and linked lists
- Node structure and memory allocation
- Types of Linked Lists:
  - Singly Linked List
  - Doubly Linked List
  - Circular Linked List
- Traversal, insertion, deletion, and searching
- Advantages and disadvantages of linked lists

---

## 🧠 What I Learned
- How pointers/references work internally
- How to dynamically grow data structures
- How different linked list types solve different problems
- How circular structures avoid null references

---

## ✨ New Things Learned
- Circular Linked List for Round Robin scheduling
- Doubly Linked List for Undo/Redo functionality
- Using linked lists for real-world systems like:
  - Student management
  - Library systems
  - Social media connections

---

## 🏆 What I Achieved
- Implemented all major types of linked lists in C#
- Built scenario-based applications
- Gained strong confidence in pointer-based data structures
- Improved problem-solving using custom data structures

---

## 🧾 Conclusion
Linked Lists provide flexibility in memory usage and dynamic data handling.
Understanding them builds a strong foundation for advanced data structures like trees and graphs.

# 📅 Day 2 – Stack & Queue (C#)

## 🚀 Topic Start
Stack and Queue are linear data structures used to manage data based on order of processing.

- Stack → LIFO (Last In First Out)
- Queue → FIFO (First In First Out)

These structures are widely used in system-level and real-world applications.

---

## 📚 Theory Learned
### Stack
- Push, Pop, Peek operations
- Function call stack
- Recursion handling

### Queue
- Enqueue, Dequeue operations
- Task scheduling
- Buffer management

---

## 🧠 What I Learned
- How stacks manage function execution
- Why queues are used in scheduling systems
- Difference between stack and queue use cases
- How data flow changes based on access rules

---

## ✨ New Things Learned
- Implementing queue using stack logic
- Sliding window technique using queue
- Using stack for undo/redo and expression problems

---

## 🏆 What I Achieved
- Solved multiple stack and queue problems
- Understood internal working instead of using built-in classes
- Improved logical thinking for sequential processing

---

## 🧾 Conclusion
Stack and Queue simplify complex flow control problems.
They are essential for understanding recursion, scheduling, and system design.


# 📅 Day 3 – Dictionary & HashSet (C#)

## 🚀 Topic Start
Dictionary and HashSet are hash-based data structures designed for fast access and efficient lookups.

They are essential for optimizing performance in large-scale applications.

---

## 📚 Theory Learned
### Dictionary
- Stores data as Key-Value pairs
- Fast retrieval using hashing
- Used for mapping and frequency counting

### HashSet
- Stores unique values only
- No duplicate elements
- Fast membership checking

---

## 🧠 What I Learned
- Why hashing provides O(1) average time complexity
- When to use Dictionary vs HashSet
- How collisions are handled internally

---

## ✨ New Things Learned
- Solving frequency-based problems efficiently
- Removing duplicates using HashSet
- Optimizing solutions by replacing loops with hash structures

---

## 🏆 What I Achieved
- Improved performance-focused thinking
- Reduced time complexity of multiple problems
- Learned how real-world applications handle fast searches

---

## 🧾 Conclusion
Hash-based data structures are crucial for writing efficient and scalable code.
Mastering them improves both coding speed and solution quality.


# 📅 Day 4 – Sorting Algorithms (C#)

## 🚀 Topic Start
Sorting is the process of arranging data in a specific order (ascending or descending).
It plays a critical role in searching, optimization, and data analysis.

---

## 📚 Theory Learned
### Comparison-Based Sorting
- Bubble Sort
- Selection Sort
- Insertion Sort
- Merge Sort
- Quick Sort
- Heap Sort

### Non-Comparison Sorting
- Counting Sort

---

## 🧠 What I Learned
- Time and space complexity of each algorithm
- Difference between stable and unstable sorting
- When to use recursive vs iterative sorting
- Importance of divide and conquer approach

---

## ✨ New Things Learned
- Counting Sort for limited-range data
- Heap-based sorting using binary heap
- Practical performance difference between O(n²) and O(n log n)

---

## 🏆 What I Achieved
- Implemented all major sorting algorithms in C#
- Learned algorithm optimization techniques
- Built real-world sorting examples (marks, salary, products, ages)

---

## 🧾 Conclusion
Sorting algorithms form the backbone of efficient data processing.
Understanding them deeply improves algorithmic thinking and interview readiness.


# 📅 Day 5 – Scenario-Based Problem Solving (C#)

## 🚀 Topic Start
Scenario-based problem solving focuses on applying data structures and algorithms to real-world situations.
Instead of solving abstract problems, this approach emphasizes:
- Business logic
- Constraints
- Optimization goals
- Decision-making under real conditions

This day is dedicated to understanding **how algorithms behave in practical scenarios**.

---

## 📚 Theory Learned
- Translating real-world problems into algorithmic models
- Identifying optimization goals (revenue, waste, efficiency)
- Applying Dynamic Programming concepts (Rod Cutting Problem)
- Understanding trade-offs when constraints are introduced
- Comparing optimized vs non-optimized strategies

---

## 🧠 What I Learned
- How the same algorithm behaves differently under different constraints
- Importance of defining the objective clearly (maximize revenue, minimize waste)
- How scenario changes affect algorithm output
- How to reason about business impact, not just correct output

---

## 🏭 Story 1: Metal Factory Pipe Cutting

### 📌 Context
A metal factory cuts long metal pipes into smaller pieces.
Each cut length has a predefined price, and the goal is to **maximize total revenue**.

---

### 🔹 Scenario A: Optimal Revenue Cutting
**Problem**
- Given a rod of length `8`
- Provided a price chart for different lengths
- Find the best way to cut the rod to get maximum revenue

**Learning Outcome**
- Classic Rod Cutting problem
- Importance of trying all possible cut combinations
- Dynamic Programming provides optimal solution

---

### 🔹 Scenario B: Custom-Length Order Impact
**Problem**
- A customer requests a custom-length piece
- Check how this affects the total revenue

**Learning Outcome**
- Adding new constraints can change the optimal solution
- Custom orders may reduce or increase overall profit
- Business logic must adapt dynamically

---

### 🔹 Scenario C: Non-Optimized Cutting Visualization
**Problem**
- Calculate revenue if cuts are made randomly or greedily
- Compare with optimized strategy

**Learning Outcome**
- Demonstrates revenue loss due to poor strategy
- Highlights importance of optimization algorithms
- Visual comparison improves understanding

---

## 🪵 Story 2: Custom Furniture Manufacturing

### 📌 Context
A carpenter cuts wooden rods to create furniture components.
Prices depend on the size of each piece.

---

### 🔹 Scenario A: Best Cut for 12ft Rod
**Problem**
- Given a 12ft wooden rod
- Determine cuts that maximize total earnings

**Learning Outcome**
- Applying rod cutting logic to a new domain
- Reinforces reusability of algorithms

---

### 🔹 Scenario B: Fixed Waste Constraint
**Problem**
- Customer allows only limited waste
- Modify cutting logic to respect waste constraint

**Learning Outcome**
- Balancing optimization with constraints
- Sometimes maximum revenue is not the best solution
- Real-world problems require compromise

---

### 🔹 Scenario C: Revenue + Minimal Waste Optimization
**Problem**
- Suggest cuts that:
  - Maximize revenue
  - Minimize leftover waste

**Learning Outcome**
- Multi-objective optimization
- Practical decision-making over pure mathematics
- Understanding customer satisfaction vs profit

---

## ✨ New Things Learned
- Modeling real-world constraints into algorithms
- Impact analysis of decision changes
- How optimization problems appear in manufacturing
- Difference between theoretical best and practical best solutions

---

## 🏆 What I Achieved
- Solved multiple real-world optimization scenarios
- Applied Dynamic Programming in business problems
- Improved logical and analytical thinking
- Learned to explain algorithmic decisions clearly

---

## 🧾 Conclusion
Scenario-based problems bridge the gap between theory and real-world applications.
They strengthen problem-solving skills by introducing constraints, trade-offs, and business impact.
This approach builds confidence for real projects, system design, and interviews.


# 📅 Day 6 – Scenario Based Projects (C#)

## 🚀 Topic Start
Day 6 focuses on building **real-world scenario-based projects** using C#.
These projects mimic real applications where data structures, logic, design patterns,
and user needs intersect — not just algorithmic puzzles.

Two major applications were implemented:
1. **Movie Scheduler**
2. **BookBuddy**

Both are end-to-end console or desktop applications that solve practical problems.

---

## 🎬 Project 1: Movie Scheduler

### 📌 Context
A *Movie Scheduler* system manages movie showtimes, theaters, booking slots, and scheduling conflicts.
It aims to help a small cinema manage:
- Available movies
- Showtimes
- Scheduling without overlaps
- Efficient utilization of screens

---

### 📚 Theory Learned
This project reinforces:
- Date/Time handling in C#
- Scheduling logic to avoid overlapping time slots
- Object-oriented modeling of entities (Movie, Screen, Show)
- Collections management using lists, dictionaries, and sorting

---

### 🧠 What I Learned
- How to map real entities into classes
- How to handle temporal constraints (start, end times)
- Designing a simple but functional scheduler
- Keeping collections organized and efficient

---

### ✨ New Things Learned
- Handling scheduling conflicts and conflict resolution
- Time-based sorting and prioritization
- How user choices can dynamically update available slots
- Using C# events and delegates (if implemented)

---

### 🎯 What I Achieved
- Built a working Movie Scheduler application
- Applied data structure logic to a real-world scheduling problem
- Debugged edge cases (overlaps, incorrect user input, invalid times)
- Practiced clean project structure

---

### 🧾 Conclusion
Movie Scheduler combines business logic with algorithmic thinking.
It demonstrates how to model and solve real application requirements beyond abstract coding problems.

---

## 📚 Project 2: BookBuddy

### 📌 Context
A *BookBuddy* system manages a library of books, users, borrowing/returning logic, and tracking.
This project simulates:
- List of available books
- Borrowed books tracking
- User constraints (max books at a time)
- Due dates and fine calculation

---

### 📚 Theory Learned
This application taught:
- CRUD operations in console programs
- Collections and hashing for unique tracking
- Mapping users to books
- Handling date calculations (borrowed vs returned)

---

### 🧠 What I Learned
- How to design persistent logic (even without a database)
- Emulating library workflows
- Handling user input validation
- Structuring larger codebases into modules

---

### ✨ New Things Learned
- Real life constraints (e.g., max books per user)
- Using `Dictionary<TKey, TValue>` for tracking
- Date and time manipulations for borrow durations
- Designing user flows

---

### 🎯 What I Achieved
- Implemented a complete library management experience
- Learned how to track relationshipsBetween entities (User ↔ Book)
- Improved UI/UX in pure console environments
- Gained confidence in building complete applications

---

## 🏆 Overall Day 6 Summary

| Project | Focus | Skills Practiced |
|--------|--------|-------------------|
| Movie Scheduler | Scheduling & Time | Classes, Lists, Sorting, Time |
| BookBuddy | Management System | Collections, Dictionary, Business Logic |

---

## 🧾 Day 6 Conclusion
Day 6 elevates DSA learning to application building.
Rather than solving isolated problems, you create systems that could be shipped in real environments.
This solidifies both technical and design skills essential for software engineering roles.


# 📅 Day 7 – Runtime Algorithm Comparison (C#)

## 🚀 Topic Start
Day 7 focuses on analyzing and comparing the **runtime performance of common algorithms** in C#.
The goal is to understand how **time complexity impacts execution time, scalability, and efficiency**
when algorithms are applied to real data sizes.

This day emphasizes **measurement over theory**, using actual runtime execution to validate
Big-O concepts.

---

## 📚 Theory Learned
- Time Complexity and its impact on performance
- Difference between theoretical complexity and real execution time
- Scalability behavior of algorithms
- Cost of recursion vs iteration
- Memory and performance trade-offs in C#

---

## 🧪 Algorithms & Problems Covered

### 🔍 Searching Algorithms

| Algorithm        | Time Complexity |
|------------------|-----------------|
| Linear Search    | O(N)            |
| Binary Search    | O(log N)        |

**Observation**
- Binary Search is significantly faster for large, sorted datasets
- Sorting once and using Binary Search is optimal for repeated searches

---

### 🔄 Sorting Algorithms

| Algorithm        | Time Complexity |
|------------------|-----------------|
| Bubble Sort      | O(N²)           |
| Selection Sort   | O(N²)           |
| Insertion Sort   | O(N²)           |
| Merge Sort       | O(N log N)      |
| Quick Sort       | O(N log N)      |
| Heap Sort        | O(N log N)      |

**Observation**
- Bubble Sort becomes impractical as input size grows
- Merge Sort and Quick Sort scale efficiently for large datasets

---

### 🧵 String Concatenation Performance

| Method           | Time Complexity |
|------------------|-----------------|
| `string`         | O(N²)           |
| `StringBuilder` | O(N)            |

**Observation**
- `StringBuilder` is far more efficient for repeated string operations
- Immutable strings create performance overhead

---

### 📂 File Reading Performance

| Method         | Best Use Case              |
|---------------|----------------------------|
| StreamReader  | Text-based files           |
| FileStream    | Large or binary files      |

**Observation**
- FileStream performs better for large files
- Choosing the correct IO method improves performance significantly

---

### 🔁 Fibonacci Computation

| Approach   | Time Complexity |
|-----------|-----------------|
| Recursive | O(2ⁿ)           |
| Iterative | O(N)            |

**Observation**
- Recursive Fibonacci becomes infeasible for large values of N
- Iterative approach is efficient and scalable

---

## ⏱ Runtime Measurement
- Execution time measured in milliseconds
- Used `Stopwatch` / `DateTime`
- Tested with small and large input sizes
- Compared execution behavior under different workloads

---

## 🧠 What I Learned
- Big-O notation directly reflects real execution behavior
- O(N log N) algorithms scale far better than O(N²)
- Recursive solutions can be extremely expensive without optimization
- Measuring performance is essential, not optional

---

## ✨ New Things Learned
- Practical impact of algorithm selection
- Why immutability affects performance
- How IO choice impacts execution time
- Importance of benchmarking over assumptions

---

## 🏆 What I Achieved
- Compared multiple algorithms using real runtime data
- Built strong intuition for performance optimization
- Improved ability to choose the right algorithm and data structure
- Strengthened interview and real-world problem-solving skills

---

## 🛠 Technologies Used
- Language: C#
- Concepts: DSA, Time Complexity, Performance Analysis
- Tools: .NET Console Application

---

## 🧾 Conclusion
Efficient algorithms dramatically reduce execution time and resource usage.
Understanding runtime complexity and validating it through measurement
is essential for building scalable, high-performance applications.
Day 7 reinforces the importance of **thinking beyond correctness and focusing on efficiency**.


---

## 📅 January 15, 2026 – Day 8  
### 🎯 Topics Covered
- Browser Tab Management System
- Tab navigation and lifecycle handling
- Browser functionality simulation using DSA concepts

---

### 🏗️ Scenario-Based Project  
## 🌐 Browser Buddy System

A console-based browser simulation that focuses on **tab management and navigation control**, similar to a real web browser.

---

### 🧪 Tab Management Features
- Create new browser tabs
- Switch between active tabs
- Close existing tabs
- Track tab navigation history

---

### 🧪 Browser Functionality
- URL navigation handling
- Active tab management
- Tab organization logic
- Navigation history tracking

---

### 🧪 Menu System
- Interactive console-based UI
- Tab operations menu
- Navigation controls
- Display current browser status

---

### 🔧 Technical Highlights
- Stack-based tab history handling
- Browser state management
- Tab switching and lifecycle control
- Menu-driven application design

---

### 🏆 What I Achieved
- Built a real-world browser tab simulation
- Applied Stack concepts practically
- Strengthened state and history management logic

---

### 📌 Conclusion
Day 8 demonstrated how **stack-based structures** power real applications like browser tab navigation and history handling.

---

## 📅 January 16, 2026 – Day 9  
### 🎯 Topics Covered
- Traffic Management System
- Queue-based vehicle processing
- Circular traffic flow simulation

---

### 🏗️ Scenario-Based Project  
## 🚦 Traffic Management System

A real-world traffic simulation system using **Queue** and **circular flow logic** to manage vehicles at a roundabout.

---

### 🧪 Vehicle Class
- Vehicle identification
- Vehicle type and attributes

---

### 🧪 VehicleQueue Class
- FIFO (First In First Out) vehicle processing
- Enqueue and dequeue operations
- Queue manipulation methods

---

### 🧪 Roundabout Class
- Circular traffic pattern simulation
- Vehicle entry and exit handling
- Continuous traffic flow control

---

### 🧪 TrafficManager Class
- Core traffic coordination logic
- Queue-to-roundabout integration
- Traffic flow optimization

---

### 🧪 Menu Class
- Interactive console-based UI
- Add vehicles
- Process traffic
- Display traffic status

---

### 🔧 Technical Highlights
- Queue data structure implementation
- Circular data flow simulation
- Real-time state updates
- Clean separation of responsibilities

---

### 🏆 What I Achieved
- Simulated real-world traffic flow using DSA
- Applied Queue concepts effectively
- Built a scalable, menu-driven system

---

### 📌 Conclusion
Day 9 reinforced how **queues and circular structures** are essential for managing real-time systems like traffic control.

---

## 📅 January 17, 2026 – Day 10  
### 🏗️ Scenario-Based Projects

---

## 🏋️ Fitness Application  
### ✅ Implemented: User Management & Leaderboard System

---

### 🧪 User Management Features
- User profile creation and management
- Activity tracking
- Performance monitoring

---

### 🧪 Leaderboard Features
- User ranking system
- Performance comparison
- Achievement tracking

---

## 🛍️ Flash Dealz Application  
### ✅ Implemented: Product Management & Sorting System

---

### 🧪 Product Management Features
- Product catalog management
- Price tracking and updates
- Product information storage

---

### 🧪 Sorting Features
- Sort products by price
- Sort products by name
- Sort products by availability
- Custom sorting logic

---

### 🔧 Technical Highlights
- User data management
- Leaderboard ranking logic
- Sorting algorithm application
- Menu-driven interaction

---

### 🏆 What I Achieved
- Built multiple business-oriented applications
- Applied sorting algorithms in real scenarios
- Improved data organization and comparison logic

---

### 📌 Conclusion
Day 10 showed how **DSA directly supports real business use cases**, from fitness tracking to e-commerce sorting.

---

## 📅 January 20, 2026 – Day 11  
### 🏗️ Scenario-Based Project  
## 🔐 Password Cracker Simulator

---

### 📖 Problem Brief
**Story:**  
Simulate a vault password cracking process by trying all possible combinations.

---

### 🧪 Scenario A – Generate All Strings
- Generate all possible strings of length `n`
- Explore the complete password search space
- Combinatorial string generation

---

### 🧪 Scenario B – Early Termination
- Stop execution once password is matched
- Optimize brute-force approach
- Reduce unnecessary computations

---

### 🧪 Scenario C – Complexity Analysis
- Visualize exponential growth
- Compare execution time for different lengths
- Analyze time and space complexity

---

### 🔧 Technical Highlights
- Recursive and iterative string generation
- Early exit optimization
- Brute-force simulation
- Algorithm performance analysis

---

### 🏆 What I Achieved
- Understood exponential time complexity practically
- Built a complete brute-force simulation
- Learned why optimization is critical

---

### 📌 Conclusion
Day 11 provided deep insight into **brute-force algorithms, exponential growth, and performance limits**, strengthening algorithmic thinking.
