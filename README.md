# HW4
## Devlog
The MVC pattern is used here by using the event system and singleton. To start off when the game awakes the singleton code is used for the locator class. This class allows the other classes to access the player object easily. The player when it hits the score collider, it uses the event system to invoke the point event which the UI and audio is waiting for. When this happens, the UI changes the score on screen and the audio plays a score sound.

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites