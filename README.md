# Kangaroo Meeting App

This console application allows you to determine if two kangaroos can meet based on their starting positions and jump rates. It employs the Single Responsibility Principle to keep the code organized and maintainable.

# Requirements

.NET Core SDK

# Usage

1. Clone the repository or download the source code.
2. Open a terminal/command prompt in the project directory.
   
# Running the App

1. Compile and run the app by entering the following commands:
   - dotnet build
   - dotnet run
1. Follow the prompts to enter the starting positions and jump rates of the kangaroos.
2. The app will display whether the kangaroos can meet or not.
   
# Single Responsibility Principle

The app follows the Single Responsibility Principle by separating concerns into different classes:

- UserInterface: Handles user input and output.
- NumberProcessor: Processes the numbers and determines if kangaroos can meet.
- Program: Main entry point that coordinates the interaction between classes.

# How It Works
The app checks if two kangaroos with given starting positions and jump rates can meet at the same spot and time based on their relative positions and jump rates.
# Example
Input:

- Enter starting position of kangaroo 1: 0
- Enter jump rate of kangaroo 1: 3
- Enter starting position of kangaroo 2: 4
- Enter jump rate of kangaroo 2: 2
  
Output:
YES

# License
This project is licensed under the MIT License.
