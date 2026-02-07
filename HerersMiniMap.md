# Fix for Herer's Minimap (Schedule 1)

With the original minimap developers no longer active, recent updates to *Schedule 1* have broken functionality. I am releasing patches and guides to get these working again on newer versions of the game.

**🔗 GitHub Repository:** [JosiahCSharp/Minimap-Fix-Schedule1](https://github.com/JosiahCSharp/Minimap-Fix-Schedule1/tree/main)

---

## 🛠️ Prerequisites

To apply this fix, you will need **dnSpy v6.1.8 (64-bit)**.
* **Download:** Search for the specific version on GitHub or use the latest 64-bit release.
* **Files Needed:**
    * `HererMiniMap.dll` (The mod file)
    * `Il2CppScheduleOne.dll` (Game file, required for reference resolution)

---

## 📝 Step-by-Step Patching Guide

### 1. Load the Assemblies
Open dnSpy and drag both `HererMiniMap.dll` and `Il2CppScheduleOne.dll` into the **Assembly Explorer** on the left.

### 2. Switch to IL View
**Crucial Step:** In the top toolbar, look for the dropdown menu that says **C#**. Click it and select **IL**. If you do not do this, you will not see the specific compiler-generated classes needed for this fix.

### 3. Navigate the Assembly
In the **Assembly Explorer**, follow this exact path:

`HererMiniMap` > `HererMiniMap.dll` > `HererMiniMap` (Yellow) > `MiniMapManager` (Dark Green) > `<UpdateMinimap>d__146` (Light Green)

> *Note: The `<UpdateMinimap>d__146` class is located near the bottom of the list.*

### 4. Edit the MoveNext Method
Inside `<UpdateMinimap>d__146`, double-click on **`MoveNext()`**.

The IL code will appear on the right. Scroll down to lines **99** and **108** (and two other duplicate lines). You are looking for instructions referencing `get_currentVehicle` (highlighted in orange).

![IL Code View](https://github.com/user-attachments/assets/52f70e2d-816a-4e83-b15f-337cd9ec5f09)

### 5. The Fix: Capitalization
The issue is simple: recent game updates renamed the function from `get_currentVehicle` to **`get_CurrentVehicle`**.

1.  Right-click the line containing `get_currentVehicle`.
2.  Select **Edit IL Instructions**.
3.  In the dialog, click the bright orange `get_currentVehicle` text.
4.  Select **Method MemberRef**.
5.  Change the lowercase `c` to an uppercase `C` so it reads: **`get_CurrentVehicle`**.

![Edit IL Instruction](https://github.com/user-attachments/assets/d9c7d4de-5f9e-49ec-b13e-f41f6af53f0e)

**Repeat this process for EVERY instance in the moveNext() function.** (I found 4 instances total that needed patching). --> Functions are purple rectangles in the file tree btw

### 6. Save and Finish
1.  Go to **File** > **Save Module...** or **Save All...**.
2.  Click **OK**.
3.  Replace the old `.dll` in your mods folder with this patched version.

---

## 🔒 Verification
If you want to verify your patched file matches mine, you can check the hash:

> **SHA256 Checksum:**
> `72FE61B911338AAD59ED238D8A81615E4A93D3EB842C461C213A5BC778DF6B1B`

---

## 📸 Proof of Fix
Below are screenshots confirming the minimap works correctly in-game after applying this patch.

![Ingame Proof 1](https://github.com/user-attachments/assets/74635f1d-b366-4ae7-b94c-ed144bfe8227)
![Ingame Proof 2](https://github.com/user-attachments/assets/df404ef0-f42a-469c-b215-14e6f55df809)
