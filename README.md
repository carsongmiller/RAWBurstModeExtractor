# About
A simple GUI application that allows you to extract DNG images from a RAW file containing a "roll" of RAW images. 

Specifically, I developed this program for use with Canon CR3 images created using RAW Burst Mode on newer Canon cameras, since Canon's Digital Photo Professional software sort of sucks.

DNGLab does all the actual conversion behind the scenes--you must provide this program a DNGLab exe in order for it to do anything.  Can be found at the DNGLab github page [here](https://github.com/dnglab/dnglab) (Go to their releases page and scroll to the assets section of the latest release).

# How to Run
A pre-compiled executable has been included in the exe folder.  Simply download the entire contents of that exe folder and run the .exe file. (dnglab.exe must still be downloaded separately, as described above)

Alternatively, if you'd like, you can of course compile the source code yourself.

# How to use
Simply point this application at a copy of dnglab.exe, point it at some RAW image "roll" files (Canon prefixes them with "CSI"), view a preview if you'd like, and then click extract and get a bunch of individual RAW image files.

When you click extract, a windows powershell (or multiple if you've selected multiple images from which to extract) will open.  When those windows close, the extraction is complete.

Developed as a .NET winforms application.  I don't believe it will work on any platform except for Windows.
