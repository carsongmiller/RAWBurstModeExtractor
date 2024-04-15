A simple GUI application that allows you to extract DNG images from a RAW file containing a "roll" of RAW images. 

Specifically, I developed this program for use with Canon CR3 images created using RAW Burst Mode on newer Canon cameras, since Canon's Digital Photo Professional software sort of sucks.

DNGLab does all the actual conversion behind the scenes--you must provide this program a DNGLab exe in order for it to do anything.  Can be found at the DNGLab github page [here](https://github.com/dnglab/dnglab)

This applciation simply allows you to point it to a copy of dnglab.exe, point it at some RAW image "roll" files (Canon prefixes them with "CSI"), view a preview if you'd like, and then click extract and get a bunch of individual RAW image files.

Developed as a .NET winforms application.  I don't believe it will work on any platform except for Windows.
