# FizzBuzz

This repo contains an implementation of the FizzBuzz solution.
The main components of the solution are:
1. **FizzBuzzConsoleApp** - an example console app that uses the calculation function and prints out the results (default to upper boundry of 100).
2. **FizzBuzzLib** - a class libraray containing the actual calculation fundtion so we could reference it in other projects.
3. **FizzBuzz.Tests** - tests project.

In addition, it also contains GitHub Actions workflow for building and creating a new release each time a commit is made on the master branch.

## How to use

Go to releases, and download the zip for the current release.

A test app with the default mapping dictionary can be run using FizzBuzzConsoleApp.exe
If you want to use the calculation function in a different app you can reference FizzBuzzLib.dll in your project.
