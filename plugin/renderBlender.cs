using System;

namespace BBB
{
	public class renderBlender : en
	{


		public renderBlender ()
		{
			engineName = "Blender 3D";
			label_path = "Blender Path";
			filter_scene_file_text = "Blender scene files (*.blend)";
			filter_scene_file_exec = "*.blend";
			filter_exec_render_text = "Файл пограммы blender.exe";
			filter_exex_render_exec = "blender.exe";

			atr_scene_file = " -b \"%X%\"";
			atr_range_frame = " -s %X% -e %Y% -a";
			atr_single_frame = " -f %X%";
			//atr_file_out = " -o \"%X%\"";
			//atr_file_format = " -F %X%";
			//atr_file_format_list = new string[] {"TGA", "IRIS", "HAMX", "FTYPE", "JPEG", "MOVIE", "IRIZ", "RAWTGA",
			//									"AVIRAW", "AVIJPEG", "PNG", "BMP", "FRAMESERVER",
			//									"HDR", "TIFF", "EXR", "MPEG", "AVICODEC", "QUICKTIME", "CINEON", "DPX"};
			//atr_tile = " -tile %X% %Y% %W% %H%";
			//atr_step = " -step %X%";

			//script_enable = true;

/*
Introduction

In some situations we want to increase the render speed, access blender remotely to render something or build scripts that use blender command line.

One advantage of using command line is that we don't need the X server (in case of Linux) and as a consequence we can render remotely by SSH or telnet.

Note! Arguments are executed in the order they are given!

blender -b file.blend -a -x 1 -o //render
...Wont work, since the output and extension is set after blender is told to render.

Always position -f or -a as the last arguments.

Description

Usage: blender [-b <dir><file> [-o <dir><file>][-F <format>][-x [0|1]][-t <threads>][-S <name>][-f <frame>][-s <frame> -e <frame> -a]] [[-P <scriptname> [-- <parameter>]]

Render options:

 -b <dir><file> Render <file> that is inside the <dir> without load the UI
   -P <filespec>Run the specified Python script (filename or Blender Text)
   -S <name>    Set scene <name>
   -f <frame>   Set frame <frame> to render and save it (Don't use together with -a)
					-j <number>  Render every x frames (jump frames by this number)
					[-s <frame>] [-e <frame>] -a
					Set start frame (-s), end frame (-e) or both.
					The order is important and it's possible to use only the -s or the -e                
                alone.
   -o <dir><file>    
                Set the render path and file name.
                Use // as <dir> to use the path render relative to the blend file.
                Use # in the filename to be replaced with the frame number
                  eg: blender -b foobar.blend -o //render_# -F PNG -x 1
   -F <format>  Set the render format, Valid options are..
                TGA IRIS HAMX FTYPE JPEG MOVIE IRIZ RAWTGA
                AVIRAW AVIJPEG PNG BMP FRAMESERVER
      (formats that can be compiled into blender, not available on all systems)
       HDR TIFF EXR MPEG AVICODEC QUICKTIME CINEON DPX
   -x [0|1]     Set option to add the file extension to the end of the file, 0 means   
                no and 1 means yes.
   -t <threads> Use amount of <threads> for rendering
Animation options: (Used when pressing the play button, blender behaves like a movie player)

 -a <options> <file(s)>        Playback <file(s)>, only operates this way when -b is not used.
   -p <sx><sy> Open with lower left corner at <sx>,<sy> (Doesn't work on win)
					-m          Read from disk (Don't buffer)
Window options:

 -w            Force opening with borders (default)
 -W            Force opening without borders (Linux/Unix Only)
 -p <sx> <sy> <w> <h>  Open with lower left corner at <sx>, <sy>
                       and width and height <w>, <h>
Game Engine specific options:

 -g fixedtime          Run on 50 hertz without dropping frames
 -g vertexarrays       Use Vertex Arrays for rendering (usually faster)
 -g noaudio            No audio in Game Engine
 -g nomipmap           No Texture Mipmapping
 -g linearmipmap       Linear Texture Mipmapping instead of Nearest (default)
Misc options:

 -d            Turn debugging on
 -noaudio      Disable audio on systems that support audio
 -h            Print this help text
 -y            Disable script links, use -Y to find out why its -y
 -P <filename> Run the given Python script (filename or Blender Text)
 -R            Register .blend extension
 -v            Print Blender version and exit
Examples

Render a picture
# blender -b file.blend -o //file -F JPEG -x 1 -f 1
-b file.blend  : File .blend to render
-o //file  : Directory + Target image file
-F JPEG  : JPEG image format
-x 1  : Adds an extension .jpg to the file name
-f 1  : Render frame 1
Render a movie
# blender -b file.blend -x 1 -o //file -F MOVIE -s 003 -e 005 -a 
-b file.blend  : File .blend to render
-x  : Adds an extension .avi to the movie
-o //images/file : Directory + Target image file
-F MOVIE  : This saves a .AVI movie with low compression
-s 003 -e 005 -a : Set start frame to 003 and end frame to 005. Important: You can use -s or -e, but if they're not in order, they'll not work!
5. Important: You can use -s or -e, but if they're not in order, they'll not work!

*/

		}

		public override void GUI_Settings(){
		

		}

	}
}

