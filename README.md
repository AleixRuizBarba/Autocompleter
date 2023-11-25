# Autocompleter
A simple autocompleter program created for the Epitech "Open Job Day".

## Compilation instructions
To compile the program, you should have **.NET 7.0 Runtime** installed. In case you don't, you can download it [here](https://dotnet.microsoft.com/es-es/download).

**IF YOU ARE ON WINDOWS**
Once the download is done, you have to run a series of commands in the terminal to use the command:
```bash
mkdir -p $HOME/dotnet && tar zxf dotnet-runtime-7.0.14-win-x86.exe -C $HOME/dotnet
export DOTNET_ROOT=$HOME/dotnet
export PATH=$PATH:$HOME/dotnet
```
**IF YOU ARE ON LINUX**
In Linux, instead of downloading .NET 7.0 Runtime, you just have to download .NET as a whole. To do it, you have to run a series of commands in the terminal:
```bash
wget https://dot.net/v1/dotnet-install.sh -O dotnet-install.sh
chmod +x ./dotnet-install.sh
./dotnet-install.sh --version latest
```
**IF YOU ARE ON MAC**
Once the download is done, you have to run a series of commands in the terminal to use the command:
```bash
mkdir -p $HOME/dotnet && tar zxf ~/Downloads/dotnet-runtime-7.0.14-osx-arm64.pkg -C $HOME/dotnet
export DOTNET_ROOT=$HOME/dotnet
export PATH=$PATH:$HOME/dotnet
```
**IMPORTANT:** Both Windows and Mac installation commands will only work on the current terminal session. This step must be redone every time you open a new terminal.

You can check if you installed it correctly or you already had it running the following command in the terminal:
```bash
dotnet --version
```

Once you have everything set up, you can compile the program running the following command in the terminal:
```bash
dotnet publish -c Release
```
**IMPORTANT:** You should always run this command in the folder you have the repository installed.

## Run instructions
To run the compiled program, you have to find the path to it. Normally, it will be in **bin/Release/net7.0/**, named Autocompleter. Once you know the path to the program, you should run the following command in the terminal:
```bash
./bin/Release/net7.0/Autocompleter
```

**IMPORTANT:** You should **always** give it an argument, if not, it will throw an **error**. 
*Example:*
```bash
./bin/Release/net7.0/Autocompleter p
```
*(In this case, **p** is the argument).*
