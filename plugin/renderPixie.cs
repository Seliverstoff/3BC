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

