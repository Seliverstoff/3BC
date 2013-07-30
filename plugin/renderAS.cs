using System;

namespace BBB
{
	public class renderAS : en
	{
		public renderAS ()
		{
			engineName = "Anime Studio render";
			label_path = "Anime Studio path";
			filter_scene_file_text = "Anime Studio scene files (*.anme)";
			filter_scene_file_exec = "*.anme";
			filter_exec_render_text = "Файл пограммы Anime Studio Pro.exe";
			filter_exex_render_exec = "Anime Studio Pro.exe";

			atr_scene_file = " -r \"%X%\"";
			atr_range_frame = " -start %X% -end %Y%";
			//atr_single_frame = String.Empty;
			atr_file_out = " -o \"%X%\"";
			atr_file_format = " -f %X%";
			atr_file_format_list = new string[] {"QT", "JPEG", "TGA", "BMP", "PNG", "SWF"};
			//atr_tile = String.Empty;
			//atr_step = String.Empty;


/*
Command-Line Rendering
Postby Lost Marble » Thu Mar 24, 2005 1:46 am

Starting with version 5.1, Anime Studio now includes a command-line rendering mode. For many people, this may not be of much interest - just use the GUI-based batch rendering mode instead. If you are interested in command-line rendering, you know who you are, so keep reading. 

To use Anime Studio for command-line rendering, all you need to do is type a simple command: 

Anime\ Studio\ Pro -r infile.anme 

This is the simplest way to invoke Anime Studio from the command-line. The command tells Anime Studio to render the file "infile.anme" and to produce a rendered output file (more on that below). It can be used directly from a command prompt, or can be integrated into whatever scripting environment you choose. 

(Each platform - Windows, Mac OS, and Linux has some specific quirks when using Anime Studio this way. Be sure to read the posts below to learn about your particular platform.) 

The following options are available: 

-r filename.anme This is the only required command. It tells Anime Studio to render the given file and then quit. No GUI will be launched. 

-v Runs the rendering job in "verbose" mode. In this mode, Anime Studio will print out messages about its status, including an estimate of the time remaining in the rendering job. 

-f format This tells Anime Studio what format to render the output as. Valid formats are QT (QuickTime - Windows and Mac only), JPEG, TGA, BMP, PNG, or SWF (Flash). The QT and SWF formats generate a single output file, while the other formats created numbered sequences of still images. If you don't specify a format, on Windows and Mac the default format is QT, on Linux the default is JPEG. 

-o outfile Specifies an output file. If you skip this option, the output file will have the same name as the input file, but with an extension matching the format you choose. 

-start frame Specifies the starting frame to render. If omitted, Anime Studio will start rendering at the document's start frame (usually 1). 

-end frame Specifies the last frame to render. If omitted, Anime Studio will render up through the last frame of the document. 

The following options control rendering options, just like you see in the Export Animation dialog in Anime Studio, and can be turned on or off with a value of yes or no. The default value is marked with an asterisk. 

-aa yes or no Antialiased edges 
-shapefx yes or no Render shape effects 
-layerfx yes or no Render layer effects 
-halfsize yes or no Render at half size 
-halffps yes or no Render at half frame rate 
-fewparticles yes or no Use reduced particles 
-extrasmooth yes or no Extra-smooth images 
-ntscsafe yes or no NTSC safe colors 
-premultiply yes or no Premultiply alpha 
-variablewidths yes/no* Variable line widths (only applies to SWF format) 

Here are some examples: 

Anime\ Studio\ Pro -r file.anme -o /movie/scene01/shot03/preview.mov -f QT -start 12 -aa no -halfsize yes 

Reading the options left-to-right, the command above will render the file "file.anme", creating the result "/movie/scene01/shot03/preview.mov", in QuickTime format, starting at frame 12 (and continuing to the document's end frame), with no antialiasing and at half the file's normal pixel dimensions. 

Anime\ Studio\ Pro -r file.anme 

And of course, the most simple example. This command would produce the file "file.mov" in QuickTime format on Windows and Mac, or a sequence of JPEG still images on Linux. 

Regarding QuickTime: When rendering from the command line, Anime Studio will use the codec and codec settings that you last used in Moho's GUI mode. So, to change the QuickTime settings used by the command line mode, you need to render a QuickTime movie (even a short, tiny one) in GUI mode, entering the settings you wish to use. 

Finally, be sure to read the notes below regarding your particular operating system. 

Let's build some Anime Studio render farms!ng system. 

Let's build some Anime Studio render farms!
*/

		}
	}
}

