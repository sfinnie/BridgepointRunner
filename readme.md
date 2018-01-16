# BridgePoint Windows Runner

A ludicrously simple wrapper for running [BridgePoint](https://xtuml.org/) on Windows.  There's nothing fancy here: it just calls the standard `Launcher.bat`.  But, as a native binary, it can be pinned to the taskbar and shows the BridgePoint icon.

Tested on Windows 7 only.

## To Use

1. Copy `BridgePoint.exe` to your BridgePoint installation directory, e.g. `C:\programs\xtuml\BridgePoint_5.5.0`.  This directory should also contain the file `bp.ico`
1. Double click `BridgePoint.exe` to run.

## To modify or rebuild

Built with VisualStudio 2017.  It's a standard C# console app so no reason it shouldn't work with other editors/IDEs.  Again, not tested with anything else.

There's only one source file: [Program.cs](BridgepointRunner/Program.cs).



