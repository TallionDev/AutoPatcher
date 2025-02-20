//EN

/*******************************************************************************************
 * System created by Tallion, 2025
 * 
 * Official website: https://devm2code.com/
 * Discord: talion0127
 * Discord Channel: https://discord.gg/VZgzwacwFD
 * 
 * © Tallion 2025. All rights reserved.
 *******************************************************************************************/

Start AutoPatcher Update


1. Generating Hashes for Client Files
Run SHA256HashApp.exe to generate hashes for all necessary files.
Create a new folder, for example, Metin2ClientHash, and place the client or the files you want to hash inside it.
Save the generated hashes in the patchlist.txt file.

2. Uploading Files to the Server
Once patchlist.txt is generated, upload it to the subdomain https://server.mt.ro/patch/.
Also, upload the client (including all relevant files) to https://server.mt.ro/patch/.

3. Configuring AutoPatcher
Compile the modified AutoPatcher so that it uses the URL https://server.mt.ro/patch/ to verify and download updates.
Once compiled, place Autopatcher.exe in the client folder.


How to Properly Create the AutoPatcher Folder
1️⃣ Create a new folder named → Autopatcher
2️⃣ Add the following files and folders inside:

📂 Autopatcher/ (main folder)

├── Autopatcher.exe       // Patching executable
├── config.exe            // Client configuration
├── locale.cfg            // Language settings
├── metin2.cfg            // Game configuration
├── mouse.cfg             // Mouse settings
├── protectie.png         // Protection image
├── lib/                  // Library folder
├── mark/                 // Graphic assets
├── shop/                 // Offline shop folder (if applicable)
│   ├── shop.cfg          // Shop configuration file (if applicable)
ℹ️ If you have an offline shop, the "shop/" folder and "shop.cfg" file are required.
ℹ️ Autopatcher.exe must be properly configured for downloading updates.

That's it! This is the correct structure for AutoPatcher! 🚀


In AutoPatcher.cs

Updating Code for Resource Download


p1️⃣ Patch Server URL
This variable specifies the location from where AutoPatcher downloads the necessary files:

1
public static string PatchServerURL = "http://patcher.storym2.ro/patch/";
✅ Modify this URL to match your update server.
✅ This is where client files, including patchlist.txt and encrypted files, are stored.

//End of AutoPatcher Update



********************************************************************************************

