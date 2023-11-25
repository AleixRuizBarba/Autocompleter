# Autocompleter
A simple autocompleter program created for the Epitech "Open Job Day".

# Compilation instructions
To compile the program, you should have .NET 7.0 Runtime installed. In case you don't, you can download it here:
https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=&cad=rja&uact=8&ved=2ahUKEwiRl4rCpOCCAxXwUaQEHbsHDtUQFnoECBQQAQ&url=https%3A%2F%2Fdotnet.microsoft.com%2Fes-es%2Fdownload&usg=AOvVaw0Im_dPLpNTJ2vSABaocV60&opi=89978449

You can check if you installed it correctly or you already had it running the following command in the terminal:
dotnet --version

Once you have everything set up, you can compile the program running the following command in the terminal:
dotnet publish -c Release

IMPORTANT: You should always run this command in the folder you have the repository installed.

# Run instructions
To run the compiled program, you have to find the path to it. Normally, it will be in bin/Release/net7.0/, named Autocompleter. Once you know the path to the program, you should run the following command in the terminal:
./bin/Release/net7.0/Autocompleter

IMPORTANT: You should always give it an argument, if not, it will throw an error. Example: ./bin/Release/net7.0/Autocompleter p (In this case, p is the argument).
