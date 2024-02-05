# File Management Exercise One

## Overview

This C# program, encapsulated within the `FileManagementExerciseOne` namespace, demonstrates basic file management operations using the `System.IO` namespace. The program creates a text file named "MyText.txt," writes some sample content to it, reads the content back, and displays it on the console.

## Usage

1. **Download/Clone the Repository:**
   - Ensure that you have a C# development environment installed, such as Visual Studio or Visual Studio Code.
   - Download or clone the repository containing the C# file.

2. **Open the Project:**
   - Open the project in your preferred C# development environment.

3. **Build the Project:**
   - Build the project to compile the code.

4. **Run the Program:**
   - Execute the program by running the compiled executable.

5. **View Console Output:**
   - The program will create the file "MyText.txt" in the project directory (or specified path).
   - It will then display the content of the file on the console.

## Code Structure

- **Namespace: `FileManagementExerciseOne`**
  - Contains the entire program.

- **Class: `Program`**
  - **Main Method:**
    - Entry point of the program.
    - Defines a file path (`filePath`) for "MyText.txt."

  - **Try-Catch Block:**
    - Ensures proper exception handling.

  - **File Operations:**
    - Checks if the file already exists and deletes it if it does.
    - Creates a new text file and writes sample content using `StreamWriter`.
    - Reads the content of the file using `StreamReader` and prints it to the console.

## File Operations

- **File Creation:**
  - Creates a text file named "MyText.txt."
  - Writes the following content:
    ```
    Here is the content:
    Just some random words
    Since this is an exercise, the content
    is not that important
    The text file will be named MyText.txt
    ```

- **File Reading:**
  - Opens the created file.
  - Reads and displays the content line by line on the console.

## Exception Handling

- Catches and handles any exceptions that may occur during file operations, printing the exception details to the console.

## Note

- Ensure that the program has the necessary file permissions to create, delete, and read files in the specified directory.
