# Autocompleter
A simple autocompleter program created for the Epitech "Open Job Day".

## Compilation instructions
To compile the program, you should have **.NET 7.0 Runtime** and **.NET** installed. In case you don't, you can download them [here](https://dotnet.microsoft.com/es-es/download).

You can check if you installed it correctly or you already had it running the following command in the terminal:
```bash
dotnet --version
```

Once you have everything set up, you can compile the program running the following command in the terminal:
```bash
dotnet publish -c Release --self-contained
```
**IMPORTANT:** You should always run this command in the folder you have the repository installed.

## Run instructions
To run the compiled program, you have to find the path to it. Normally, it will be in **bin/Release/net7.0/The name of your OS**, named Autocompleter. Once you know the path to the program, you should run the following command in the terminal:
```bash
./bin/Release/net7.0/The name of your OS/Autocompleter
```

**IMPORTANT:** You should **always** give it an argument, if not, it will throw an **error**. 
*Example:*
```bash
./bin/Release/net7.0/osx-arm64/Autocompleter p
```
*(In this case, **p** is the argument and the program is being run on Mac OSX).*
