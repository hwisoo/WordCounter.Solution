# _Word_Counter_

#### _C# Word Counter using C#, MSTest and .NET Core Nov 2018_

#### By _**James Cho**_

## Description

A C# program, that takes a word and a sentence from user input and then checks how frequently the word appears in the sentence. It checks for full word matches only. (For instance, if provided the word "cat" and sentence "I'm walking to the cathedral." the first three letters of the word cathedral would not be counted.).

## Specifications
  * The program gathers a word from user input.
    - App : "Please enter a word"
    - Example User Input : ["cat"]
   
  * The program gathers a sentence from user input.
    - App : "Please enter a sentence"
    - Example User Input : ["The cat likes cat food"]

  * The program converts the sentence into an array of words.
    - Example Sentence : ["The cat likes cat food"]
    - Example Array : ["The", "cat", "likes", "cat", "food"]
  
  * The program loops through the array and checks for matches.
    - Example Array : ["The", "cat", "likes", "cat", "food"]
    - Result: Array index[1] and [2] matches the word. There are two matches.

  * The program outputs a message with the matching word count.
    - Example Output : ["The word 'cat' appears '2' times in the sentence."]


## Setup/Installation Requirements

Download .NET Core 2.1.3 SDK and .NET Core Runtime 2.0.9 and install them. Download Mono and install it.

* Clone this repository: $ git clone https://github.com/hwisoo/csharp-WordCounter.Solution.git
* Change into the work directory:: $ cd WordCounter.Solution
To edit the project, open the project in your preferred text editor.

* To run the program, first navigate to the location of the WordCounter.cs file then compile and execute: $ cd WordCounter/Models $ mcs WordCounter.cs; mono WordCounter.exe;

* To run the tests, use these commands: $ cd WordCounter.Tests $ dotnet test



## Known Bugs

no known bugs

## Support and contact details

_James Cho - hwisoocho@gmail.com or visit my Github at https://github.com/hwisoo_

## Technologies Used

C#, MSTest, .NET Core

### License

*MIT License*

Copyright (c) 2018 **_James Cho_**