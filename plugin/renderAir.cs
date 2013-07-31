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
	public class renderAir : en
	{
		public renderAir ()
		{
			engineName = "Air render (TODOO)";
			label_path = "Air path";
			filter_scene_file_text = "RenderMan scene files (*.rib)";
			filter_scene_file_exec = "*.rib";
			filter_exec_render_text = "Файл пограммы air.exe";
			filter_exex_render_exec = "air.exe";

/*

Command Line Switches 
 Previous  Top  Next  

You can view an abbreviated list of command line options by starting Air with an argument of - 
 air -  
The following command line arguments are recognized by Air: 
-anim nframes (starttime endtime (fractionopen)) 
 Generates a sequence of nframes frame blocks with shutter times for animating time-varying RIB files.  
-at name token value 
 Define a custom attribute with a string or float value (the equivalent of Attribute "name" "token" [value]).  
-bs width (height) 
 Sets the size (in pixels) of the buckets or tiles used for rendering.  
-columns 
 Use column bucket order.  
-crop left right top bottom 
 Restricts rendering to a subrectangle. Each coordinate should lie in the range 0 to 1. This switch is equivalent to the CropWindow call with the same coordinates.  
-d 
 Forces the rendered image to appear in Air Show  
-e filename 
 Saves error messages and warnings to a file.  
-echoproc 
 Echoes the output from any procedural RunPrograms to stdout  
-echorif 
 Echoes the output from any RI filters to stdout  
-file imagename 
 Forces image output to the specified file. This switch overrides any Display call in the scene.  
-frames start end 
 Restricts rendering to frames numbered between start and end, inclusive. AIR 8 and later will also use this range for expanding a frame number range in a RIB file name.E.g.,  
 air -frames 19 21 scene#4f.rib  
 would render scene0019.rib, scene0020.rib, and scene0021.rib.  
-g n 
 Sets the default gamma.  
-indirect 
 Enable object visibility to indirect rays.  
-ipp 
 Enabled the indirect diffuse prepass  
-mf n 
 Sets the default value for GeometricApproximation "motionfactor"  
-mode rgb|rgba 
 Selects the channels for output. This setting may be overridden by a subsequent Display call.  
-nodisp 
 Ignore/suppress Displacement calls.  
-noerror 
 Ignore/suppress all error and warning messages.  
-nosurf 
 Ignore subsequent Surface calls. The surface shader used will be defaultsurface or the surface shader declared in an air.rib file in AIRHOME or the local directory.  
-nowarn 
 Suppresses warning messages during rendering  
-opp 
 Enable the occlusion prepass  
-opt name token value 
 Define a custom option with a string or float value (the equivalent of Option "name" "token" [value]).  
-p nthreads (or -threads nthreads) 
 Sets the number of processor threads to use. This option overrides any option that sets the number of threads in the RIB file.  
-pri priority 
 Sets the task priority for the renderer under Windows. Possible values are 0 (normal priority) or -1 (low priority). Rendering at low priority allows "foreground" applications such as a modeler to run unimpeded while Air renders in the background.  
-Progress 
 Causes the renderer to print progress information to the standard output stream. Progress is reported as a string formated as:  
 R90000 xxx% mmmK  nnnK tttS  
 where xxx is the percentage complete, mmm is the current memory used in kilobytes, nnn is the peak memory used in kilobytes, and ttt is the elapsed time in seconds.  
-q16 
 Set quantization for rgb and rgba output to 16-bit.  
-qfloat 
 Set quantization for rgb and rgba output to floating-point precision.  
-reflect 
 Enable object visibility to reflection rays. Shorthand for Attribute "visibility" "integer trace [1]  
-res width (height) 
 Sets the resolution of the rendered image. This option overrides any subsequent Format call in the RIB stream. If height is omitted, a square image is rendered.  
-rif "rifiltername args" 
 Define a default RIB filter plugin for the scene.  
-rows 
 Use row tile order.  
-samples xsamples (ysamples) 
 Sets the size of the array of geometry samples per pixel. This option overrides any subsequent PixelSamples call.  
-shadows 
 Enables object visibilty to shadow rays. Shorthand for Attribute "visibility" "integer transmission" [1]  
-showpath 
 Print the full path name for each resource as it is loaded.  
-silent 
 Suppresses the progress report when rendering.  
-spiral 
 Use spiral tile order.  
-stats 
 Print statistics for the rendered scene.  
-surf shadername 
 Overrides all surface shaders with the provided shader. Shader parameters can be set by including a comma-separated list:  
 air -surf plastic,Kd=1,Ks=0 myscene.rib  
 Only float and string type parameters are supported.  
-step n 
 Specifies an increment to use when rendering animation frames. For example, if step=2, every other frame will be renderered.  
-vhost ipaddress 
 Connect to an instance of Vortex executing on the machine at ipaddress. Not available in the demo version.  
See Also 
Command Line Rendering of Massive Scenes 
 Previous  Top  Next  
The scene files generated by Massive can be rendered by invoking AIR from a terminal window or command shell. An individual frame can be rendered by providing the name of the main rib file as an argument to air: 
air rib/frame0001.rib 
AIR accepts multiple rib files on a single command line. Multiple files are processed in order from left to right. Additional small files with RIB commands can be used to customize a rendering without modifying the main scene file. For example, one could use the small file quant16.rib to render an output image with 16-bit values: 
air quant16.rib scene.rib 
Command Line Switches 
AIR provides many command line options for customizing the renderer's behavior without modifying the main rib file. A list of command line options can be printed with: 
air - 
A list of options with brief descriptions can be found in the Reference section of this manual. This tutorial introduces a few of the more commonly used options. 
Multithreaded Rendering 
The number of threads can be set with a -p or -threads option: 
air -p 2 rib/frame0001.rib 
The default number of rendering threads is equal to the number of detected processing cores. 
Image Size and Output Destination 
Use -res to override the image width and height set in the rib file: 
air -res 320 240 scene.rib 
The output image file generated by the rendering can be set with -file: 
air -file occlusion.tif scene.rib 
The image type is determined by the file name extension. To force output to the AIR Show framebuffer instead of to a file, use the -d switch: 
air -d scene.rib 
Pixel Samples and Shading Rate 
AIR has two main controls for image quality. The pixel samples option determines the number of times the scene geometry is sampled per pixel. E.g., a pixel samples setting of 4 will use a 4x4 grid of samples at every pixel. Use -samples to override the pixel samples setting on the command line: 
air -samples 4 scene.rib 
Increase the number of pixel samples to improve the quality of geometry sampling. 
The shading rate determines the shading quality of an image. Shading rate is defined as the area in pixels covered by a single shading sample. A lower shading rate produces a higher quality image. For example, a shading rate of 0.25 will produce 4 shading samples per pixel. The -sm command line option is a multiplier for the shading rate setting in the rib file: 
air -sm 0.25 scene.rib 
Bucket Size and Bucket Order 
By default AIR renders an image in 32x32 pixel tiles or buckets, one row at a time top to bottom. Using a smaller bucket size may reduce peak memory use and provide better load balancing with multiple threads. Set the bucket size with -bs: 
air -bs 32 scene.rib 
Rendering by column instead of by row can also help minimze memory use for crowd scenes. Use -ltor or -columns to render in columns, left to right: 
air -ltor scene.rib 
Surface Shader Override 
The -surf switch overrides all Surface shaders declared in the rib file with the alternate shader provided. Alternative surface shaders can be used for rendering multiple output passes from a single scene file. E.g., 
air -surf occlusionpass -file occlusion.tif scene.rib 
A related option, -nosurf, suppresses all Surface shaders in the scene file, rendering the scene with the defaultsurface shader which provides simple shading based on the surface normal. The nosurf option is useful for quick tests and for debugging. For example, if your scene is rendering black, rendering with -nosurf will indicate whether the agents are missing or just lacking illumination. 
Statistics 
Rendering statistics can be enabled with -stats: 
air -stats scene.rib 
Rendering Multiple Frames 
AIR 8 allows a frame sequence to be rendered with simple frame number substitution. For example, 
 air -frames 8 10 scene#f.rib  
would render scene8.rib, scene9.rib, and scene10.rib. The frame number pattern can also be zero-padded: 
 air -frames 8 10 scene#3f.rib  
would render scene008.rib, scene009.rib, and scene010.rib. 
See Also 


*/

		}
	}
}

