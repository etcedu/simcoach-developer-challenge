# simcoach-developer-challenge

This document mirrored from: https://docs.google.com/document/d/1hg-ZHYJgNAriVf1g231ArvjrRBztxIwdnYS9WyNrIpI/edit?usp=sharing




Simcoach Games Developer’s Challenge
    In this test you’ll be modifying an existing project by adding new features and assets according to a provided spec. Some of these requests are more detailed than others; if you think you’re missing information or you’re unsure what’s being asked for, just make your best guess and roll with it. Part of this job is making quick decisions in the moment and moving on; be creative!

If you don’t already have Unity ready, download and install it from here: https://store.unity.com/download-nuo. The project is built for 2020.3.2f1 but it should work in most versions of Unity past 2018.

The base project is hosted on GitHub here: https://github.com/etcedu/simcoach-developer-challenge
(If you’re not comfortable with Git, you can download the project as a zip file under the “Code” button)

When you get the project opened up in Unity you should be able to hit “Play” right away to see the starting state. If you trouble getting the base game up and running, please contact us right away.

This test is designed to help us understand how you think about challenges and the choices you make to solve them. Knowledge of the Unity engine will help, but you should be able to get up to speed very quickly if you have any coding experience. Feel free to use any resources you need to complete the test; a quick web search on any Unity feature/problem should return plenty of helpful posts.
1. Add a new feature: autosave and load
Sometimes you have to step away from the computer for a bit; when that happens you certainly don’t want to lose all your hard earned progress. Implement a system that saves the player’s progress through the game such that quitting and relaunching the game starts the player on the last stage they completed.

Required: Save data to an external data file that can be accessed on the player’s computer/device.

2. Add Feature: Fresh Perspectives
The designer thinks the game would be more interesting if the player could switch camera angles while playing. Add at least 2 additional player perspectives to the game in any way you think works best.

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
Time pressure can add excitement and danger to any game! Maybe. Implement a timer that stops the game when expired. The timer should reset on each new stage and and visible to the player in some way.
