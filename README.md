# Ping Pong

#### In-class Practice Assignment during Epicodus Coding School, Practice with Branching, Looping, & Other Foundational C# Concepts, 12.07.2020

#### By Danielle Thompson & Ben McFarland

## Description

This application will allow a user to play a game of ping-pong in the dotnet terminal. 

A user enters a number and the application returns all numbers from 1 to the user input with the following changes:
All numbers divisible by 3 are replaced by "ping".
All numbers divisible by 5 are replaced by "pong"
All numbers divisible by both 3 and 5 are replaced by "ping-pong".

If the user enters 15, the program will return:

1
2
"ping"
4
"pong"
"ping"
7
8
"ping"
"pong"
11
"ping"
13
14
"ping-pong"

## Technologies used

- C# v 7.3
- .NET Core v 2.2
- dotnet script, REPL

## Installation Requirements

#### Installing Git
###### For Mac Users

- Access Terminal in your Finder, and open a new window. Install the package manager, (Homebrew) [https://brew.sh/], on your device by entering this line of code in Terminal: `$ /usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"`.
- Ensure Homebrew packages are run with this line of code: `echo 'export PATH=/usr/local/bin:$PATH' >> ~/.bash_profile`.
- Once homebrew is installed, install Git, a version control system for code writers, with this line of code `brew install git`.

###### For Windows Users

- Open a new Command Prompt window by typing "Cmd" in your computer's search bar.
- Determine whether you have 32-bit or 64-bit Windows by following these (instructions)[https://support.microsoft.com/en-us/help/13443/windows-which-version-am-i-running].
- Go to (Git Bash)[https://gitforwindows.org/], click on the "Download" button, and download the corresponding exe file from the Git for Windows site._
- Follow the instructions in the set up menu.

#### For Both Mac & Windows systems

- Once you have Git installed on your computer, go to this (GitHub repository)[https://github.com/dani-t-codes/ping-pong], click the "Fork" button in the upper right hand corner of the page, and clone this application with the following command:`git clone https://github.com/dani-t-codes/ping-pong.git`.


#### Installing C#, .NET, dotnet script, & MySQL

* Install C# and .Net according to your operating system below. 

###### For Mac
 * Download this .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer]. Clicking this link will prompt a .pkg file download from Microsoft.
* Open the .pkg file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.
* Confirm the installation is successful by opening your terminal and running the command $ dotnet --version, which should return something like: `2.2.105`. 

###### For Windows (10+)
* Download either the the 64-bit .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer]. Clicking these links will prompt a .exe file download from Microsoft.
* Open the file and follow the steps provided by the installer for your OS.
* Confirm the installation is successful by opening a new Windows PowerShell window and running the command dotnet --version. You should see something a response like this: `2.2.105`.

#### For Mac & Windows Operating Systems
* Install dotnet script with the following terminal command `dotnet tool install -g dotnet-script`.

#### Opening the Project on your Local System
Once the project has been cloned to your computer and you have all the necessary items on your local computer, open the project in the application of your choice ((Visual Code Studio)[https://code.visualstudio.com/] was used and is recommended by the application builder), and run the following...

* Navigate to the project folder on your Terminal or CMD.
* `dotnet build` will get bin/ and obj/ folders downloaded.
* `dotnet run` will run the application. 


### Specs

| Spec                                            | Input                        | Output                        |
| :---------------------------------------------- | :--------------------------- | :---------------------------- |
| **Build list of number**    | User enters: 15 | `1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15` |
| **Changes all numbers divisible by 3 to "ping"** | User enters: 15 | `1, 2, ping, 4, 5, ping, 7, 8, ping, 10, 11, ping, 13, 14, ping`|
| **Changes all numbers divisible by 5 to "pong"**  | User enters: 15 | `1, 2, ping, 4, pong, ping, 7, 8, ping, pong, 11, ping, 13, 14, pong` |
| **Changes all numbers divisible by 3 AND 5 to "ping-pong"** | User enters: 15 | `1, 2, ping, 4, pong, ping, 7, 8, ping, pong, 11, ping, 13, 14, ping-pong` |

### Tests

Describe: buildList(number)
Test: buildList(userInputNumber).toEqual(a list of #'s up to userInputNumber)
Expect: buildList(15).toEqual(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15)

Describe: buildList(3)
Test: buildList(userInputNumber % 3).toEqual(ping replaces all #'s % 3)
Expect: buildList(15).toEqual(1, 2, ping, 4, 5, ping, 7, 8, ping, 10, 11, ping, 13, 14, ping)

Describe: buildList(5)
Test: buildList(userInputNumber % 5).toEqual(pong replaces all #'s % 5)
Expect: buildList(15).toEqual(1, 2, ping, 4, pong, ping, 7, 8, ping, pong, 11, ping, 13, 14, pong)

Describe: buildList(15)
Test: buildList(userInputNumber % 3 && 5).toEqual(ping-pong replaces # % 3 && 5)
Expect: buildList(15).toEqual(1, 2, ping, 4, pong, ping, 7, 8, ping, pong, 11, ping, 13, 14, ping-pong)

## Known bugs

No known bugs as of now. 

### Legal, or License

_MIT_ Copyright (c) 2020 *_Danielle Thompson, Ben McFarland_**
