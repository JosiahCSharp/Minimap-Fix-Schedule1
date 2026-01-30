<img width="3690" height="1119" alt="image" src="https://github.com/user-attachments/assets/52f70e2d-816a-4e83-b15f-337cd9ec5f09" />
<img width="704" height="242" alt="image" src="https://github.com/user-attachments/assets/d9c7d4de-5f9e-49ec-b13e-f41f6af53f0e" />
proof that this works:
<img width="2058" height="1822" alt="image" src="https://github.com/user-attachments/assets/74635f1d-b366-4ae7-b94c-ed144bfe8227" />
<img width="2044" height="1582" alt="image" src="https://github.com/user-attachments/assets/df404ef0-f42a-469c-b215-14e6f55df809" />

POST on NexusMods:
Since Minimap developers are falling off the edges of the earth, I am patching these so they work on newer versions of Schedule 1!
My Github: https://github.com/JosiahCSharp/Minimap-Fix-Schedule1/tree/main (Helpful Images on my GitHub Page)

For Herer's Minimap you will need to download and use dnSpy v6.1.8 64-bit off of Github!

Once downloaded, drag and drop the HererMiniMap.dll and the Il2CppScheduleOne.dll file into dnSpy.
Next in the top bar you will se a menu that has C# selected. Click it and choose IL
Now in the "Assembly Explorer" follow this specific dropdown path:
HererMiniMap>HererMiniMap.dll>HererMiniMap(yellow)>MiniMapManager(darkgreen)><UpdateMinimap>d_146 (lightgreen)almost all the way at the end.

If you don't see <UpdateMinimap>d_146 make sure you selected IL in the dropdown menu earlier!

Now double click MoveNext()
Then in the IL code that pops up in the top right hand corner
Scroll down to line (# on left) 99 and 108. These have something called get_currentVehicle (orange)

Problem is in the games code in recent updates get_currentVehicle is now get_CurrentVehicle. Its as simple as that. It needs capitalization.

To do so, right click get_currentVehicle, then Edit IL Instructions.
Left-click the get_currentVehicle (bright orange) and then click Method MemberRef
Change that c to a C!
Press okay, then repeat for EVERY other instance in the file! I found 4 of them myself.

Then go to the top right next to the dnSpy logo and click File>Save Method or Save all... and then click Ok!
Now import your mod and use that minimap!

My Checksum after patching the .dll: 72FE61B911338AAD59ED238D8A81615E4A93D3EB842C461C213A5BC778DF6B1B
