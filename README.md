# Unity-DynEnum
A simple Unity extension to allow modification of Enums for ease of game creation.


To use: 

1. Add files to Unity.
2. Create a new C# script (name not important, as it will be erased).
3. Create a new GameObject, and add the DynEnumBase.cs component to it.
4. Drag your new C# script into the TEXT_OBJECT space.
  IMPORTANT: This file WILL be erased and rewritten. Anything in this selected file is subject to data loss! I am not liable; you have been warned.
5. Begin creating your Enums!




Tips:

I have added simple Tooltips to things, but I will explain more here also.

* You can add an encapsulating class for your Enums bu changing the contents of the "Class Name" string.
* Toggling the 'UPDATE' boolean will not show a visible effect. That is because it is functioning as a rudimentary button. You will see a dialog in the console to know it is working.
* Expanding things will cause duplication in the inspector. Just remove any unwanted Elements via resizing and renaming. This cannot be fixed without a custom inspector, which I may consider if I get enough desire for one. For now.. it's a feature!
* I made this surely for myself to use. If you find any issues with it, don't hesitate to create a Pull Request or file an Issue. I will see what I can do.
