# Upgrading Spaceships game

based on the game we learned in class.

- ## Add 3 'hit points' before spaceship destruction

The code was changed in only one file: 
https://github.com/EladMotzny/unity-homework6/blob/67e15ad875a7f88a664970ee3dd4b2713639915f/Section1/02-collisions/Assets/Scripts/3-collisions/DestroyOnTrigger2D.cs#L8-L38

the hit points are adjustable and we can set it to be any other number from the unity inspector.

Each hit of the spaceship with the enemy will cause the spaceship to lose one life but the enemy will be ruined anyway.
