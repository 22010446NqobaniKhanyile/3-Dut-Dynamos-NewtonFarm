# 3-Dut-Dynamos-NewtonFarm
 GAME'S CONCEPT
 
We inspire to develop a game related to Fruit Ninja, which Halfbrick company established in 
2010. In the Fruit Ninja game, players must swipe the device's touchscreen (mobile phone) 
using their fingers in slicing the fruit that pops up from the air.
We developed a Game for Personal computers the main goal is users must catch fruits 
(apples) dropping from the air move a box using arrow keys and get points. In the Game 
scenes, there are also bombs dropped from the air if the user catches them, it ends the game 
"Game Over".
As we were developing the dropping of fruit game component, we discovered Isaac Newton's 
law: the force that holds us on the ground is the same as the force that makes the apple fall. 
Hence, we called the game "Newton Farm".

Game Objects:

Square – The box controlled by the user to catch fruit is made up of multiple sprites
“Squares”. We coded a “Player” script to handle the speed and horizontal direction of the 
box. Then implemented a “boxer collider 2d” to detect collision between other objects such 
as apples and bombs.

Spawner – We implemented this component to simulate dropping red apples. Then added its
own script to determine the distance and position.

Bomb spawner- This one simulates the dropping of the bombs. We also added here its own 
script to determine the distance and position.

Canvas – We implemented this component to include lobby and terminate features. Canvas 
allows adding texts such as “Play”,” Quit”, and” Game over”.

Score system – In the “Player” and “Fruit” scripts we initialized the score variable and 
simulated that for each apple that hit the box, it is going to increment plus 10 that is why if a 
user catches some fruit, they get a score.

Floor, Cloud, Baxkground trees, and Rock – We dragged and dropped those objects to make an 
effective background.

Left and Right - We dragged and dropped and added to them “Box collider 2D” to avoid the 
box (We made them to be not transparent, limiting the box to not go outside of the scene)
from disappearing.
