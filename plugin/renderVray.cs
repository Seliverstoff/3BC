//  Backburner Bat Creater (3BC)
//
//  http://seliverstoff.blogspot.ru/search/label/3BC
//
//  Author: Maxim A. Seliverstov (aka Seliverstoff)
//  E-Mail: maxim@seliverstoff.ru
//
//  This program is free software; you can redistribute it and/or
//  modify it under the terms of the GNU General Public License
//  as published by the Free Software Foundation; either version 2
//  of the License, or (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
//  All Rights Reserved. Backburner(R) is a registered trademark of Autodesk, Inc.

using System;

namespace BBB
{
	public class renderVray : en
	{
		public renderVray ()
		{
			engineName = "V-ray Standalone render";
			label_path = "Vray path";
			filter_scene_file_text = "V-ray scene files (*.vrscene)";
			filter_scene_file_exec = "*.vrscene";
			filter_exec_render_text = "Файл пограммы vray.exe";
			filter_exex_render_exec = "vray.exe";

			atr_scene_file = " -sceneFile=\"%X%\"";
			//atr_range_frame = " -range %X% %Y%";
			//atr_single_frame = " –frame %X%";
			atr_file_out = " -imgFile=\"%X%\"";
			//atr_file_format = String.Empty;
			//atr_tile = " -tile %X% %Y% %W% %H%";
			//atr_step = " -step %X%";

/*

Usage:
  vray -server
or
  vray <option> <option> ...

where option (case-sensitive) is one of the following:
([] means optional string, {} means the string can be repeated
zero or more times)

    -credits - print copyright notices for V-Ray and available plugins.

    -configFile - the path and file name to the vray config file
         Note that additional paths for V-Ray plugins can also be specified
         with the VRAY_PLUGINS_x64 environment variable.
         (default is vrayconfig.xml in the same folder as vray.exe).

    -include="includePath{;includePath}" - specify path(s) for include files.
         More than one -include options can be specified.

    -numThreads=nnn - set the number of rendering threads
         (default is 0 - automatic)

    -portNumber=n - specifies the port number to use for distributed
         rendering. The port numbers of the render servers and the render
         client must match for DR to work. The port can also be overridden
         using the VRAY_DR_CONTROLPORT environment variable. This command
         line option overrides the environment variable.
         (default is 20204)

    -verboseLevel=n - specifies the verbose level of information printed
         to the standard output: 0 - no information printed; 1 - only errors;
         2 - errors and warnings; 3 - errors, warnings and informational
         messages; 4 - all output
         (default is 3)

    -sceneFile="filename.vrscene" - the scene file to render

    -display=0/1 - show the rendered image in a window
         (default is 1 - show the rendered image)

    -displaySRGB=0/1 - determines if the sRGB option of the V-Ray VFB will be
         turned on or off initially. This can also be specified with the
         VRAY_VFB_SRGB environment variable. The command line option overrides
         the environment variable.
         (default is 0 - sRGB is off)

    -displayLUT=0/1 - determines if the LUT option of the V-Ray VFB will be
         turned on or off initially. This can also be specified with the
         VRAY_VFB_LUT environment variable. The command line option overrides
         the environment variable. The LUT file itself can be specified with
         the VRAY_VFB_LUT_FILE environment variable.
         (default is 0 - LUT is off)

    -displayAspect=0/1 - determines if the pixel aspect option of the V-Ray VFB
         will be turned on or off initially. This can also be specified with the
         VRAY_VFB_PIXEL_ASPECT environment variable. The command line option
         overrides the environment variable.
         (default is 0 - pixel aspect is off)

    -rtEngine=0/1 - renders with the RT engine instead of the normal V-Ray core

    -rtTimeOut=fff - specifies a timeout value for a frame when using the RT
         engine. fff is a floating-point number representing time in minutes.
         (default is 0.0 - no timeout)

    -rtNoise=fff - specifies noise threshold for a frame when using the RT
         engine. fff is a floating-point number.
         (default is 0.001)

    -rtSampleLevel=N - specifies maximum paths per pixel when using the RT
         engine. N is an integer number.
         (default is 0 - no limit)

    -autoClose=0/1 - automatically closes the displayed image when rendering
         is complete
         (default is 0 - wait for user to close the VFB).

    -setfocus=0/1 - set the focus on the VFB window if displayed.
         (default is 1 - set the focus)

    -distributed=0/1 - use distributed rendering
         (default is 0 - no distributed rendering)

    -renderhost="host{;host}" - use these host(s) for distributed rendering.
         Hosts can be specified either as computer names or by IPs. More than
         one -renderhost options can be specified.

    -imgFile="fileName" - write the resulting image to the given file.
         If the file name is empty, no image will be written.

    -imgWidth=nnn - set the output image width.
         (default is 640 or as specified in the .vrscene file)

    -imgHeight=nnn - set the output image height.
         (default is 480 or as specified in the .vrscene file)

    -region=x0;y0;x1;y1 - set the region to render.
         The integer values are in pixels, relative to the upper-left corner
         of the image.
         -region=none - ignore the region specified in the .vrscene file
         (default is full image or as specified in the .vrscene file)

    -crop=x0;y0;x1;y1 - set the crop region to render.
         The integer values are in pixels, relative to the upper-left corner
         of the image.
         (default is full image or as specified in the .vrscene file)

    -frames=b0[-e0[,s0]]{;bn[-en[,sn]]} - specify the frames and/or frame
         intervals to render. More than one -frames option can be specified.
         bX is the start frame, eX is the end frame, and sX is the frame
         increment. If not specified, the frames from the scene description
         are rendered.

    -interactive=0/1 - interactive mode
         (default is 0 - no interactive mode)

    -showProgress=n - specifies whether calculations progress should be
         printed to the standard output: 0 - do not display progress;
         1 - display progress only if verboseLevel is > 0; 2 - always.
         (default is 1)

    -progressUpdateFreq=n - specifies the progress update frequency in ms.
         Only one of -progressUpdateFreq and -progressIncrement is used,
         depending on which is specified last on the command line.
         (default is 200ms)

    -progressIncrement=n - specifies the progress increment in percentage.
         Only one of -progressUpdateFreq and -progressIncrement is used,
         depending on which is specified last on the command line.

    -progressUseCR=0/1 - controls how to use carriage return when outputting
         render progress. 0 uses regular \n line endings and is useful when
         redirecting the output to a file; 1 uses \r to save screen space.
         (default is 1)




*/



		}
	}
}

