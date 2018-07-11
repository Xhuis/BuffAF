# BuffAF
A very simple mod for Terraria that automatically uses nearby buff tiles when you respawn.

The mod does this by overriding the OnRespawn and OnEnterWorld methods to call a new method, BuffPlayer, when they themselves are called. This method gets a 9x9 tile square centered around the spawn tile, and checks every tile in that square; if a tile is one of the four buff objects (ammo box, bewitching table, crystal ball, sharpening station), it applies the object's buff for 10 minutes and plays a sound.

Unfortunately, this mod doesn't cause recalling home through magic mirrors and recall potions to apply the buffs, as there are no hooks that call when that happens. Maybe I can yell at blushie about it... (or, better yet, make it my dang self!)

You are free to decompile, modify etc. this mod under the MIT License. The mod is available in-game through the mod browser, and will always be up-to-date.
