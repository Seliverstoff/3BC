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
	public class renderVue : en
	{
		public renderVue ()
		{
			engineName = "Vue xStream";
			label_path = "Vue path";
			filter_scene_file_text = "Vue xStream scene files (*.vue)";
			filter_scene_file_exec = "*.vue";
			filter_exec_render_text = "Файл пограммы Vue 10 xStream RenderNode.exe";
			filter_exex_render_exec = "Vue 10 xStream RenderNode.exe";
			atr_scene_file = " –file \"%X%\"";
			atr_range_frame = " -range %X% %Y%";
			atr_single_frame = " –frame %X%";
			atr_file_out = " -output \"%X%\"";
			atr_tile = " -tile %X% %Y% %W% %H%";
			atr_step = " -step %X%";

/*
		–file "[FILE_PATH]": specifies the scene file that will be loaded and rendered, and (optionally) 
		–frame X: indicates which frame to render if you don't want to render the entire animation (if 
		the scene is animated). If you don’t use this command, if the scene is animated, the entire 
		animation range will be rendered (the part between the start and end frames), using the 
		Animation Render Options – see page 538 – stored in the file.  

		-range X Y: indicates the range of frames that will be rendered (from X to Y inclusive). 
		Vue 10 Infinite & xStream – Reference Manual 
  
		-step S: sets the rendered frame increment (e.g., if set to 10, only frame 0, 10, 20… will be 
		rendered). 

		-job N: renders frame N-1 (for compatibility reasons with BackBurner that numbers jobs 
		starting with 1). 

		-output "[FOLDER_PATH]": specifies a path to a folder where all output images should be 
		saved (it overwrites the output paths set in the scene, and only keeps the base names). 

		-tile X Y W H: (New to Vue 10!) specifies the tile of the image to render. (X,Y) will be the top-
		left corner of the tile, and (W,H) will be its size (in pixels). Warning: The size of the tile will 
		be (W+1)*(H+1) since the first row/column is taken into account. For instance -tile 0 0 64 64 
		will output 1 65x65 tile.will output 1 65x65 tile.
*/


		}

		public override void Print(){
			Console.WriteLine("This is Vue");
		}

		public override void GUI_Settings(){

		}


	}
}

