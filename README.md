# WildSandbox

An MMORPG server emulator with extremely limited implementation of gameplay features, targeting the alpha version of WildStar.

## The objectives of this project

This was created for learning purposes and to make it possible to explore the game areas as they were during alpha testing.
This is not meant to become a full emulator for the game.
Some features may be implemented over time, but there is absolutely no goal to make the game playable.

## Current state

A lot of work was put into making a message serialization engine to enable full packet capture parsing and fast iteration of emulator features.
The emulator itself is currently in a bare-minimum state which enables the happy path of logging in with any account/password combination,
entering the world with a default character and moving around the starting area.

## Next steps

 - Implement creation and saving of characters.
 - Implement "cheats" support, especially to allow fast and free movement around the game.
 - Implement multiplayer movement sharing.
 
## Aknowledgements

Thanks to Fabian from Arctium for providing a client for build 6152 and giving me a few tips on the required messages to support game world entry.
