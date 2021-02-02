# MoodTracker
This is a console application, which provides statistics on your mood based on the entries you make in it (meant to be used once per day to keep stats relevant).
My primary goal with this application was to try out concurrency with files, thus it uses a json file to load and save data to. In addition, if you use the reset option,
it will take the old data and write it to a different json file (not loaded in the program).
