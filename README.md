TaskBar Analog Clock
===

## Usage

Use the `C:\Windows\Microsoft.NET\Framework64\v4.0.30319\RegAsm.exe`

Register
```
.\RegAsm.exe /codebase C:\Path\To\TaskBarAnalogClock.dll
```

Unregister
```
.\RegAsm.exe /unregister C:\Path\To\TaskBarAnalogClock.dll
```

## Known Issue

Issues with transparency for WPF:  
https://github.com/dsafa/CSDeskBand/wiki#notes

Please set your taskbar color to `TransparencyColorKey` property.

## Libraries

[CSDeskBand](https://github.com/dsafa/CSDeskBand/)
> MIT License  
> Copyright (c) 2017 Brandon Chong  

## License

- [MIT License](https://github.com/cafemoca/TaskBarAnalogClock/blob/master/LICENSE.txt)
