# MoodTracker
MoodTracker is an app, which keeps track of statistics on your mood based on the entries you make in it (meant to be used once per day to keep stats relevant).

It was made with the purpose of learning about file handling in C#. Thus it's data is comes from a json file, which the application creates, reads, updates and deletes from.

This repository contains:
- MoodTracker Console App: the original 'UI', fully functional.
- MoodTracker Library: Contains most of the code and is used by the other projects.
- MoodTracker Rest API: Made with the intention of easing the development of a potential web app.
- MoodTracker Test project: Contains any tests I've made for the project.

## Installation

To install MoodTracker:

1. Navigate to the [latest release](https://github.com/Noitcereon/MoodTracker/releases).
2. Download the `MoodTracker.v0.1.0.7z` (note: 7Zip or another archiver that can extract from .7z files is required).
3. Extract the contents of the file you just download to the place you want MoodTracker installed on your pc.
4. Go inside the extracted folder (MoodTracker v0.1.0) and run `MoodTrackerConsole.exe`.

This concludes the installation process.

## Usage

Once you have installed the app it is fairly simple to use.

When you start up the console app you should be presented with this console window:

![image](https://user-images.githubusercontent.com/40148361/181511064-aeb5ae94-9e5b-455b-8d52-2d7f12b38d60.png)

After this you simply enter a number, according to the action you want to take, and press ENTER. 

The entire application follows this flow or gives you instructions on what to enter.

### Example:

You see the menu screen and want to see your stats.
1. Write the number '2' as input
2. Press ENTER

![image](https://user-images.githubusercontent.com/40148361/181511206-24864755-2efd-43ec-98ba-1bcc09b5db66.png)

If you have any data in your system this screen will show. Otherwise you'll get a message saying no data is found.

-----------

NOTE:
If you use the reset option, it will take the old data and write it to a different json file (not loaded in the program), which can be located in the installation folder.

## Other

Trello board: https://trello.com/b/h5TX9Pc6/mood-tracker

## Maintainer

[Noitcereon](https://github.com/Noitcereon/)


