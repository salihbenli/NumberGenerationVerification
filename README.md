# Code Generator Project

## Overview

This project generates random 8-character codes using a predefined set of characters. It ensures that each code is valid by checking its length and character composition.

## Features

- Generates 1000 random codes.
- Each code consists of 8 characters.
- Allowed characters: `ACDEFGHKLMNPRTXYZ234579`.
- Validates each code based on its length and character composition.
- Outputs the generated code and its validation result to the console.

## Usage

### Prerequisites

- .NET SDK installed on your machine.

### Running the Project

1. Clone the repository or download the source code.
2. Open a terminal/command prompt and navigate to the project directory.
3. Compile and run the project using the following command:
   ```sh
   dotnet run
## Code Explanation
The project contains a single class with the following methods:

1. Main(): Starts the code generation process by calling the GenerateCodes() method.
2. GenerateCodes(): Generates 1000 random 8-character codes and prints them to the console along with their validation results.
3. CheckCode(string code): Checks if the given code is valid by ensuring it is of the correct length and contains only allowed characters.
