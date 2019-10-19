# C# basic filter

This is a very basic filter implemented in C# as a console application.

The application currently only works with ".jpg" images. The image has to be included in the res folder within the same directory as the executable file for it to work.

When the application starts, the user is asked for the filename. Make sure to omit the file extension. If an invalid name is provided, the program will output the exception raised.

Upon entry of a valid file name, the program will read the jpg image, convert to bitmap, manipulate the pixels to remove all red colours and then resave as a jpg within the res folder, adding a "-nored" to the end of the file name.