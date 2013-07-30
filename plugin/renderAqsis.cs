using System;

namespace BBB
{
	public class renderAqsis : en
	{
		public renderAqsis ()
		{
			engineName = "Aqsis render (TODOO)";
			label_path = "Aqsis path";
			filter_scene_file_text = "RenderMan scene files (*.rib)";
			filter_scene_file_exec = "*.rib";
			filter_exec_render_text = "Файл пограммы aqsis.exe";
			filter_exex_render_exec = "aqsis.exe";


/*

Aqsis command line renderer
Usage: C:\Program Files (x86)\Aqsis\bin\aqsis.exe [options] [RIB file...]
  -h, -help              Print this help and exit
  -version               Print version information and exit
  -pause                 Wait for a keypress on completion
  -progress              Print progress information
  -Progress              Print PRMan-compatible progress information (ignores -progressformat)
  -progressformat=string printf-style format string for -progress
  -endofframe=integer    Equivalent to "endofframe" RIB option
  -v, -verbose=integer   Set log output level
                         0 = errors
                         1 = warnings (default)
                         2 = information
                         3 = debug
  -echoapi               Echo all RI API calls to stdout as RIB
  -z, -priority=integer  Control the priority class of aqsis.
                         0 = idle
                         1 = normal
                         2 = high
                         3 = RT
  -type=string           Specify a display device type to use
  -addtype=string        Specify a display device type to add
  -mode=string           Specify a display device mode to use
  -d, -fb                Same as --type="framebuffer" --mode="rgb"
  -crop x1 x2 y1 y2      Specify a crop window, values are in screen space.
  -nc, -nocolor          Disable colored output
  -frames f1 f2          Specify a starting/ending frame to render (inclusive).
  -framelist=string      Specify a range of frames to render, ',' separated with '-' to indicate ranges.
  -beep                  Beep on completion of all ribs
  -res x y               Specify the resolution of the render.
  -option=string         A valid RIB Option string, can be specified multiple times.
  -shaders=string        Override the default shader searchpath(s)
  -archives=string       Override the default archive searchpath(s)
  -textures=string       Override the default texture searchpath(s)
  -displays=string       Override the default display searchpath(s)
  -procedurals=string    Override the default procedural searchpath(s)


*/

		}
	}
}

