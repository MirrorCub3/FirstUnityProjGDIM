The scenes that I want to be looked at are MainMenu, 2DGameScene, and 3DGameScene. MainMenu will take the player into the two following scenes 
so it's not nessacary to look at them separately.

I created the tilesets, sprites, and animaions for the 2D parts of this mini project. The sphere chararacters in this scene are sprites. On the 
first scene (MainMenu), I implemented mouse-click interaction via Unity's UI button's onClick() function. When Start is clicked,
it will take the player to 2DGameScene. If the project was built, the Quit button would exit the game window.

In 2DGameScene, sprites examples are the bobbing spheres, the player character, the glass containing wings, and the door.
The player can move using A/D or left/right arrow keys and spacebar to jump/fly. Players must get over the wall, break the 
glass containing the wings (giving them a small wing power-up), then fly up to the button (by repeatedly hitting space) to open
the door. Once opened, the player will go through to the 3D scene. 

In the 3DGameScene, players can use WASD or arrow keys to move around rhe enclosed space. Clicking on the buttons will change
the player's body color which can be used to change the color of the nearby towers by bumping into them. Players can return to MainMenu
using the lower right button. This is another example of onClick() events and mouse interaction as well as keyboard inputs. 

At anytime, Esc can be clicked to return to MainMenu. It is ideal to have the camera ratio set to 16:9.