# Fix for BetterMiniMap (and other Minimap Mods)

Since the original mod developers are currently unresponsive and updates have ceased, I have found a solution for the recent issues plaguing minimap mods.

## ⚠️ The Issue
A new update has caused an issue for many minimap mods. The function previously named `currentVehicle` was renamed to `CurrentVehicle` (capitalized) in the game code. 

Any mod that does not have a failsafe (like an if/jump statement to default to player position) will fail to track the character's movement if it relies on the old function name.

---

## 🛠️ Prerequisites
To fix this, you will need a C# Decompiler/IL Editor.

1.  **Download DnSpy:** This tool is archived but easily accessible via a GitHub search.
2.  **Version:** Download the latest **x64 bit release** (usually found on the right-hand side of the GitHub releases page).
3.  **Install:** Extract the release and run the `.exe` file.

> **❗ Important:** Before proceeding, ensure the game/application is shut down. **Make a backup copy** of your `BetterMiniMap.dll` in a safe folder before editing.

---

## 📝 Step-by-Step Guide

### 1. Load the Assembly
Open DnSpy. Drag and drop the `BetterMiniMap.dll` into the **Assembly Explorer** pane on the left-hand side.

![Assembly Explorer](https://i.ibb.co/h1Z1HC5j/image.png)

### 2. Locate the Function
Navigate through the dropdown menu to find the update logic:
`BetterMiniMap` > `BetterMiniMap.dll` > `BetterMiniMap` > `MiniMapHandler` > **`Update Minimap`** (highlighted in orange).

![Update Minimap Function](https://i.ibb.co/99mg3qhJ/image.png)

### 3. Find the Variable
Double-click the file to open the code view on the right. Scroll down until you see `currentVehicle` (around **Line 51**).

![Line 51 Code View](https://i.ibb.co/S73HF27n/image.png)

### 4. Edit IL Instructions
Right-click on that line of code and select **Edit IL Instructions**.

![Edit IL Instructions](https://i.ibb.co/39qC4rK7/image.png)

### 5. Modify the Member Reference
Look for Index **#200** and **#208** on the left. On the right side, you will see `get_currentVehicl...`.

![IL Indices](https://i.ibb.co/zV9QRc1d/image.png)

Click on the orange `get_currentVehicl...` text. A menu will appear; select **Method MemberRef**.

![Method MemberRef](https://i.ibb.co/GDV2SrS/image.png)

### 6. Capitalize the Name
A dialog menu will appear showing the Name: `get_currentVehicle`.

Change the lowercase
