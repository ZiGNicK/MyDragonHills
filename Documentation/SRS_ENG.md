# Project Requirements
### Content
1. [Introduction](#1)
2. [User requirements](#2) <br>
  2.1. [Software interfaces](#2.1) <br>
  2.2. [User interface](#2.2) <br>
  2.3. [User characteristics](#2.3) <br>
  2.4. [Assumptions and dependencies](#2.4) <br>
3. [System requirements](#3.) <br>
  3.1 [Functional requirements](#3.1) <br>
  3.2 [Non-functional requirements](#3.2) <br>
     3.2.1 [Quality Attributes](#3.2.1) <br>
4. [Analogs](#4) <br>

### 1. Introduction <a name="1"></a>
DragonHills is a game simulator of dragon escape from the parental nest. You have to help him extend his walk as long as possible, for that you will get points. Along the way there is a chance to find crystals that will simplify the walk in next games.

### 2. User requirements <a name="2"></a>
#### 2.1. Software interfaces <a name="2.1"></a>
This game is based on the Unity3D engine version 2018.2.2f1 (64bit)

#### 2.2. User interface <a name="2.2"></a>

- Main menu

This screen will provide the Player with the following features:
1. Start the game
2. Enter the in-game store
3. View FAQ section
4. Change game settings
5. See the leaderboard

  ![MainMenu](https://github.com/ZiGNicK/MyDragonHills/blob/master/Mockups/Menu.png)
  
- Gameplay screen

The gameplay screen, where the Player slides over the hills, collecting points and crystals.
Below you can see how far the player has passed in the current sector.
There is also a pause button.

  ![GamePlay](https://github.com/ZiGNicK/MyDragonHills/blob/master/Mockups/Brills_2.jpg)
  
With a perfect slide off the hill, the player gets accelerated and have longer fly ("SWOOSH!" Effect). With a series of 3 SWOOSH! the dragon begins to spew flames and gives the Player additional points for each second of the effect (Fire Breath)

  ![SWOOSH](https://github.com/ZiGNicK/MyDragonHills/blob/master/Mockups/Swoosh.jpg)

#### 2.3. User characteristics <a name="2.3"></a>

The target audio of this game will cover all age categories due to the simple but addictive gameplay.

#### 2.4. Assumptions and dependencies <a name="2.4"></a>

To install this application on the device, the file with the .apk extension is used. On some little-known models of smartphones, this type of files is not recognized by the system and additional utilities must be installed. Also, the standard defender of the security of some Android devices may take the file as a threat to the system and you need to specify in the settings a personal permission to install from this file.

### 3. System Requirements <a name="3"></a>

This game is supported by all smartphones and tablets with the Android operating system version 4 and above.

#### 3.1. Functional requirements <a name="3.1"></a>
The user has the following options:
   1. Start the new game by clicking on the appropriate button on the main menu screen;
   2. Enter the in-game store;
   3. View the FAQ section;
   4. Enable / disable sound effects;
   5. Enable / disable music effects;
   6. See the leaderboard;
   7. During the game, control the angle of the whelp in order to achieve the best slip;
   8. Exit the game.

#### 3.2. Non-functional requirements <a name="3.2"></a>
  ##### 3.2.1. Quality Attributes <a name="3.2.1"></a>
Nice interface, the most understandable to players of all ages;
Addictive gameplay
### 4. Analogs  <a name="4"></a>
The following sources of inspiration were found on the open spaces of Google Play:
- [Dragon,Fly!](https://play.google.com/store/apps/details?id=com.lsgvgames.slideandfly)
  - The main ideological inspirer
- [Dragon Hills](https://play.google.com/store/apps/details?id=com.rebeltwins.dragonhills)
  - A game where the basic mechanics are similar to the SWOOSH mechanics.
- [Balls Journey](https://play.google.com/store/apps/details?id=io.voodoo.ballsjourney)
  - A game where the basic mechanics are similar to the SWOOSH mechanics.
