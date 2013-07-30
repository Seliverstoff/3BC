using System;

namespace BBB
{
	public class renderPixie : en
	{
		public renderPixie ()
		{
			engineName = "Pixie render (TODOO)";
			label_path = "Pixie path";
			filter_scene_file_text = "RenderMan scene files (*.rib)";
			filter_scene_file_exec = "*.rib";
			filter_exec_render_text = "Файл пограммы rndr.exe";
			filter_exex_render_exec = "rndr.exe";


/*

Usage: rndr <options> file.rib [file.rib ...]
Listing several RIB files concatenates them before rendering.

Options:
  -f <range>      Render only a subsequence of frames
                    -f 43     = Render only the 43rd frame
                    -f 5:15   = Render frames 5 thru 15
                    -f 5:2:15 = Render every second frame from 5 thru 15
  -q              Quiet mode; errors and warnings are ignored
  -d              Ignore the display drivers and use framebuffer
  -t              Print renderer statistics after every frame
  -p              Display rendering progress
  -P:<n>          Render using <n> processes; default is using one process
  -t:<n>          Render using <n> threads; default is one thread per CPU core
  -r [port]       Start a network server. If given, use port <port>
  -k <serverlist> Stop network servers in <serverlist>
  -s <serverlist> Render on network servers in <serverlist>
                  <serverlist> specified as <IP[:port],IP[:port],...>
  -v              Display version information
  -h              Display this help

Environment variables:
  PIXIEHOME       Pixie installation path
  SHADERS         Shader search path


*/

		}
	}
}

