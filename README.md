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



//RO

/*******************************************************************************************
 * Sistem creat de Tallion, 2025
 * 
 * Website oficial: https://devm2code.com/
 * Discord: talion0127
 * Canal Discord: https://discord.gg/VZgzwacwFD
 * 
 * © Tallion 2025. Toate drepturile rezervate.
 *******************************************************************************************/

Start actualizare AutoPatcher


1. Generarea hash-urilor pentru fișierele clientului
Rulează SHA256HashApp.exe pentru a genera hash-urile tuturor fișierelor necesare.
Creează un folder nou, de exemplu, Metin2ClientHash, și plasează acolo clientul sau fișierele pentru care vrei să generezi hash-uri.
Salvează hash-urile în fișierul patchlist.txt.

2. Încărcarea fișierelor pe server
După ce patchlist.txt este generat, urcă-l pe subdomeniul https://server.mt.ro/patch/.
Încarcă și clientul (inclusiv fișierele relevante) pe https://server.mt.ro/patch/.

3. Configurarea AutoPatcher-ului
Compilează AutoPatcher-ul modificat astfel încât să utilizeze URL-ul https://server.mt.ro/patch/ pentru verificarea și descărcarea actualizărilor.
După ce este compilat, plasează Autopatcher.exe în folderul clientului.



Cum creezi folderul AutoPatcher corect
1️⃣ Creează un folder nou cu numele → Autopatcher
2️⃣ Adaugă următoarele fișiere și foldere în interior:

📂 Autopatcher/ (folder principal)


├── Autopatcher.exe       // Executabilul pentru patching
├── config.exe            // Configurare client
├── locale.cfg            // Setări limbă
├── metin2.cfg            // Configurația jocului
├── mouse.cfg             // Setări mouse
├── protectie.png         // Imagine protecție
├── lib/                  // Folder pentru librării
├── mark/                 // Fișiere grafice
├── shop/                 // Folder pentru offline shop (dacă există)
│   ├── shop.cfg          // Configurație shop (dacă există)
ℹ️ Dacă ai offline shop, folderul shop/ și fișierul shop.cfg sunt necesare.
ℹ️ Autopatcher.exe trebuie să fie configurat corect pentru descărcarea actualizărilor.

Atât, asta e structura corectă a AutoPatcher-ului! 🚀





In AutoPatcher.cs

Actualizare cod pentru descarcare resurse 


p1️⃣ URL-ul serverului pentru patching
Această variabilă specifică locația de unde AutoPatcher descarcă fișierele necesare:

1
public static string PatchServerURL = "http://patcher.storym2.ro/patch/";
✅ Modifică acest URL pentru a corespunde serverului tău de actualizări.
✅ Aici se află fișierele clientului, inclusiv patchlist.txt și fișierele criptate.

//Sfarsit actualizare AutoPatcher
