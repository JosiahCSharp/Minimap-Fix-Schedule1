
My post on NexusMods - BetterMiniMap

Since the mod devs wont respond to my DMs on nexus and they don't bother to update their mods I have a solution for you all!
NEW FIX - For any minimap mod a new issue has arisen! the previously named currentVehicle function was renamed to CurrentVehicle in the code. Any mod w/o a if statement/jump to go to the player position incase this didn't show up started not moving the characters position.

To fix this for now you can use an app called DnSpy (C# Decompiler, IL Editor!)
DnSpy is archived but easily accessible on GitHub (searchable via google)
Download the latest x64 bit release (right-hand side, lower part of the webpage) 
Run the .exe file inside of the folder (after you extract the release)

Before you continue, shut down Schedule I, and make a copy of the BetterMiniMap.dll in another folder.

Then drag and drop the BetterMiniMap.dll to the Assembly Explorer on the left hand side!
https://i.ibb.co/h1Z1HC5j/image.png

Next we will navigate to the UpdateMinimap() function!
https://i.ibb.co/99mg3qhJ/image.png

To get there open the drop down menu as follows:
BetterMiniMap>BetterMiniMap.dll>BetterMiniMap>MiniMapHandler>Update Minimap (in orange!)

Double click that file to open it on the right hand side (top)!
Then scroll down until you see currentVehicle (line 51 -> left hand side in blue of the viewer)
https://i.ibb.co/S73HF27n/image.png

Right click that line and select Edit IL Instructions!
https://i.ibb.co/39qC4rK7/image.png

Next look for Index #200 and #208 on the left, if you look to the right you will see get_currentVehicl...
https://i.ibb.co/zV9QRc1d/image.png

Click on the orange get_currentVehicl... text and then "Method MemberRef"
https://i.ibb.co/GDV2SrS/image.png

A dialog menu will popup! Now look at the Name provided: get_currentVehicle
https://i.ibb.co/kVr5LjS5/image.png

Click it and change the "c" to "C" (capitalize it man), then press "Ok".
Repeat for the other one as well.
https://i.ibb.co/3m9B0Fq4/image.png (it should look like this now)

Now press OK at the bottom of the menu with the IL Code!

Now the C# code (before the IL Menu) should show CurrentVehicle and NOT currentVehicle, if it does repeat those steps again CLOSELY.

Lastly, go to the File tab in the top left of the app (next to the logo), then click Save All..., then click OK when the dialog window shows.
https://ibb.co/JFdVC9Sy

Now replace your old .dll with the modified one! Load back up the game, and see if it works (it did for me, I tested it twice!)

FOR OTHER MODS/MINIMAPS: 
Load the dll, if all you see is PE blah blah blah and no branchable functions/classes when you load the .dll then try the 64bit version, otherwise its not worth the time, just use this one (PE Header shows i386 - 32 bit dll)

If you are using a different minimap you can use the search tool in the bottom right of DnSpy to find it!
You can search for "movement" or "vehicle" or "PlayerMovement" string
https://i.ibb.co/qL1T4H3J/image.png

Then right click the entry, click analyze, click the drop down for readby. It will probaby show something like NameOfMod.MiniMapSomething.UpdateMap or a similiar orange colored function. Search that function for "currentVehicle" and follow the above steps I provided.

If this helped you fix your minimap please re-share this with the names of the functions and where you went in the .dll file to find the "currentVehicle" entry and rename it!
