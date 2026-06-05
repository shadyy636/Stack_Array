# 📚 Stack Data Structure Implementation (Array-Based)

A foundational data structure project implementing a custom **Stack** from scratch using fixed-size arrays in **C#**. This project demonstrates an understanding of low-level memory handling, LIFO (Last-In, First-Out) operations, index pointer manipulation, and static simulation testing via the Console.

---

## 🚀 Features & Implementation Highlights

This project maps out the fundamental operations of a Stack using primitive structures:

* **Fixed-Size Array Buffer:** Manages data storage through an internal integer array (`dataArray`), mimicking manual memory slot allocation.
* **State Management Pointers:** Tracks the top of the stack dynamically using an integer pointer (`top`), allowing direct control over elements.
* **Boundary Validation Checks:** Contains logic modules to check stack states (`IsEmpty` and `IsFull`) to monitor capacity.
* **Full Stack Visualization:** Includes a custom `Display()` traversal loop that prints the active elements of the stack in correct top-to-bottom sequence.
* **Memory Reset Utility:** Features a `Clear()` mechanism that instantly resets the stack pointer to its initial baseline state.

---

## 🛠️ Stack Architecture & Mechanics

The project implements the standard operations that define a LIFO stack architecture:

* **Push(int data):** Checks storage availability and pushes a new item onto the stack by incrementing the tracking pointer.
* **Pop():** Removes and displays the element currently at the peak of the stack, then decrements the index pointer.
* **Peek():** Looks at the highest active element in the data buffer without removing it or altering the structure.



---

## 💻 Tech Stack & Environment
* **Language:** C# (.NET)
* **Data Structure:** Stack (Array-Based)
* **IDE:** Microsoft Visual Studio

---

## ⚙️ How to Run & Explore

1. **Clone the Repository:**
   ```bash
   git clone [https://github.com/shadyy636/StackArray.git](https://github.com/shadyy636/StackArray.git)
