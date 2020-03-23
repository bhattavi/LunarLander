# LunarLander

Project: Lunar Lander

You will create a simple version of the classic game “Lunar Lander”. The object of the game is to apply just enough thrust to the left, right and upward in order to safely land on a platform.

You can check you my project :

https://abhinavbhatt.itch.io/lunarlander

What are the requirements for the project?

The following are ​required​ to earn points for the project:

Menu Scene (5%)

- Title of the game, your name, Pace email and press space to start.

Game Scene (30%)

- Use squares/rectangles and/or other primitives to create a landscape. (refer to the example video).
- Create a couple of platforms (different color than the landscape).
- Use a triangle to represent the ship. have it start at the vertical top and horizontal center of the screen.

Gameplay (60%)

- The ship should use physics. Use gravity so the ship falls slowly (Hint: You can adjust gravity!).
- Here are the controls (they may feel a little backwards):

S = push up, A = push to the right, D = push to the left.

- The player has limited fuel to use.
- When they use the keys mentioned, it drains their fuel.
- If they are out of fuel they can no longer use thrust.
- Drain fuel for each “deltaTime” that goes by with a key held down.
- Show how much fuel is left. Format to 1 decimal place.
- Landing on a platform is a successful landing, touching the landscape is a failed landing.
- Do not switch scenes if they run out of fuel. Keep them in the current scene and just stop the input keys
from working.

Success / Failed! Scenes (5%)

- Show the words “Successful Landing!” or “Failed Landing!” and press space to return to main menu.
