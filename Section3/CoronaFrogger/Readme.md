#Rona Rabbit

![ronarabbit](https://user-images.githubusercontent.com/33173449/81188829-85d35800-8fbe-11ea-8214-2b14e8643d72.PNG)

You play as a rabbit who wants to avoid the Coronavirus and get to the other side of the road.
Every time you cross the road you get 100 points! If you touch the virus you will lose all the points you gained.

I made a player with circle collision. Every time I detect that I touched an enemy I reset the scene:

https://github.com/EladMotzny/unity-homework6/blob/b2a7e2a0c296f3f780503655d1ba73cdc61d3342/Section3/CoronaFrogger/Assets/Scripts/Rabbit.cs#L64-L70

For the enemy I made two prefabs, one that goes from left to right and the other right to left. The code is similar except some minor changes.
Each enemy will have a different speed and will get destroyed once it leaves the screen:
https://github.com/EladMotzny/unity-homework6/blob/b2a7e2a0c296f3f780503655d1ba73cdc61d3342/Section3/CoronaFrogger/Assets/Scripts/virusltr.cs#L8-L26

I have also made two spawners like the enemies. Each spawner have a few positions he can spawn an enemy (chosen randomly):
https://github.com/EladMotzny/unity-homework6/blob/b2a7e2a0c296f3f780503655d1ba73cdc61d3342/Section3/CoronaFrogger/Assets/Scripts/rtlSpawn.cs#L7-L29

For the score, I made a static int that gets reset when the player collide with an enemy and gets more points if the player reach the goal.
Even though the scene gets reset it will save the player score like so:
https://github.com/EladMotzny/unity-homework6/blob/b2a7e2a0c296f3f780503655d1ba73cdc61d3342/Section3/CoronaFrogger/Assets/Scripts/Goal.cs#L8-L13
