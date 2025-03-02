# About
A simple GUI application that allows you to extract DNG images from a RAW file containing a "roll" of RAW images. 

Specifically, I developed this program for use with Canon CR3 images created using RAW Burst Mode on newer Canon cameras, since Canon's Digital Photo Professional software sort of sucks.

DNGLab does all the actual conversion behind the scenes--you must provide this program a DNGLab exe in order for it to do anything.  

As of 1/3/2025, the latest release of DNGLab is 0.6.3.  However, there are features in version 0.7 (namely correct thumbnail generation) that are extremely helpful for users of this application.  So I've compiled a windows-compatible dnglab.exe and included it in this repository.

Official released of DNGLab can be found at the DNGLab github page [here](https://github.com/dnglab/dnglab) (Go to their releases page and scroll to the assets section of the latest release).

# How to Run
A pre-compiled executable has been included in the exe folder.  Simply download the entire contents of that exe folder and run the .exe file. (dnglab.exe must still be downloaded separately, as described above)

Alternatively, if you'd like, you can of course compile the source code yourself.

# How to use
Simply point this application at a copy of dnglab.exe, point it at some RAW image "roll" files (Canon prefixes them with "CSI"), view a preview if you'd like, and then click extract and get a bunch of individual RAW image files.

When you click extract, a windows powershell (or multiple if you've selected multiple images from which to extract) will open.  When those windows close, the extraction is complete.

Developed as a .NET winforms application.  I don't believe it will work on any platform except for Windows.

# Notes on using with Lightroom and suggested workflow
I hate to say it, but in the software's current state (as of february 28 2025 when I'm writing this), this software still does not create a 100% headache free solution for working with RAW burst mode files in lightroom.

I've found that although DNGlab has been updated so that thumbnails are indeed generated correctly for extracted images, so that you can view them nicely in the windows photo viewer, lightroom still does not show the photos accurately in the library module.  Some photos seem to show updated previews that DNGLab created, some seem to show the preview from the original thumbnail of the original raw burst image, and some seem to show a new preview from a different extracted image ... but I haven't played around enough to really find a rhyme or reason to when it works and when it doesn't.  But here's the fix I've found: on import, generate 1:1 previews for the images.  This will allow you to scroll through the images in the library module quickly and accurately.  The downside to this of course is that I believe it takes up more space on the hard drive than standard sized previews, but I did not find that standard sized previews worked to serve this same purpose.  1:1 were indeed required as far as I can tell.

That being said, and to partially restate myself, here is my current workflow when dealing with a bunch of RAW burst mode files that I'd like to look through in lightroom:
- I import any non-burst-mode photos to lightroom like you normally would.  In this step, if you import via the "copy" option, lightroom will not copy any burst mode files to your destination folder
- I then copy all of the burst mode files from my memory card to whatever folder you want (you don't need to do this, but it may be faster than reading directly off your memory card)
- I open RAW Burst Mode Extractor and select the folder containing all the burst files as my source
- You can set the destination directory to wherever you want, or have it export to the source dir, or into individual directories for each burst file.  Just up to you and how you'd like to organize your photos.  I personally export all the photos to a new folder right next to all the other images from that day that I already imported into lightroom
- Then extract the images using RAWBurstModeExtractor
- Now open lightroom, and we're going to import the newly extracted photos
- Click import in lightroom, then select the place where you just put all the extracted photos as your source
- Select the "Add" import option
- Select "Build Previews - 1:1" (this will take quite a while and a little bit of hard drive space, but I'm ok with that as this is the only way I've found to automatically generate image previews that are shown correctly in the library module so I can view the images quickly and easily)
- Wait for the import and building of previews to complete, and you should be good to go!

If anyone else has a different workflow to share that's better, or suggestions on how the program could be changed to make the workflow easier, please let me know or create an issue!
