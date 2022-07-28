# MoodTracker
MoodTracker is an app, which keeps track of statistics on your mood based on the entries you make in it (meant to be used once per day to keep stats relevant).

It was made with the purpose of learning about file handling in C#. Thus it's data is comes from a json file, which the application creates, reads, updates and deletes from.

This repository contains:
- MoodTracker Console App: the original 'UI', fully functional.
- MoodTracker Library: Contains most of the code.
- MoodTracker Rest API: Made with the intention of easing the development of a potential web app.
- MoodTracker Test project: Contains any tests I've made for the project.

## Installation

[To-do]

## Usage

Once you have installed the app it is fairly simple to use.

When you start up the console app you should be presented with this console window:

![image](https://user-images.githubusercontent.com/40148361/181502625-2ef5141c-8fb1-48ac-a0c7-fcf1dba3e215.png)

After this you simply enter a number, according to the action you want to take, and press ENTER. 

The entire application follows this flow or gives you instructions on what to enter.

### Example:

You see the menu screen and want to see your stats.
1. Write the number '2' as input
2. Press ENTER

![image](https://user-images.githubusercontent.com/40148361/181503236-e6dd78e1-a253-4143-be37-7050f6282da7.png)

If you have any data in your system this screen will show. Otherwise you'll get a message saying no data is found.

-----------

NOTE:
If you use the reset option, it will take the old data and write it to a different json file (not loaded in the program), which can be located in the installation folder.

## Other

Trello board: https://trello.com/b/h5TX9Pc6/mood-tracker

## Maintainer

[Noitcereon](https://github.com/Noitcereon/)


