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
using System.Collections.Generic;

namespace BBB
{
	// Пустой класс для наследования, просто описывает структуру для потомков
	public class en
	{
		public String engineName = String.Empty;
		public String exec = String.Empty;
		public String label_path = String.Empty;

		public String filter_scene_file_text = String.Empty;
		public String filter_scene_file_exec = String.Empty;
		public String filter_exec_render_text = String.Empty;
		public String filter_exex_render_exec = String.Empty;

		public String atr_scene_file = String.Empty;
		public String atr_range_frame = String.Empty;
		public String atr_single_frame = String.Empty;
		public String atr_file_out = String.Empty;
		public String atr_file_format = String.Empty;
		public String[] atr_file_format_list = {};
		public String atr_tile = String.Empty;
		public String atr_step = String.Empty;

		public Boolean script_enable = false;
		public Boolean file_out_enable = false;


		public en()
		{

		}

		public virtual void Print(){
			Console.WriteLine ("Empty Function");
		}

		public virtual void GUI_Settings(){

		}

	}

	// Основной класс, содержит коллекцию наследников от "en"
	// это перечень специфических параметров для каждого рендера
	public class Renders
	{
		public Dictionary<String, en> engine = new Dictionary<string, en>();
		//public enum engEn {Vue, Blender, Modo, Vray, Pixie, Aqsis, DLight, Air, AS };
		public enum engEn {Vray, Blender, Vue, AS};

		public Renders ()
		{
			engine.Add (Enum.GetName(typeof(engEn), 0), new renderVray ());
			engine.Add (Enum.GetName(typeof(engEn), 1), new renderBlender ());
			engine.Add (Enum.GetName(typeof(engEn), 2), new renderVue ());
			engine.Add (Enum.GetName(typeof(engEn), 3), new renderAS ());

			//engine.Add (Enum.GetName(typeof(engEn), 4), new renderPixie ());
			//engine.Add (Enum.GetName(typeof(engEn), 5), new renderAqsis ());
			//engine.Add (Enum.GetName(typeof(engEn), 6), new renderDlight ());
			//engine.Add (Enum.GetName(typeof(engEn), 7), new renderAir ());
			//engine.Add (Enum.GetName(typeof(engEn), 8), new renderAS ());
		}
	}
}

