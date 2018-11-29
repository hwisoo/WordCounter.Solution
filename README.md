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

* Clone Repository
* Move into WordCounter/Models/ directory
* compile main program file using command line 'mcs WordCounter.cs'
* run program using command line 'mono WordCounter.exe'


## Known Bugs

no known bugs

## Support and contact details

_James Cho - hwisoocho@gmail.com or visit my Github at https://github.com/hwisoo_

## Technologies Used

C#, MSTest, .NET Core

### License

*MIT License*

Copyright (c) 2018 **_James Cho_**