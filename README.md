# About
Makes the pre-lobby process for Dark and Darker much faster by saving your gear loadouts and quickly searching for them on the in-game marketplace by clicking and typing on the screen automatically,
and also let you search and sell gear on your stash for the lowest price on the marketplace with a single hotkey. 

**Important:** at the moment this software only runs on 1080p or 1440p monitors running the game in fullscreen or borderless-fullscreen and only in non ultra widescreen monitors.

**Important:** this software controls your mouse and clicks the screen, it also takes screenshots to read prices on the marketplace, it all functions locally without being saved anywhere on the internet.

# How to run
Download the software on https://drive.google.com/file/d/1SwdJzz6miYVqvQ1RBMRf9ZopF4lNn2lR/view?usp=sharing


Launch the DaD Loadout Assistant.exe on the root folder

# How to use
First select your screen resolution on the bottom left radio buttons, at the moment these are the only avaliable resolutions, the selected resolution will be saved and not need to be reselected again after closing the software.

![instruction0](https://github.com/user-attachments/assets/bd26b1e4-7836-4421-878e-fe352340ee4b)

Now you must create a new Loadout: On the top right of the screen theres an empty text field, give it the desired loadout name and click on the **[+]** icon right next to it.

![instruction1](https://github.com/user-attachments/assets/a5b9455f-338f-4993-8926-9cec4ab83447)

Now Click on the **[Add Item]** button on the the right side of the screen, a item will be added to the center tab, fill it out with the desired item details.
The price textbox is optional, but if added the full price of the loadout will be calculated on the bottom right of the screen.

![instruction2](https://github.com/user-attachments/assets/25e73961-3f25-4d24-a920-bad093610805)

Do this for every desired piece of gear on your loadout. now **with the game open in your main monitor** open the marketplace in the game and click the [Search Full] or [Search Basic] buttons next to the item you want to buy, the software 
will control the mouse and fill the filters on the marketplace automatically and search the item, **this will realize several clicks on screen, always on the main monitor so make sure you have the game open in the main monitor!!** do **not** move your mouse
while the item is being searched.

**[Search Full]** will search for the item including it's extra attributes, **[Search Basic]** will search for the item only with the selected rarity

![instruction3](https://github.com/user-attachments/assets/53d03b51-9cdb-40ed-b354-a29f4a18af83)

To save changes to the loadout press the **[Save Loadout]** button, all saved loadouts will be located on the loadout folder, inside the root folder (DaD Loadout Assistant\loadouts), there you can delete any undesired loadout files, loadouts generated
by others can be copied and pasted on this folder so feel free to share your loadout with friends!

![instruction4](https://github.com/user-attachments/assets/be331537-0e4c-479f-929e-a3019dd09c91)

Alternately by pressing the hotkey **[F5]** or clicking the [Open Loadout Sidebar] button a small window you appear on top the game, the window is always on top and make so you can search for various items without having to alt+tab to the loadout software.
This window can be closed by pressing **[F5]** again.

![instruction5](https://github.com/user-attachments/assets/6e3a91ff-335b-4479-8bfc-e38d1b79b9a0)

# Selling Items
Pressing **[F2]** on the lobby screen opens the **My Listings** tab. (Marketplace->My Listings)

While on the **My Listing** tab hovering over an item in your stash or inventory and pressing the **[F1]** hotkey will search the item on the marketplace. (This only clicks the Search button the middle of the ingame screen)
.

Pressing **[F3]** will then return to the My Listing tab with the item selected and click on the price textbox, **[F4]** will instead sell the item for the lowest price on the marketplace
(when on the Marketplace Tab and not on the My Listing tab), you will still have to confirm the sale.
This will take a screenshot of the price of the cheapest item on the marketplace and read from the image, the read value can be wrong, so **be sure to check the inserted value before confirming the sale!**

# Known issues
Sometimes the ingame ui might not load fast enough to keep up with the clicks, the solution is to just try again in most cases.

Because of how the search filter in the marketplace works some items will always be incorrectly selected when searching for the item from the loadout, for example
when searching for a Turnshoe the Laced Turnshoe always show first and is then picked by the software.

When using the Sell Cheapest option the software might read the value wrong, while the changes of this happening seems kind of rare always be sure to check the value before confirming the sale.

# Other
The software is coded in C#,windows form on visual studio.


Im not a programmer, so the code is by consequence simply awful, however this software does work and saves a ton of time, i have been using it for around 6 months now and personally think its pretty useful, hopefully you think the same!

And thanks to Nuke for helping with the github stuff
