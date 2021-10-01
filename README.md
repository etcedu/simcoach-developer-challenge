# simcoach-developer-challenge

This document mirrored from: https://docs.google.com/document/d/1hg-ZHYJgNAriVf1g231ArvjrRBztxIwdnYS9WyNrIpI/edit?usp=sharing

Simcoach Games Developer’s Challenge

In this challenge you’ll be modifying an existing project by adding new features and assets according to a provided spec. Some of these requests are more detailed than others; if you think you’re missing information or you’re unsure what’s being asked for, just make your best guess and roll with it. Part of this job is making quick decisions in the moment and moving on; be creative!

If you don’t already have Unity ready, download and install it from here: https://store.unity.com/download-nuo. The project is built for 2020.3.2f1 but it should work in most versions of Unity past 2018.

The base project is hosted on GitHub here: https://github.com/etcedu/simcoach-developer-challenge
(If you’re not comfortable with Git, you can download the project as a zip file under the “Code” button)

When you get the project opened up in Unity you should be able to hit “Play” right away to see the starting state. If you have trouble getting the base game up and running, please contact us right away.

This test is designed to help us understand how you think about challenges and the choices you make to solve them. Knowledge of the Unity engine will help, but you should be able to get up to speed very quickly if you have any coding experience. Feel free to use any resources you need to complete the test; a quick web search on any Unity feature/issue/functionality should return plenty of helpful posts.

Don’t worry about polishing your additions too much; consider this a grey box development environment and you would expect a polish pass later down the line.

Deliverable: Archive your finished Unity project (zip, 7zip, rar, whatever’s easiest for you) and return it to 
khohman@sigma-resources.com along with a short written description of what decisions you made, what assumptions you made for specific tasks, and any other details you feel are important for us to know.

Timeframe: ~3 days or ~12 hours. Keep track of how much time you spend in total and on each task you tackled (completed or not) and include that information with your deliverable documentation.

1. Add Feature: Autosave & Load

Sometimes you have to step away from the computer for a bit; when that happens you certainly don’t want to lose all your hard earned progress. Implement a system that saves the player’s progress through the game such that quitting and relaunching the game starts the player on the last stage they completed.

	Required: Save data to an external data file that can be accessed on the player’s computer/device.

2. Add Feature: Fresh Perspectives

The designer thinks the game would be more interesting if the player could switch camera angles while playing. Add a first person perspective and an over-the-shoulder chase camera to the game.

	Required: Allow the player to switch between these camera angles with some form of input while the game is running.

3. Add Feature: Verisimilitude

It would make a lot more sense if you couldn’t “dig” piles of dirt with the backend of a dozer. Redesign the dozer such that dirt must be hit by the front/plow in order to be removed from the field.

	Bonus: Can you set it up so that swinging the plow sideways into dirt doesn’t count as a hit?

4. Asset Implementation: Doze Better

Matt made a much better dozer model in time for the big client meeting coming up. Replace the current dozer in game with the model named “Dozer_Better” in the “Models” folder.

5. Asset Implementation: User Interface

Arial is great and all, but it’s a tad overused. Replace the current stage indicator label with the new art called “stagePanel” in the “UI” folder.

	Required: Make sure it doesn’t end up saying “Stage: Stage: 0” when you’re done.
	
6. Bonus Feature: Ultimate Power

This game could be even more fun if you could, say, add rockets to you dozer, maybe? Add some form of power-up to the game; for example: a temporary speed boost; mega bomb that clears the screen; wider plow; etc. Be creative! 

7. New Mechanic: Timer

Time pressure can add excitement and danger to any game! Maybe. Implement a timer that stops the game when it expires. The timer should reset on each new stage and be visible to the player in some way.

	Bonus: Can you make it possible for the player to restart the game without having to close and relaunch?

8. New Mechanic: Dash Attack

Mobility feels good. Implement a “dash” action that jumps the player forward a short distance in a short period of time. Bind this action to the Shift keys and limit its use with a cooldown time between activations.

	Required: There should be some visual indication that lets the player know when they are able to dash.

9. Technical Improvement: Dirt Tracking

In the future it may be useful to know which dirt piles remain on the field. Set up a system to track the currently active dirt piles, removing those that are hit by the player. Output a debug message with the number of piles remaining on each hit.

	Bonus: Add a UI element to show the player exactly how many dirt piles are remaining on the field.

10. Technical Improvement: Empire of Dirt

There’s so much dirt in the world it seems unfair to limit a player to just one type. Make a new dirt prefab object using the model “Dirt_Pile_Simple_001” in the “Models” folder and modify the dirt spawning code in DozerGameManager.cs to include it as a possible spawn with a 50% chance of spawning the new dirt when generating a stage.

12. Technical Improvements: Character Select

A new challenger approaches! Create a new Dozer type that can be swapped out with the existing Dozer. This new Dozer should have different stats (drive speed, turn speed, etc) and be at least a different color. The player doesn’t need to be able to switch Dozers at runtime; it’s fine to need to change them up in-editor (as if we were testing different Dozer internally). It should function identically to the original Dozer with regards to controls and dirt collection.

	Bonus: Allow the player to pick which Dozer they want to use when the game first starts.
	
13. Asset Implementation: Audio

Now that most of the game is complete, we’d like to begin integrating audio into the experience. A designer has pushed a set of audio files into the “Assets/Audio” folder, hopefully descriptively named. Integrate whatever selection of sounds, ambience, and music that you feel is most impactful in the time that you have available. 

	Bonus: Implement a mute button that silences all audio in the game.
	
	Double Bonus: Implement two mute buttons, one for sound effects and one for music.

14. Free Space: Go Wild

If you’ve still got time after all of that, do something cool! Show off a feature of Unity you like, add some new art, post processing effects, sound effects and music; whatever you can imagine that you think will improve the experience.

