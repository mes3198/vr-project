# vr-project

### Coronavirus VR Simulation: Cover Your Cough

### The Idea/Motivation/Proposed Outcome
**Idea:** A VR Simulation that tracks and marks the trajectory/landing place of respitatory droplets ejected from a sneeze or a cough. In the proposed simulation, the user is seated at a cafe table with two VR people (Person A and Person B) and when Person A sneezes or coughs, the VR user will be able to see how far the respiratory droplets travel across the room, and where they land in the simulated room.

**Motivation:** The CDC recommends staying 6 feet apart to limit the spread of coronavirus. Why? Current science suggests that the coronavirus spreads through large (infected) respiratory droplets that are ejected into the air when we sneeze, cough or even sing/speak loudly. Even though this is common knowledge for many of us, it is sometimes easy to fall back into the routine of standing too close to each other, or continuing to gather with other people despite coughing or feeling ill. Visual representations can make an impact on these behaviors and aid in better comprehension of the concept. It can make it easier for some people to understand the importance of following spacing guidelines, as well as wearing a mouth covering in public or simply not going out when you have a cold or a cough. Since the rate of asymptomatic people is relatively high and the damage is to our most vulnerable populations is untold, it is important for people to understand the consequences and to modify their behavior accordingly. 

**Proposed Outcome:** An immersive VR experience wherin the Viewer is placed in a "familiar" situation (being seated at a cafe with other people.) When Person A sneezes/coughs over the table, the Viewer can follow the trajectory of the droplets as they land all over the cafe table (and it's cups, food and other items) as well as Person B sitting across that table. The final landing place of the droplets will be highlighted. It's pretty gross admittedly, but the ultimate outcome is that this an educational tool where people can see WHY the current health guidelines are in place, and why they are so important to continue following. 


### Interaction Techniques
**Set the scene** The VR user has the opportunity to change up the scene on the table. Any object on the table can be moved closer or farther from Person A (the sneezer.) This can add further impact as the viewer will see respiratory droplets land on mugs, handles and other objects that are often touched by others, and see how easily infected droplets can spread the virus. 

**Sneeze or cough? Mask or no mask?** The user will have 4 options: what is the respiratory droplet trajectory from a sneeze or cough? What is the trajectory when Person A has a mask on? How much contamination is caused then? The user will have the opportunity to play with these different settings to enhance the understanging of how important wearing a mask is. 

**Change the timeline**Once an option is selected, the VR user will have the option to speed up or slow down how long it takes for droplets to settle. (Some are larger and will fall more quickly, others are smaller and will take more time to fall.) Instead of waiting several minutes for all droplets to fall to see the final result, the user can skip to the end to see what the final scene looks like. The user will also have the option to reset the simulation and try a different option. 

### Outline of Planned Implementation
**Personas, User Research, Storyboards**
*  Who is our target group for this simulation, who is the most likely to use it?
*  What do users actually want, what are they looking for? What do they want to achieve or learn from this simulation?
* What’s a scenario where this might help the user, what scenario will this type of application be useful?

**Collection of data**
* It is crucial to collect the speed at which droplets of different sizes leave the mouth, where they will fall and how long the smaller droplets will linger in the air
* Collect data on a "typical" sneeze or cough, and how much of these "typical" ejections are comprised of small, medium or large droplets
* Collect data on typical airflow in a room

**Visual Design**
* Designing of how the droplets are going to be represented, what they will look like when ejected from the mouth, what do they look like hanging in the air, what do they look like when they land on various objects in the scene. 
* Design of the user interface: how to make it easy for the user to understand their option, to choose between them, to navigate through the proposed "timeline" and to go back and forth between settings
* Design of the scene: the cafe table, items on the table, the other people in the scene

**Implementation in Unity**
* Design the VR scene
* With collected statistics, recreate the movement of the respiratory droplets in the 4 different representations
* Create a fuction where the respiratory droplets leave a "mark" or "splatter" so the Viewer can see the result of the ejection
* Allow for these drops and splatter to hit objects (that may have been moved by the viewer
* Create navigation for the user to go back and forth through options and timeleines (pressing buttons, swiping)

**Testing**
* What does the user like/dislike?
* What should be changed and why?
* How interactable is the prototype?
* Does it work as expected?
* What can we improve/take out to make it easier to understand?

**Implementation in Unity**
* Taking lessons learned from user testing and implementing those changes

**Final delivery**
* Documentation
* Presentation

![Example1](https://blogs.3ds.com/simulia/wp-content/uploads/sites/18/2020/04/TimeAnimation_0042.png)

![Example 2](https://i.ytimg.com/vi/md6G2hqrhBE/maxresdefault.jpg)
