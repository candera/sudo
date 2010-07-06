sudo - A very simple sudo for Windows.

Craig Andera (candera@wangdera.com)

I like to use the keyboard, not the mouse, and it's a pain to right-click stuff all the time to run it elevated. So I wrote this. To use it, you just drop sudo.exe in your PATH somewhere, and then do stuff like this: 

 sudo notepad C:\windows\system32\drivers\etc\hosts
 
or

 sudo explorer .
 
And sudo will run whatever command is specified after asking for elevation. 