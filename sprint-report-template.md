# Sprint 2 Report 
[Video Link](https://youtu.be/jo_KBJqXBdk)
## What's New (User Facing)
 * Data Persistence: This is the main feature - workouts and meals are actually logged.
 * Calendar Backend: This is scaffolding to the previous issue - we developed an internal structure for the calendar backend.
 * Goal Form: This allows you to set any workout goal, and check if 

## Work Summary (Developer Facing)
In the first sprint, our team developd a GUI "skeleton" of our program. We wrote all the GUI logic and let the user enter all necessary input for our program. However, nothing actually happened with that input. In this sprint, we've created backend logic, along with building a connection from the user input to the backend. This allows for file loading and saving functionality, along with the ability to perform statistical analysis on the data to provide information to the user. This required getting an in-depth understanding of serialization and JSON file formatting. For now, we do very rudimentary analysis on this data.

## Unfinished Work
We did not get the goal form analysis working entirely - we finished the backend later than expected, and prioritized other features instead of goal checking.

## Completed Issues/User Stories
Here are links to the issues that we completed in this sprint:

 * [Data Persistence](https://github.com/calebh13/fitness-tracker-app/issues/5)
    This is the main feature - workouts and meals are actually logged.
 * [Calendar Backend](https://github.com/calebh13/fitness-tracker-app/issues/11)
    This is scaffolding to the previous issue - we developed an internal structure for the calendar backend.
 * [Workout](https://github.com/calebh13/fitness-tracker-app/issues/12) and [Nutrition](https://github.com/calebh13/fitness-tracker-app/issues/13)
 * [Goal Form](https://github.com/calebh13/fitness-tracker-app/issues/4) - this was originally going be Lucas's feature for the previous sprint, so he worked on it this sprint instead.
 
 ## Incomplete Issues/User Stories
 Here are links to issues we worked on but did not complete in this sprint:
 
 * [Display Progress and Statistics](https://github.com/calebh13/fitness-tracker-app/issues/14) - this issue was worked on, but not fully completed. We decided that the more in-depth analysis was fit for Sprint 3.
 * [Create User class](https://github.com/calebh13/fitness-tracker-app/issues/7) - this issue was too reliant on backend functionality, so we will be working on it for Sprint 3.

## Code Files for Review
Please review the following code files, which were actively developed during this sprint, for quality:
 * [MainForm.cs](https://github.com/calebh13/fitness-tracker-app/blob/main/Fitness%20Tracker%20App/MainForm.cs)
 * [WorkoutForm.cs](https://github.com/calebh13/fitness-tracker-app/blob/main/Fitness%20Tracker%20App/WorkoutForm.cs)
 * [ucDays.cs](https://github.com/calebh13/fitness-tracker-app/blob/main/Fitness%20Tracker%20App/ucDays.cs)
 
## Retrospective Summary
Here's what went well:
  * The team worked with good cohesion and team work. We had multiple members with complicated scheduling requirements and prior engagements and we still managed to professionally and effectively work together.
  * All of the member had a very strong learnings in C#. The design practices and syntax of OOP programming with C# is new to several of our group members and they did a very good job hitting the ground running and getting started.
  * Our usage of Github was quite streamlined due to our prior experience in internships and other classes as well as our practice from the previous sprint.
 
Here's what we'd like to improve:
   * We could do a better job communicating the expectations and division of work between our different group members. Although each member did a very good job with what they were explicitly assigned, they did not always know what exactly they were supposed to be doing.
   * We could have done a better job using proper OOP concepts. Although the program is very strong for the group members who are inexperienced in C#, there are some design decisions that could lead to more code reuse in the future. 
   * We could improve in terms of our future planning. While we have a very good view of what is due during a particular sprint, it is sometimes hard to plan out what should be made during which sprint and how they will all combine together in the final sprint. 
  
Here are changes we plan to implement in the next sprint:
   * To improve our communication, we plan to set up a specific group chat with linked pings to the KanBan board so that each member knows what specifically they are supposed to be working on and when.
   * To improve our OOP practices, the group members who are experienced with C# and object oriented programming in general will be doing mock 'code reviews' to ensure that all the code is up to our standards. 
   * To improve our future planning, we will take the time to plan out how our past sprints will be recombined in our final sprint so that we have a cohesive final product.
